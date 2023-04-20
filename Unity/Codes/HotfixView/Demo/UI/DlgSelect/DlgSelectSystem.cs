using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;
using System.Net.Http.Headers;
using System.Linq;
using static System.Collections.Specialized.BitVector32;
using JetBrains.Annotations;
//using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
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
            LevelComponent levelcomponent = self.ZoneScene().GetComponent<LevelComponent>();
            int count = chapters.childCount;
            for (int i = 0; i < count; i++)
            {
                Transform chapter = chapters.GetChild(i).transform;
                int levelCount = chapter.childCount;
                for (int j = 0; j < levelCount; j++)
                {
                    Transform level = chapter.GetChild(j).transform;
                    if (levelcomponent.LevelData.Count + 1 >= j + i * 10 + 1)
                    {
                        //判断星级
                        if (levelcomponent.LevelData.Count + 1 > j + i * 10 + 1)
                        {
                            int stars = levelcomponent.LevelData[j];
                            if (stars == 3)
                            {
                                level.GetComponent<Image>().sprite = IconHelper.LoadIconSprite("SelectLevel", "FlagFinish");
                                //chapter.GetChild(3).gameObject.SetActive(true);
                            }
                            else
                            {
                                level.GetComponent<Image>().sprite = IconHelper.LoadIconSprite("SelectLevel", "FlagNorme");
                            }

                            for (int t = 0; t < stars; t++)
                            {
                                level.GetChild(0).GetChild(t).GetComponent<Image>().sprite = IconHelper.LoadIconSprite("SelectLevel", "Star");
                            }
                            for (int t = 0; t < chapter.GetChild(j).GetChild(1).childCount; t++)
                            {
                                level.GetChild(1).GetChild(t).GetComponent<Image>().sprite = IconHelper.LoadIconSprite("SelectLevel", "PathBeanBright");
                            }

                        }
                        else if (levelcomponent.LevelData.Count + 1 == j + i * 10 + 1)
                        {
                                chapter.GetChild(j).GetComponent<Image>().sprite = IconHelper.LoadIconSprite("SelectLevel", "FlagBright");
                        }
                    }
                    
                    int a = i, b = j;
                    level.GetComponent<Button>().AddListener(() => { self.LevelInfo(a * 10 + b + 1); });

                }
            }

            //章节按钮第一章置灰
            self.View.E_LastChapterButton.interactable = false;
            NumericComponent numericcomponent = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>();
            self.RefreshForm(numericcomponent.GetAsInt(NumericType.TowerId1), numericcomponent.GetAsInt(NumericType.TowerId2), numericcomponent.GetAsInt(NumericType.TowerId3), numericcomponent.GetAsInt(NumericType.TowerId4));
        }

        //关卡介绍
        public static void LevelInfo(this DlgSelect self, int index)
        {
            self.currentLevelId = index;
            LevelConfig levelConfig = LevelConfigCategory.Instance.Get(self.currentLevelId);
            self.currentLevelCount = levelConfig.MonstersId.Length;
            self.View.E_ChapterIntroductImage.gameObject.SetActive(true);
            self.View.E_MapIntImage.sprite = IconHelper.LoadIconSprite("MapRes", ("Map" + (self.currentLevelId)));
            self.View.E_LeveNameText.text = levelConfig.LevelName;
            self.View.E_IntroductLeveText.text = levelConfig.LevelDis;
            //怪的滑动列表
            self.AddUIScrollItems(ref self.ScrollItemEnemyItems, self.currentLevelCount);
            self.View.E_EnemysLoopHorizontalScrollRect.SetVisible(true, self.currentLevelCount);

            //判断星级
            LevelComponent levelcomponent = self.ZoneScene().GetComponent<LevelComponent>();
            if( levelcomponent.LevelData.Count >= self.currentLevelId - 1)//长度为已经打了的  若现在打了1关 则第三关打不了  count 
            {
                self.View.E_FightButton.interactable = true;
            }
            else
            {
                self.View.E_FightButton.interactable = false;
            }
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
            Transform chapters = self.View.E_ChaptersImage.transform;
            for (int i = 0; i < self.currentChapterCount; i++)
            {
                if(i == self.currentChapterId)
                {
                    if(i == 0)
                    {
                        self.View.E_LastChapterButton.interactable = false;
                        self.View.E_NextChapterButton.interactable = true;
                    }
                    else if(i == self.currentChapterCount - 1)
                    {
                        self.View.E_NextChapterButton.interactable = false;
                        self.View.E_LastChapterButton.interactable = true;
                    }
                    else
                    {
                        self.View.E_LastChapterButton.interactable = true;
                        self.View.E_NextChapterButton.interactable = true;
                    }
                    Transform chapter = chapters.GetChild(i).transform;
                    chapter.gameObject.SetActive(true);
                }
                else
                {
                    Transform chapter = chapters.GetChild(i).transform;
                    chapter.gameObject.SetActive(false);
                }
                
            }
        }

        //点击按钮进行章节切换
        public static void ChapterSwitching(this DlgSelect self, int operate)
        {
            int arrive = 0;
            if (operate == -1)
            {   
                if(self.currentChapterId == 0)
                {
                    self.View.E_LastChapterButton.interactable= false;
                }
                else
                {
                    arrive = self.currentChapterId + operate;
                }

            }
            else if (operate == 1)
            {
                if(self.currentChapterId == self.currentChapterCount - 1)
                {
                    self.View.E_LastChapterButton.interactable = false;
                }
                else
                {
                    arrive = self.currentChapterId + operate;
                }
            }
            self.View.E_ChapterSelectDropdown.value = arrive;
            self.ChapterSelect();
        }

        //怪滑动列表项
        public static void OnScrollMonsterItemRefreshHandler(this DlgSelect self, Transform transform, int index)
        {
            Scroll_Item_Enemy monsteritem = self.ScrollItemEnemyItems[index].BindTrans(transform);
            LevelConfig levelConfig = LevelConfigCategory.Instance.Get(self.currentLevelId);
            int id = levelConfig.MonstersId[index];
            FightItemConfig fightItemConfig = FightItemConfigCategory.Instance.Get(id);
            monsteritem.E_MonsterIconImage.sprite = IconHelper.LoadIconSprite("monster", fightItemConfig.ResourceCode);
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

        public static void RefreshForm(this DlgSelect self, int tower1, int tower2, int tower3, int tower4)
        {
            if (tower1 != 0)
            {
                FightItemConfig fightItemConfig1 = FightItemConfigCategory.Instance.Get(tower1);
                self.View.E_Tower1ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig1.ResourceCode);
            }
            else
            {
                self.View.E_Tower1ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
            }
            if (tower2 != 0)
            {
                FightItemConfig fightItemConfig2 = FightItemConfigCategory.Instance.Get(tower2);
                self.View.E_Tower2ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig2.ResourceCode);
            }
            else
            {
                self.View.E_Tower2ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
            }
            if (tower3 != 0)
            {
                FightItemConfig fightItemConfig3 = FightItemConfigCategory.Instance.Get(tower3);
                self.View.E_Tower3ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig3.ResourceCode);
            }
            else
            {
                self.View.E_Tower3ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
            }
            if (tower4 != 0)
            {
                FightItemConfig fightItemConfig4 = FightItemConfigCategory.Instance.Get(tower4);
                self.View.E_Tower4ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig4.ResourceCode);
            }
            else
            {
                self.View.E_Tower4ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
            }

        }
    }
}



