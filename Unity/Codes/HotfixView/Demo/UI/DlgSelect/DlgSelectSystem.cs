using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;
using System.Net.Http.Headers;
using System.Linq;
using static System.Collections.Specialized.BitVector32;
//using UnityEditor.VersionControl;

namespace ET
{
    [FriendClass(typeof(DlgSelect))]
    [FriendClassAttribute(typeof(ET.LevelComponent))]
    public static class DlgSelectSystem
    {


        public static void RegisterUIEvent(this DlgSelect self)
        {
            self.View.E_BackBaseButton.AddListener(() => { self.CloseWindow(); });//返回标签
            self.View.E_ChapterSelectDropdown.onValueChanged.AddListener((int index) => { self.ChapterSelect(); });
            self.View.E_IntroductCloseButton.AddListener(() => { self.CloseChapterIntroductWindow(); });
            self.View.E_NextChapterButton.AddListener(() => { self.ChapterSwitching(1); });
            self.View.E_LastChapterButton.AddListener(() => { self.ChapterSwitching(-1); });
            self.currentChapterCount = self.View.E_ChapterSelectDropdown.options.Count;
            self.View.E_FightButton.AddListener(() => { self.EnterMatch(); });
            self.View.E_EnemysLoopHorizontalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrollMonsterItemRefreshHandler(transform, index); });//怪滑动列表项
            self.View.E_AdjustButton.AddListener(() => { self.AdjustForm(); });

        }

        [Obsolete]
        public static void ShowWindow(this DlgSelect self, Entity contextData = null)
        {
            self.Refresh().Coroutine();
            self.Init();

        }

        public static void CloseWindow(this DlgSelect self)
        {
            self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Select);
            self.RemoveUIScrollItems(ref self.ScrollItemEnemyItems);
        }

        //关闭关卡介绍
        public static void CloseChapterIntroductWindow(this DlgSelect self)
        {
            self.View.E_ChapterIntroductImage.gameObject.SetActive(false);
        }

        //初始化
        [Obsolete]
        public static void Init(this DlgSelect self)
        {
            Transform chapters = self.View.E_ChaptersImage.transform;
            int stars;
            LevelComponent levelcomponent = self.ZoneScene().GetComponent<LevelComponent>();
            int count = chapters.childCount;
            for (int i = 0; i < count; i++)
            {
                Transform chapter = chapters.GetChild(i).transform;
                int levelCount = chapter.childCount;
                for (int j = 0; j < levelCount; j++)
                {
                    //判断星级
                    if (levelcomponent.LevelData.Count > j)
                    {
                        stars = levelcomponent.LevelData[j];
                        chapter.GetChild(j).GetChild(0).GetComponent<Image>().sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterChoose");
                    }
                    else
                    {
                        stars = 0;
                    }
                    
                    int a = i, b = j;
                    chapter.GetChild(j).GetComponent<Button>().AddListener(() => { self.LevelInfo(a * 10 + b); });

                }
            }
        }

        //关卡介绍
        public static void LevelInfo(this DlgSelect self, int index)
        {
            self.currentLevelId = index + 1;
            LevelConfig levelConfig = LevelConfigCategory.Instance.Get(self.currentLevelId);
            self.currentLevelCount = levelConfig.MonstersId.Length;
            self.View.E_ChapterIntroductImage.gameObject.SetActive(true);
            self.View.E_MapIntImage.sprite = IconHelper.LoadIconSprite("MapRes", ("Map" + (index + 1)));
            self.View.E_LeveNameText.text = levelConfig.LevelName;
            self.View.E_IntroductLeveText.text = levelConfig.LevelDis;
            //怪的滑动列表
            self.AddUIScrollItems(ref self.ScrollItemEnemyItems, self.currentLevelCount);
            self.View.E_EnemysLoopHorizontalScrollRect.SetVisible(true, self.currentLevelCount);

            //判断星级
            int stars;
            LevelComponent levelcomponent = self.ZoneScene().GetComponent<LevelComponent>();
            if(levelcomponent.LevelData.Count > index)
            {
                stars = levelcomponent.LevelData[index];
            }
            else
            {
                stars = 0;
            }
            Log.Debug("" + stars);

        }

        //刷新
        public static async ETTask Refresh(this DlgSelect self)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent component = unit.GetComponent<NumericComponent>();
            self.View.EText_CoinNumberText.SetText("Gold:" + component.GetAsLong(NumericType.Gold).ToString());

        }

        //章节选择
        public static void ChapterSelect(this DlgSelect self)
        {
            int index = self.View.E_ChapterSelectDropdown.value;
            self.currentChapterId = index;
            switch (index)
            {
                case 0:
                    {
                        self.View.E_Chapter1Image.gameObject.SetActive(true);
                        self.View.E_Chapter2Image.gameObject.SetActive(false);
                        break;
                    }
                case 1:
                    {
                        self.View.E_Chapter2Image.gameObject.SetActive(true);
                        self.View.E_Chapter1Image.gameObject.SetActive(false);
                        break;
                    }
            }
        }

        //点击按钮进行章节切换
        public static void ChapterSwitching(this DlgSelect self, int operate)
        {
            int arrive = 0;
            if (self.currentChapterId == 0 && operate == -1)
            {
                arrive = 0;
            }
            else if (self.currentChapterId == self.currentChapterCount && operate == 1)
            {
                arrive = self.currentChapterCount - 1;
            }
            else
            {
                arrive = self.currentChapterId + operate;
            }
            self.View.E_ChapterSelectDropdown.value = arrive;
            self.ChapterSelect();
        }

        //怪滑动列表项
        public static void OnScrollMonsterItemRefreshHandler(this DlgSelect self, Transform transform, int index)
        {
            for (int i = 0; i < self.currentLevelCount; i++)
            {
                Scroll_Item_Enemy monsteritem = self.ScrollItemEnemyItems[i].BindTrans(transform);
                monsteritem.E_MonsterIconImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterChoose");
            }

        }

        //进入战斗
        public static void EnterMatch(this DlgSelect self)
        {
            MatchHelper.EnterSingleMode(self.ZoneScene(), (self.currentLevelId)).Coroutine();
            self.CloseWindow();
        }

        public static void AdjustForm(this DlgSelect self)
        {
            self.ZoneScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Form);
        }
    }
}



