using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace ET
{
    [FriendClass(typeof(DlgGameUI))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(DlgGameUIViewComponent))]
    [FriendClass(typeof(ESButton_CreateTower))]
    [FriendClass(typeof(Base))]
    public static class DlgGameUISystem
    {
       
        public static void InitUI(this DlgGameUI self)
        {
            //获取所有塔为一个集合
            self.AllTowers.Add(self.View.ESButton_CreateTower1);
            self.AllTowers.Add(self.View.ESButton_CreateTower2);
            self.AllTowers.Add(self.View.ESButton_CreateTower3);
            self.AllTowers.Add(self.View.ESButton_CreateTower4);
            self.AllTowers.Add(self.View.ESButton_CreateTower5);
            self.AllTowers.Add(self.View.ESButton_CreateTower6);
            self.AllTowers.Add(self.View.ESButton_CreateTower7);
            self.AllTowers.Add(self.View.ESButton_CreateTower8);
            self.AllTowers.Add(self.View.ESButton_CreateTower9);
            self.AllTowers.Add(self.View.ESButton_CreateTower10);
            self.AllTowers.Add(self.View.ESButton_CreateTower11);
            self.AllTowers.Add(self.View.ESButton_CreateTower12);
            self.AllTowers.Add(self.View.ESButton_CreateTower13);
            self.AllTowers.Add(self.View.ESButton_CreateTower14);
            self.AllTowers.Add(self.View.ESButton_CreateTower15);
            self.AllTowers.Add(self.View.ESButton_CreateTower16);
            self.AllTowers.Add(self.View.ESButton_CreateTower17);
            self.AllTowers.Add(self.View.ESButton_CreateTower18);
            self.AllTowers.Add(self.View.ESButton_CreateTower19);
            self.AllTowers.Add(self.View.ESButton_CreateTower20);
            //
            //生成造塔的按钮
            int levelid = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().LevelId;//获取地图
            LevelConfig levelconfig = LevelConfigCategory.Instance.Get(levelid);
            MapConfig mapconfig = MapConfigCategory.Instance.Get(levelconfig.MapId);
            int[] PosX = mapconfig.PosX;
            int[] PosY = mapconfig.PosY;
            for (int i = 0; i < self.AllTowers.Count; i++)
            {
                if (i < PosX.Length)
                {
                    ESButton_CreateTower e = self.AllTowers[i];
                    self.CurrentTowers.Add(e);
                    e.uiTransform.position = new Vector3((float)(PosX[i] / 100.0f), (float)(PosY[i] / 100.0f), 0);
                    if(levelid <= 100)//单人地图
                    {
                        e.RegisterEventAndShowLabelAndRegisterPosition(1);
                    }
                    else//多人地图
                    {
                        if (i < PosX.Length / 2)
                        {
                            e.RegisterEventAndShowLabelAndRegisterPosition(1);
                        }
                        else
                        {
                            e.RegisterEventAndShowLabelAndRegisterPosition(2);
                        }
                    }
                }
                else
                {
                    ESButton_CreateTower e = self.AllTowers[i];
                    e.uiTransform.gameObject.GetComponent<RectTransform>().position = new Vector3(20000, 20000);
                }
            }
        }
        /*public static void PauseSingleGameMode(this DlgGameUI self)
        {
            GameHelper.PauseSingleGameMode(self.ZoneScene()).Coroutine();
        }
        public static void ContinueSingleGameMode(this DlgGameUI self)
        {
            GameHelper.ContinueSingleGameMode(self.ZoneScene()).Coroutine();
        }*/
        public static void HideRestartAndBack(this DlgGameUI self)
        {
            self.View.EButton_WinRestartGameImage.gameObject.SetActive(false);
            self.View.EButton_WinNextGameImage.gameObject.SetActive(false);
            self.View.EButton_LoseRestartGameImage.gameObject.SetActive(false);
        }
        public static void SingleModeHide(this DlgGameUI self)
        {
            self.View.ECreateMonsterAllImage.gameObject.SetActive(false);
            self.View.EInfoRightImage.gameObject.SetActive(false);
            self.View.E_SkillAllImage.gameObject.SetActive(false);
        }
        public static void MoveCurrentTower(this DlgGameUI self, Vector3 dir)
        {
            self.View.EListImage.transform.Translate(-dir * Time.deltaTime * self.VisualScale);
        }
        public static void VisualCurrentTower(this DlgGameUI self)
        {
            self.View.EListImage.transform.localScale = new Vector3(self.VisualScale, self.VisualScale, 1);
        }
        public static void SetCurrentTowerPos(this DlgGameUI self, Vector3 camerapos)
        {
            self.View.EListImage.transform.localPosition = new Vector3(-camerapos.x * 108.0f * self.VisualScale, -camerapos.y * 108.0f * self.VisualScale, 0);
        }
        public static void CloseOtherList(this DlgGameUI self, ESButton_CreateTower e)
        {
            for (int i = 0; i < self.CurrentTowers.Count; i++)
            {
                if (e != self.CurrentTowers[i])
                {
                    self.CurrentTowers[i].CloseListInfo().Coroutine();
                }
            }
        }
        public static void CloseAllTowerList(this DlgGameUI self)
        {
            for (int i = 0; i < self.CurrentTowers.Count; i++)
            {
                self.CurrentTowers[i].CloseListInfo().Coroutine();
            }
        }

        public static void RegisterUIEvent(this DlgGameUI self)
        {
            self.View.EButton_readyButton.AddListener(() => { self.onclick(); });
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent num = unit.GetComponent<NumericComponent>();

            self.View.ESCreateMonster1.RegisterEvenet(num.GetAsInt(NumericType.Monster1));
            self.View.ESCreateMonster2.RegisterEvenet(num.GetAsInt(NumericType.Monster2));
            self.View.ESCreateMonster3.RegisterEvenet(num.GetAsInt(NumericType.Monster3));
            self.View.ESCreateMonster4.RegisterEvenet(num.GetAsInt(NumericType.Monster4));
            //self.View.ESCreateMonster5.RegisterEvenet(num.GetAsInt(NumericType.Monster5));
            //self.View.ESCreateMonster6.RegisterEvenet(num.GetAsInt(NumericType.Monster6));
            //self.View.ESCreateMonster7.RegisterEvenet(num.GetAsInt(NumericType.Monster7));
            //self.View.ESCreateMonster8.RegisterEvenet(num.GetAsInt(NumericType.Monster8));
            self.InitVisualControl();
            self.View.E_CloseAllTowerButton.AddListener(() => { self.CloseAllTowerList(); });//关闭所有塔
            
            self.View.E_GameSettingButton.AddListener(() => { self.ShowSettingUI(); });//打开设置
            self.View.E_SettingCloseBaseSpriteButton.AddListener(() => { self.CloseSettingUI(); });//关闭设置
            self.View.E_SettingGiveUpBaseSpriteButton.AddListener(() => { self.ShowGiveUpUI(); });//打开投降
            self.View.E_GiveUpCloseSpriteButton.AddListener(() => { self.CloseGiveUpUI(); }) ;//关闭投降
            self.View.E_GiveUpSpriteButton.AddListener(() => { self.GiveUp(); });//投降

            self.View.EButton_WinRestartGameButton.AddListener(() => { self.RestartGame(); });//重新打
            self.View.EButton_LoseRestartGameButton.AddListener(() => { self.RestartGame(); });//重新打
            self.View.EButton_WinExitGameButton.AddListener(() => { self.ExitGame(); });//返回大厅
            self.View.EButton_LoseExitGameButton.AddListener(() => { self.ExitGame(); });//返回大厅
            self.View.EButton_WinNextGameButton.AddListener(() => { self.NextGame(); });

            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                self.View.E_NextWave1Button.AddListener(() => { self.NextWave(); });
                self.View.E_NextWave2Button.AddListener(() => { self.NextWave(); });
            }
        }
        public static void GiveUp(this DlgGameUI self)
        {
            GameComponent gameComponent = self.ZoneScene().CurrentScene().GetComponent<GameComponent>();
            if (gameComponent == null || gameComponent.GameEnding == false) return;
            gameComponent.GameEnding = false;
            int position = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position);
            if (self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)//单人
            {
                if (position == 1) self.ZoneScene().CurrentScene().GetComponent<GameComponent>().WinGame(2, 0).Coroutine();
                if (position == 2) self.ZoneScene().CurrentScene().GetComponent<GameComponent>().WinGame(1, 0).Coroutine();
            }
            else if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 2)
            {
                if (position == 1) self.ZoneScene().CurrentScene().GetComponent<GameComponent>().WinGame(2, self.ZoneScene().CurrentScene().GetComponent<GameComponent>().Base2.Hp).Coroutine();
                if (position == 2) self.ZoneScene().CurrentScene().GetComponent<GameComponent>().WinGame(1, self.ZoneScene().CurrentScene().GetComponent<GameComponent>().Base1.Hp).Coroutine();
            }
           
            self.View.E_SettingBaseSpriteImage.gameObject.SetActive(false);
            self.View.E_GiveUpBaseSpriteImage.gameObject.SetActive(false);
        }
        public static void ShowSettingUI(this DlgGameUI self)
        {
            self.View.E_SettingBaseSpriteImage.gameObject.SetActive(true);            
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                GameHelper.PauseSingleGameMode(self.ZoneScene()).Coroutine();
            }
        }
        public static void ShowGiveUpUI(this DlgGameUI self)
        {
            self.View.E_GiveUpBaseSpriteImage.gameObject.SetActive(true);
        }
        public static void CloseSettingUI(this DlgGameUI self)
        {
            self.View.E_SettingBaseSpriteImage.gameObject.SetActive(false);
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                GameHelper.ContinueSingleGameMode(self.ZoneScene()).Coroutine();
            }
        }
        public static void NextWave(this DlgGameUI self)
        {
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                self.HideAllNextWave();
                GameHelper.NextWaveSingleGameMode(self.ZoneScene()).Coroutine();
            }
        }
        public static void HideAllNextWave(this DlgGameUI self)
        {
            for(int i=0;i<self.View.E_AllNextWaveImage.transform.childCount;i++)
            {
                self.View.E_AllNextWaveImage.transform.GetChild(i).gameObject.SetActive(false);      
            }
        }
        public static void CloseGiveUpUI(this DlgGameUI self)
        {
            self.View.E_GiveUpBaseSpriteImage.gameObject.SetActive(false);
        }
        public static void SetVisual(this DlgGameUI self, int Visual)
        {
            self.VisualControl = Visual;
        }
        public static float SetVisualScale(this DlgGameUI self, float Scale)
        {
            self.VisualScale = self.VisualScale + Scale;
            if (self.VisualScale >= 2) self.VisualScale = 2;
            if (self.VisualScale <= 1f) self.VisualScale = 1f;
            return self.VisualScale;
        }
        public static void InitVisualControl(this DlgGameUI self)
        {
            self.VisualControl = 0;//视角移动参数
            self.VisualScale = 1;//视角尺寸
            //往左
            EventTrigger.Entry entry1 = new EventTrigger.Entry();
            entry1.eventID = EventTriggerType.PointerEnter;
            entry1.callback.AddListener((data1) =>
            {
                self.SetVisual(1);
            });
            self.View.EvisualLEventTrigger.triggers.Add(entry1);
            EventTrigger.Entry entry2 = new EventTrigger.Entry();
            entry2.eventID = EventTriggerType.PointerExit;
            entry2.callback.AddListener((data2) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualLEventTrigger.triggers.Add(entry2);

            //往左上
            EventTrigger.Entry entry3 = new EventTrigger.Entry();
            entry3.eventID = EventTriggerType.PointerEnter;
            entry3.callback.AddListener((data3) =>
            {
                self.SetVisual(2);
            });
            self.View.EvisualLUEventTrigger.triggers.Add(entry3);
            EventTrigger.Entry entry4 = new EventTrigger.Entry();
            entry4.eventID = EventTriggerType.PointerExit;
            entry4.callback.AddListener((data4) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualLUEventTrigger.triggers.Add(entry4);

            //往上
            EventTrigger.Entry entry5 = new EventTrigger.Entry();
            entry5.eventID = EventTriggerType.PointerEnter;
            entry5.callback.AddListener((data5) =>
            {
                self.SetVisual(3);
            });
            self.View.EvisualUEventTrigger.triggers.Add(entry5);
            EventTrigger.Entry entry6 = new EventTrigger.Entry();
            entry6.eventID = EventTriggerType.PointerExit;
            entry6.callback.AddListener((data6) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualUEventTrigger.triggers.Add(entry6);

            //往右上
            EventTrigger.Entry entry7 = new EventTrigger.Entry();
            entry7.eventID = EventTriggerType.PointerEnter;
            entry7.callback.AddListener((data7) =>
            {
                self.SetVisual(4);
            });
            self.View.EvisualRUEventTrigger.triggers.Add(entry7);
            EventTrigger.Entry entry8 = new EventTrigger.Entry();
            entry8.eventID = EventTriggerType.PointerExit;
            entry8.callback.AddListener((data8) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualRUEventTrigger.triggers.Add(entry8);

            //往右
            EventTrigger.Entry entry9 = new EventTrigger.Entry();
            entry9.eventID = EventTriggerType.PointerEnter;
            entry9.callback.AddListener((data9) =>
            {
                self.SetVisual(5);
            });
            self.View.EvisualREventTrigger.triggers.Add(entry9);
            EventTrigger.Entry entry10 = new EventTrigger.Entry();
            entry10.eventID = EventTriggerType.PointerExit;
            entry10.callback.AddListener((data10) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualREventTrigger.triggers.Add(entry10);

            //往右下
            EventTrigger.Entry entry11 = new EventTrigger.Entry();
            entry11.eventID = EventTriggerType.PointerEnter;
            entry11.callback.AddListener((data11) =>
            {
                self.SetVisual(6);
            });
            self.View.EvisualRDEventTrigger.triggers.Add(entry11);
            EventTrigger.Entry entry12 = new EventTrigger.Entry();
            entry12.eventID = EventTriggerType.PointerExit;
            entry12.callback.AddListener((data12) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualRDEventTrigger.triggers.Add(entry12);

            //往下
            EventTrigger.Entry entry13 = new EventTrigger.Entry();
            entry13.eventID = EventTriggerType.PointerEnter;
            entry13.callback.AddListener((data13) =>
            {
                self.SetVisual(7);
            });
            self.View.EvisualDEventTrigger.triggers.Add(entry13);
            EventTrigger.Entry entry14 = new EventTrigger.Entry();
            entry14.eventID = EventTriggerType.PointerExit;
            entry14.callback.AddListener((data14) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualDEventTrigger.triggers.Add(entry14);

            //往左下
            EventTrigger.Entry entry15 = new EventTrigger.Entry();
            entry15.eventID = EventTriggerType.PointerEnter;
            entry15.callback.AddListener((data15) =>
            {
                self.SetVisual(8);
            });
            self.View.EvisualLDEventTrigger.triggers.Add(entry15);
            EventTrigger.Entry entry16 = new EventTrigger.Entry();
            entry16.eventID = EventTriggerType.PointerExit;
            entry16.callback.AddListener((data16) =>
            {
                self.SetVisual(0);
            });
            self.View.EvisualLDEventTrigger.triggers.Add(entry16);
        }
        public static int GetVisual(this DlgGameUI self)
        {
            return self.VisualControl;
        }
        public static void ShowWindow(this DlgGameUI self, Entity contextData = null)
        {
            //self.View.ELabel_Text.SetText("准备");
            self.InitUI();
            self.View.EButton_readyImage.transform.gameObject.SetActive(true);
            self.View.EButton_readyImage.sprite = IconHelper.LoadIconSprite("GameElement", "GameReady");
            //self.HideSkillAndMonster();
            self.View.EResultWinBackgroundImage.transform.gameObject.SetActive(false);
            self.View.EResultLoseBackgroundImage.transform.gameObject.SetActive(false);
            CampHelper.InitCamp(self.ZoneScene(), self.View.ELeftPlayerHpBarImage, self.View.ERightPlayerHpBarImage,
                self.View.ELeftPlayerMoneyTextText,self.View.ERightPlayerMoneyTextText,
                self.View.ELeftPlayerNameTextText,self.View.ERightPlayerNameTextText);//初始化
        }
        public static void HideSkillAndMonster(this DlgGameUI self)
        {
            self.View.ESCreateMonster1.HideWindow();
            self.View.ESCreateMonster2.HideWindow();
            self.View.ESCreateMonster3.HideWindow();
            self.View.ESCreateMonster4.HideWindow();

            self.View.ES_Skill1.HideWindow();
            self.View.ES_Skill2.HideWindow();
            self.View.ES_Skill3.HideWindow();
            self.View.ES_Skill4.HideWindow();
        }
        public static void ShowStartButton(this DlgGameUI self)
        {
            self.View.EButton_readyButton.transform.gameObject.SetActive(true);
        }
        public static void OnScrollItemRefreshHandler(this DlgGameUI self, Transform transform, int index)
        {
            if (self.ItemId.Count == 0 || self.ItemNumber.Count == 0) return;
            Scroll_Item_Reward item = self.Items[index].BindTrans(transform);
            int ItemId = self.ItemId[index];
            string ItemName = ItemConfigCategory.Instance.Get(ItemId).ItemName;
            Sprite ItemSprite = IconHelper.LoadIconSprite("Items", ItemName);
            item.ERewardIconImage.sprite = ItemSprite;
            item.ERewardNumberText.SetText(self.ItemNumber[index].ToString());
        }
        public static void HideWindow(this DlgGameUI self)
        {
            self.RemoveUIScrollItems(ref self.Items);
        }
        public static void ShowResultUI(this DlgGameUI self, bool Result, List<int> ItemId, List<int> ItemNumber)
        {
            if (Result)//胜利
            {
                self.View.EResultWinBackgroundImage.transform.gameObject.SetActive(true);
                self.View.EResultLoseBackgroundImage.transform.gameObject.SetActive(false);
                int count = ItemId.Count;
                self.ItemId = ItemId;
                self.ItemNumber = ItemNumber;
                self.View.ELoopScrollListRewardLoopHorizontalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrollItemRefreshHandler(transform, index); });
                self.AddUIScrollItems(ref self.Items, count);
                self.View.ELoopScrollListRewardLoopHorizontalScrollRect.SetVisible(true, count);
            }
            else//失败
            {
                self.View.EResultWinBackgroundImage.transform.gameObject.SetActive(false);
                self.View.EResultLoseBackgroundImage.transform.gameObject.SetActive(true);
            }
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 2)//双人对战
            {
                self.HideRestartAndBack();
            }
        }
        public static void DisReadyAndShowWindow(this DlgGameUI self)
        {
            self.View.EButton_readyImage.transform.gameObject.SetActive(false);

            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent num = unit.GetComponent<NumericComponent>();
            self.View.ESCreateMonster1.ShowWindow(num.GetAsInt(NumericType.Monster1));
            self.View.ESCreateMonster2.ShowWindow(num.GetAsInt(NumericType.Monster2));
            self.View.ESCreateMonster3.ShowWindow(num.GetAsInt(NumericType.Monster3));
            self.View.ESCreateMonster4.ShowWindow(num.GetAsInt(NumericType.Monster4));
        }
        public static async void GameMoneyRefresh(this DlgGameUI self)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent num = unit.GetComponent<NumericComponent>();
            int position = num.GetAsInt(NumericType.Position);
            if(position == 1)
            {
                self.View.ELeftPlayerMoneyTextText.SetText(num.GetAsInt(NumericType.GameMoney).ToString());
            }
            if(position == 2)
            {
                self.View.ERightPlayerMoneyTextText.SetText(num.GetAsInt(NumericType.GameMoney).ToString());
            }
            await ETTask.CompletedTask;
        }
        public static async void onclick(this DlgGameUI self)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            int IsReadyGame = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.IsReadyGame);
            if (IsReadyGame == 0) self.GetReady();
            else self.CancelReady();
            await ETTask.CompletedTask;
        }
        public static async void GetReady(this DlgGameUI self)
        {
            try
            {
                int errorcode = await GameHelper.GetReadyGame(self.ZoneScene());
                if (errorcode != ErrorCode.ERR_Success)
                {
                    Log.Error(errorcode.ToString());
                    return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }
            //self.View.ELabel_Text.SetText("取消");
            self.View.EButton_readyImage.sprite = IconHelper.LoadIconSprite("GameElement", "GameCancel");
        }
        public static async void CancelReady(this DlgGameUI self)
        {
            try
            {
                int errorcode = await GameHelper.CancelReadyGame(self.ZoneScene());
                if (errorcode != ErrorCode.ERR_Success)
                {
                    Log.Error(errorcode.ToString());
                    return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }
            //self.View.ELabel_Text.SetText("准备");
            self.View.EButton_readyImage.sprite = IconHelper.LoadIconSprite("GameElement", "GameReady");
        }
        public static async void ExitGame(this DlgGameUI self)
        {
            try
            {
                int errorcode = await GameHelper.ExitGameAndEnterMainHome(self.ZoneScene());
                if (errorcode != ErrorCode.ERR_Success)
                {
                    Log.Error(errorcode.ToString());
                    return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }
        }
        public static async void RequestWin(this DlgGameUI self, int winposition,int basehp)
        {
            try
            {
                int errorcode = await GameHelper.RequestWin(self.ZoneScene(), winposition,basehp);
                if (errorcode != ErrorCode.ERR_Success)
                {
                    Log.Error(errorcode.ToString());
                    return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }
            await ETTask.CompletedTask;
        }
        public static async void SetBaseHp(this DlgGameUI self, Base baseitem)
        {
            int zone = baseitem.Zone;
            float hp = (float)baseitem.Hp;
            float maxhp = (float)baseitem.MaxHp;
            if (zone == 1)//左边受伤
            {
                self.View.ELeftPlayerHpBarImage.fillAmount = (float)(hp / maxhp);
                //self.View.EBaseHp1Image.transform.GetComponent<RectTransform>().localScale = new Vector2((float)(hp / maxhp) * 5.0f / 10.0f, 0.5f);
            }
            if (zone == 2)//右边受伤
            {
                self.View.ERightPlayerHpBarImage.fillAmount = (float)(hp / maxhp);
                //self.View.EBaseHp2Image.transform.GetComponent<RectTransform>().localScale = new Vector2((float)(hp / maxhp) * 5.0f / 10.0f, 0.5f);
            }
            await ETTask.CompletedTask;
        }
        public static async void UpdateGameWaveInfo(this DlgGameUI self, int CurrentWaveNumber, Dictionary<int, Dictionary<int, int>> MonsterIdNumberDict)//当前波次  当前波次所有怪
        {
            self.View.ERoundInfoWaveNumberTextText.SetText("Round  " + CurrentWaveNumber.ToString());
            foreach (int roadid in MonsterIdNumberDict.Keys)
            {
                foreach(int configid in MonsterIdNumberDict[roadid].Keys)
                {
                    if (roadid == 1)
                    {
                        self.View.E_NextWave1Image.gameObject.SetActive(true);
                    }
                    if (roadid == 2)
                    {
                        self.View.E_NextWave2Image.gameObject.SetActive(true);
                    }
                    Log.Debug(configid.ToString());
                    Log.Debug(MonsterIdNumberDict[roadid][configid].ToString());    
                }
            }
            await ETTask.CompletedTask;
        }
        public static async void SettingTower(this DlgGameUI self, Tower tower, long TowerId, int opttype, float TowerX, float TowerY)
        {
            for (int i = 0; i < self.CurrentTowers.Count; i++)
            {
                ESButton_CreateTower es = self.CurrentTowers[i];
                float px = es.EButton_CreateTowerButton.transform.position.x;
                float py = es.EButton_CreateTowerButton.transform.position.y;
                float distance = UnityEngine.Vector3.Distance(new UnityEngine.Vector2(px, py), new UnityEngine.Vector2((float)(TowerX / 10000.0f), (float)(TowerY / 10000.0f)));
                if (distance < 0.02f)
                {
                    es.SettingTower(tower, TowerId, opttype).Coroutine();
                }
            }
            await ETTask.CompletedTask;
        }
        public static void UpdateSetGameTimeLeft(this DlgGameUI self,int Time)
        {
            if(Time == 0)
            {
                self.View.ETimeLeftTextText.SetText("------");
                self.HideAllNextWave();
                return;
            }
            self.View.ETimeLeftTextText.SetText("TimeLeft " + (Time / 1000).ToString());
        }
        public static void RestartGame(this DlgGameUI self)
        {
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().RestartSingleGame();
        }
        public static void NextGame(this DlgGameUI self)
        {
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().NextSingleGame();
        }
    }
}
