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
    [FriendClass(typeof(Monster))]
    [FriendClass(typeof(Tower))]
    [FriendClass(typeof(Troop))]
    public static class DlgGameUISystem
    {
        //初始化塔的位置和一些其他按钮位置（买怪入口位置，波次信息UI位置）
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
                        e.RegisterEventAndShowLabelAndRegisterPosition(1,i+1);
                    }
                    else//多人地图
                    {
                        if (i < PosX.Length / 2)
                        {
                            e.RegisterEventAndShowLabelAndRegisterPosition(1,i+1);
                        }
                        else
                        {
                            e.RegisterEventAndShowLabelAndRegisterPosition(2,i+1);
                        }
                    }
                }
                else
                {
                    ESButton_CreateTower e = self.AllTowers[i];
                    e.uiTransform.gameObject.GetComponent<RectTransform>().position = new Vector3(20000, 20000);
                }
            }
            //初始化波次信息UI
            for(int i=0;i<mapconfig.WaveInfoX.Length;i++)
            {
                self.View.E_AllNextWaveImage.transform.GetChild(i).transform.position = new Vector3((float)(mapconfig.WaveInfoX[i]/100.0f), (float)(mapconfig.WaveInfoY[i]/100.0f), 0);
            }
            //初始化买怪入口UI
            for(int i=0;i<mapconfig.ReleaseX.Length;i++)
            {
                int roadindex = i;
                self.View.E_AllReleaseMonsterImage.transform.GetChild(i).position = new Vector3((float)(mapconfig.ReleaseX[i]/100.0f), (float)(mapconfig.ReleaseY[i]/100.0f), 0);
                self.View.E_AllReleaseMonsterImage.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(() => { self.ReleaseMonster(roadindex + 1); });
            }
        }
        //买怪
        public static void ReleaseMonster(this DlgGameUI self,int RoadIndex)
        {
            GameHelper.CreateMonster(self.ZoneScene(), self.CurrentSelectMonster, RoadIndex).Coroutine();
            self.HideAllReleaseMonster();
        }
        //单机买怪后，刷新当前选择的怪物ID和显示买怪入口
        public static void SetSelectMonster(this DlgGameUI self,int MonsterConfigId)
        {
            int roadnumber = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().RoadNumber;
            if (self.CurrentSelectMonster == MonsterConfigId)//相同为再次点击 /则关闭
            {
                for (int i = 0; i < roadnumber; i++)
                {
                    self.View.E_AllReleaseMonsterImage.transform.GetChild(i).transform.gameObject.SetActive(false);
                }
                self.CurrentSelectMonster = 0;
                return;
            }
            self.CurrentSelectMonster = MonsterConfigId;
            int playerposition = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position);
            int[] releasezone = MapConfigCategory.Instance.Get(LevelConfigCategory.Instance.Get(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().LevelId).MapId).ReleaseZone;
            for (int i = 0; i < roadnumber; i++)
            {
                if (releasezone[i] == playerposition) self.View.E_AllReleaseMonsterImage.transform.GetChild(i).transform.gameObject.SetActive(true);
                else self.View.E_AllReleaseMonsterImage.transform.GetChild(i).transform.gameObject.SetActive(false);
            }

        }
        //展示对塔释放的玩家技能,根据技能来显示所有塔的按钮
        public static void ShowPlayerSkillTowerButtonByPosition(this DlgGameUI self,int position)
        {
            for(int i=0;i<self.AllTowers.Count;i++)
            {
                ESButton_CreateTower createtowerbutton = self.AllTowers[i];
                if(createtowerbutton.Position == position && createtowerbutton.tower != null)
                {
                    createtowerbutton.ShowPlayerSkillButton();
                }
            }
        }
        public static void HideAllPlayerSkillTowerButton(this DlgGameUI self)
        {
            for (int i = 0; i < self.AllTowers.Count; i++)
            {
                ESButton_CreateTower createtowerbutton = self.AllTowers[i];
                createtowerbutton.HidePlayerSkillButton();
            }
        }
        //用于显示层获取当前选择的玩家技能Id
        public static int GetCurrentPlayerSkillId(this DlgGameUI self)
        {
            return self.CurrentSelectPlayerSkill;
        }
        //释放玩家技能
        public static void ReleasePlayerSkill(this DlgGameUI self,int posx,int posy,List<long> UnitIds)
        {
            int zone = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position);
            GameHelper.ReleasePlayerSkill(self.ZoneScene(), self.CurrentSelectPlayerSkill, zone, posx, posy, UnitIds).Coroutine();
            self.HideAllPlayerSkillUI();
        }
        //根据skillid的type来显示对应的UI层
        public static void SetSelectPlayerSkill(this DlgGameUI self,int PlayerSkillId)
        {
            if(self.CurrentSelectPlayerSkill == PlayerSkillId)
            {
                //关闭所有技能显示层的东西
                self.HideAllPlayerSkillUI();
                return;
            }
            self.CurrentSelectPlayerSkill = PlayerSkillId;
            int ReleaseType = PlayerSkillConfigCategory.Instance.Get(PlayerSkillId).ReleaseType;
            int zone = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position);
            //根据整个来显示UI层
            switch (ReleaseType)
            {
                case 1://直接释放
                    GameHelper.ReleasePlayerSkill(self.ZoneScene(), self.CurrentSelectPlayerSkill, zone, 0, 0, new List<long>() { 0}).Coroutine();
                    self.HideAllPlayerSkillUI();
                    break;
                case 2://选择位置释放
                    self.View.E_RangeSkillImage.gameObject.SetActive(true);
                    break;
                case 3://选择范围和位置
                    self.View.E_RangeSkillImage.gameObject.SetActive(true);
                    break;
                case 4://选择我方塔       
                    if(zone == 1)
                    {
                        self.ShowPlayerSkillTowerButtonByPosition(1);
                    }
                    if(zone == 2)
                    {
                        self.ShowPlayerSkillTowerButtonByPosition(2);
                    }
                    break;
                case 5://选择敌方塔
                    if (zone == 1)
                    {
                        self.ShowPlayerSkillTowerButtonByPosition(2);
                    }
                    if (zone == 2)
                    {
                        self.ShowPlayerSkillTowerButtonByPosition(1);
                    }
                    break;
            }
        }
        //关闭所有玩家技能对显示层的影响
        public static void HideAllPlayerSkillUI(this DlgGameUI self)
        {
            self.CurrentSelectPlayerSkill = 0;
            self.View.E_RangeSkillImage.gameObject.SetActive(false);
            self.HideAllPlayerSkillTowerButton();//关闭所有玩家技能对点击塔
        }
        //关闭所有买怪的按钮
        public static void HideAllReleaseMonster(this DlgGameUI self)
        {
            for(int i=0;i<self.View.E_AllReleaseMonsterImage.transform.childCount;i++)
            {
                self.View.E_AllReleaseMonsterImage.transform.GetChild(i).gameObject.SetActive(false);
            }
            self.CurrentSelectMonster = 0;
        }
        /*public static void PauseSingleGameMode(this DlgGameUI self)
        {
            GameHelper.PauseSingleGameMode(self.ZoneScene()).Coroutine();
        }
        public static void ContinueSingleGameMode(this DlgGameUI self)
        {
            GameHelper.ContinueSingleGameMode(self.ZoneScene()).Coroutine();
        }*/
        //隐藏双人模式打完后的继续或者重新打的按钮
        public static void HideRestartAndBack(this DlgGameUI self)
        {
            self.View.EButton_WinRestartGameImage.gameObject.SetActive(false);
            self.View.EButton_WinNextGameImage.gameObject.SetActive(false);
            self.View.EButton_LoseRestartGameImage.gameObject.SetActive(false);
        }
        //单人模式隐藏一些按钮
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
        public static void SetBuildTowerPosUI(this DlgGameUI self, Vector3 camerapos)
        {
            self.View.EListImage.transform.localScale = new Vector3(self.VisualScale, self.VisualScale, 1);
            self.View.EListImage.transform.localPosition = new Vector3(-camerapos.x * 108.0f * self.VisualScale, -camerapos.y * 108.0f * self.VisualScale, 0);
        }
        public static void SetWaveInfoPosUI(this DlgGameUI self, Vector3 camerapos)
        {
            self.View.E_AllNextWaveImage.transform.localScale = new Vector3(self.VisualScale, self.VisualScale, 1);
            self.View.E_AllNextWaveImage.transform.localPosition = new Vector3(-camerapos.x * 108.0f * self.VisualScale, -camerapos.y * 108.0f * self.VisualScale, 0);
        }
        public static void SetReleaseMonsterPosUI(this DlgGameUI self, Vector3 camerapos)
        {
            self.View.E_AllReleaseMonsterImage.transform.localScale = new Vector3(self.VisualScale, self.VisualScale, 1);
            self.View.E_AllReleaseMonsterImage.transform.localPosition = new Vector3(-camerapos.x * 108.0f * self.VisualScale, -camerapos.y * 108.0f * self.VisualScale, 0);
        }
        //关闭除了自己的塔的列表
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
        //关闭所有塔的列表
        public static void CloseAllTowerList(this DlgGameUI self)
        {
            for (int i = 0; i < self.CurrentTowers.Count; i++)
            {
                self.CurrentTowers[i].CloseListInfo().Coroutine();
            }
        }
        //键盘输入触发事件（例如用数字1 2 3 4 买怪放技能等）
        public static void InputToAction(this DlgGameUI self,int InputIndex)
        {
            if (InputIndex == 1)
            {
                self.View.ESCreateMonster1.SelectMonster();
            }
            if (InputIndex == 2)
            {
                self.View.ESCreateMonster2.SelectMonster();
            }
            if (InputIndex == 3)
            {
                self.View.ESCreateMonster3.SelectMonster();
            }
            if (InputIndex == 4)
            {
                self.View.ESCreateMonster4.SelectMonster();
            }
        }
        //绑定事件
        public static void RegisterUIEvent(this DlgGameUI self)
        {
            self.View.EButton_readyButton.AddListener(() => { self.OnPreapare(); });
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent num = unit.GetComponent<NumericComponent>();

            self.View.ESCreateMonster1.RegisterEvent(num.GetAsInt(NumericType.Monster1));
            self.View.ESCreateMonster2.RegisterEvent(num.GetAsInt(NumericType.Monster2));
            self.View.ESCreateMonster3.RegisterEvent(num.GetAsInt(NumericType.Monster3));
            self.View.ESCreateMonster4.RegisterEvent(num.GetAsInt(NumericType.Monster4));

            self.View.ES_Skill1.RegisterEvent(num.GetAsInt(NumericType.PlayerSkillId1));
            self.View.ES_Skill2.RegisterEvent(num.GetAsInt(NumericType.PlayerSkillId2));
            self.View.ES_Skill3.RegisterEvent(num.GetAsInt(NumericType.PlayerSkillId3));
            self.View.ES_Skill4.RegisterEvent(num.GetAsInt(NumericType.PlayerSkillId4));
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

            self.View.ESNextWave1.Register(1);
            self.View.ESNextWave2.Register(2);
            self.View.ESNextWave3.Register(3);
            self.View.ESNextWave4.Register(4);
            self.View.ESNextWave5.Register(5);
            self.View.ESNextWave6.Register(6);
        }
        //投降
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
        //显示设置界面
        public static void ShowSettingUI(this DlgGameUI self)
        {
            self.View.E_SettingBaseSpriteImage.gameObject.SetActive(true);            
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                GameHelper.PauseSingleGameMode(self.ZoneScene()).Coroutine();
            }
        }
        //显示投降界面
        public static void ShowGiveUpUI(this DlgGameUI self)
        {
            self.View.E_GiveUpBaseSpriteImage.gameObject.SetActive(true);
        }
        //关闭设置界面
        public static void CloseSettingUI(this DlgGameUI self)
        {
            self.View.E_SettingBaseSpriteImage.gameObject.SetActive(false);
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                GameHelper.ContinueSingleGameMode(self.ZoneScene()).Coroutine();
            }
        }
        //下一波
        public static void NextWave(this DlgGameUI self)
        {
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                self.HideAllNextWave();
                GameHelper.NextWaveSingleGameMode(self.ZoneScene()).Coroutine();
            }
        }
        //关闭所有下一波
        public static void HideAllNextWave(this DlgGameUI self)
        {
            self.View.ESNextWave1.HideWindow();
            self.View.ESNextWave2.HideWindow();
            self.View.ESNextWave3.HideWindow();
            self.View.ESNextWave4.HideWindow();
            self.View.ESNextWave5.HideWindow();
            self.View.ESNextWave6.HideWindow();
        }
        //关闭投降界面
        public static void CloseGiveUpUI(this DlgGameUI self)
        {
            self.View.E_GiveUpBaseSpriteImage.gameObject.SetActive(false);
        }
        //设定视角
        public static void SetVisual(this DlgGameUI self, int Visual)
        {
            self.VisualControl = Visual;
        }
        //设定视角尺寸参数
        public static float SetVisualScale(this DlgGameUI self, float Scale)
        {
            self.VisualScale = self.VisualScale + Scale;
            if (self.VisualScale >= 2) self.VisualScale = 2;
            if (self.VisualScale <= 1f) self.VisualScale = 1f;
            return self.VisualScale;
        }
        //初始化视角尺寸参数和绑定视角移动事件
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
        //获取视角控制
        public static int GetVisual(this DlgGameUI self)
        {
            return self.VisualControl;
        }
        //显示初始化
        public static void ShowWindow(this DlgGameUI self, Entity contextData = null)
        {
            self.InitUI();
            if (self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode != 1)
            {
                self.View.EButton_readyImage.transform.gameObject.SetActive(true);
            }
            self.View.EButton_readyImage.sprite = IconHelper.LoadIconSprite("GameElement", "GameReady");
            //self.HideSkillAndMonster();
            self.View.EResultWinBackgroundImage.transform.gameObject.SetActive(false);
            self.View.EResultLoseBackgroundImage.transform.gameObject.SetActive(false);
            CampHelper.InitCamp(self.ZoneScene(), self.View.ELeftPlayerHpBarImage, self.View.ERightPlayerHpBarImage,
                self.View.ELeftPlayerMoneyTextText,self.View.ERightPlayerMoneyTextText,
                self.View.ELeftPlayerNameTextText,self.View.ERightPlayerNameTextText);//初始化基地
            self.HideAllReleaseMonster();//隐藏所有释放怪物入口
            self.HideAllNextWave();//隐藏所有波次信息
            //获取当前关卡初始金币
            int InitGold = LevelConfigCategory.Instance.Get(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().LevelId).InitGold;
            self.GameMoneyRefresh(InitGold);

            //单人直接开始游戏
            if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MatchMode == 1)
            {
                self.GetReady();
            }
        }
        //单人模式隐藏技能和买怪按钮
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
        //显示准备按钮
        public static void ShowStartButton(this DlgGameUI self)
        {
            self.View.EButton_readyButton.transform.gameObject.SetActive(true);
        }
        //刷新奖励物品
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
        //关闭dlggameui整个界面
        public static void HideWindow(this DlgGameUI self)
        {
            self.RemoveUIScrollItems(ref self.Items);
        }
        //显示游戏结果
        public static void ShowResultUI(this DlgGameUI self, bool Result, List<int> ItemId, List<int> ItemNumber,int Star)
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
            self.HideAllNextWave();
        }
        //刷新星星
        public static void RefreshStar(this DlgGameUI self,int Star)
        {
            if (Star >= 1) 
            {
                self.View.E_Star1Image.sprite = IconHelper.LoadIconSprite("GameElement", "StarBright");
            }
            if (Star >= 2)
            {
                self.View.E_Star2Image.sprite = IconHelper.LoadIconSprite("GameElement", "StarBright");
            }
            if (Star >= 3)
            {
                self.View.E_Star3Image.sprite = IconHelper.LoadIconSprite("GameElement", "StarBright");
            }
        }
        public static void ShowUnitInfo(this DlgGameUI self,int type)
        {
            self.View.E_UnitInfoImage.gameObject.SetActive(true);
            if(type == 1)//显示塔
            {
                self.View.E_Unit_TowerPartImage.gameObject.SetActive(true);
                self.View.E_Unit_MonsterPartImage.gameObject.SetActive(false);
                self.View.E_Unit_HeroPartImage.gameObject.SetActive(false);
            }
            if (type == 2)//显示怪
            {
                self.View.E_Unit_TowerPartImage.gameObject.SetActive(false);
                self.View.E_Unit_MonsterPartImage.gameObject.SetActive(true);
                self.View.E_Unit_HeroPartImage.gameObject.SetActive(false);
            }
            if (type == 3)//显示军队
            {
                self.View.E_Unit_TowerPartImage.gameObject.SetActive(false);
                self.View.E_Unit_MonsterPartImage.gameObject.SetActive(false);
                self.View.E_Unit_HeroPartImage.gameObject.SetActive(true);
            }
        }
        public static void RefreshTowerInfo(this DlgGameUI self,long TowerId,bool DirectRefresh)
        {
            if (DirectRefresh)//直接刷新
            {
                self.UnitInfoId = TowerId;
            }
            else//如果显示的是这个UnitId的信息 若怪被打了 则判断是否等于 若不等于就不刷新 等于就刷新
            {
                if (self.UnitInfoId != TowerId) return;
            }
            self.ShowUnitInfo(1);
            Tower tower = self.ZoneScene().CurrentScene().GetComponent<TowerComponent>().GetChild<Tower>(TowerId);
            //头像切换
            //end
            self.View.E_Unit_TowerNameText.SetText(tower.Config.Name);
            if (tower.PhysicsAttack != 0)
            {
                self.View.E_Unit_TowerAttackIconImage.sprite = IconHelper.LoadIconSprite("GameChooseUnitInfo", "PhysicsAttackIcon");
                self.View.E_Unit_TowerAttackValueText.SetText(tower.PhysicsAttack.ToString());
            }
            if (tower.MagicAttack != 0)
            {
                self.View.E_Unit_TowerAttackIconImage.sprite = IconHelper.LoadIconSprite("GameChooseUnitInfo", "MagicAttackIcon");
                self.View.E_Unit_TowerAttackValueText.SetText(tower.MagicAttack.ToString());
            }
            string AttackInterval;
            if (tower.AttackInterval <= 1000) AttackInterval = "快";
            else if (tower.AttackInterval > 1000 && tower.AttackInterval <= 2000) AttackInterval = "中";
            else if (tower.AttackInterval > 2000) AttackInterval = "慢";
            else AttackInterval = "无";
            self.View.E_Unit_TowerIntervalValueText.SetText(AttackInterval);
            string IsRangeAttack;
            if (tower.Config.IsRangeAttack == 0) IsRangeAttack = "单体";
            else if (tower.Config.IsRangeAttack == 1) IsRangeAttack = "群体";
            else IsRangeAttack = "无";
            self.View.E_Unit_TowerRangeValueText.SetText(IsRangeAttack);
        }
        public static void RefreshMonsterInfo(this DlgGameUI self,long monsterId,bool DirectRefresh)
        {
            if(DirectRefresh)//直接刷新
            {
                self.UnitInfoId = monsterId;
            }
            else//如果显示的是这个UnitId的信息 若怪被打了 则判断是否等于 若不等于就不刷新 等于就刷新
            {
                if (self.UnitInfoId != monsterId) return;//不等于则不刷新
            }//若等于则刷新
            self.ShowUnitInfo(2);
            Monster monster = self.ZoneScene().CurrentScene().GetComponent<MonsterComponent>().GetChild<Monster>(monsterId);
            //头像切换
            //end
            FightItemConfig fightitemconfig = FightItemConfigCategory.Instance.Get(monster.Config.MonsterConfigId);
            self.View.E_Unit_MonsterNameText.SetText(fightitemconfig.FightItemName);
            int Hp = monster.Hp;
            int MaxHp = monster.MaxHp;
            if (Hp == 0)
            {
                self.HideUnitInfo();
                return;
            }
            self.View.E_Unit_MonsterHpTextText.SetText(Hp + "/" + MaxHp);
            self.View.E_Unit_MonsterHpImage.fillAmount = (float)Hp / (float)MaxHp;
            self.View.E_Unit_MonsterAttackValueText.SetText(monster.Attack.ToString());
            self.View.E_Unit_MonsterPhysicsDefenceValueText.SetText(monster.PhysicsDefense.ToString());
            self.View.E_Unit_MonsterMagicDefenceValueText.SetText(monster.MagicDefense.ToString());
            self.View.E_Unit_MonsterSpeedValueText.SetText(fightitemconfig.speed);
            self.View.E_Unit_MonsterBaseDamageValueText.SetText(monster.Attack.ToString());
        }
        public static void RefreshTroopInfo(this DlgGameUI self,long troopId)
        {

        }

        public static void HideUnitInfo(this DlgGameUI self)
        {
            self.View.E_UnitInfoImage.gameObject.SetActive(false);
        }
        //关闭准备按钮
        public static void HidePrepare(this DlgGameUI self)
        {
            self.View.EButton_readyImage.transform.gameObject.SetActive(false);
        }
        //局内金币刷新事件
        public static async void GameMoneyRefresh(this DlgGameUI self,int money = 0)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent num = unit.GetComponent<NumericComponent>();
            int position = num.GetAsInt(NumericType.Position);
            if(money == 0)
            {
                if (position == 1)
                {
                    self.View.ELeftPlayerMoneyTextText.SetText(num.GetAsInt(NumericType.GameMoney).ToString());
                }
                if (position == 2)
                {
                    self.View.ERightPlayerMoneyTextText.SetText(num.GetAsInt(NumericType.GameMoney).ToString());
                }
            }
            else
            {
                if (position == 1)
                {
                    self.View.ELeftPlayerMoneyTextText.SetText(money.ToString());
                }
                if (position == 2)
                {
                    self.View.ERightPlayerMoneyTextText.SetText(money.ToString());
                }
            }
            for(int i=0;i<self.AllTowers.Count;i++)
            {
                ESButton_CreateTower createtower = self.AllTowers[i];
                if(createtower.Position == position)
                {
                    createtower.RefreshButtonByMoney();
                }
            }
            await ETTask.CompletedTask;
        }
        //准备按钮（单击准备）
        public static async void OnPreapare(this DlgGameUI self)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            int IsReadyGame = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.IsReadyGame);
            if (IsReadyGame == 0) self.GetReady();
            else self.CancelReady();
            await ETTask.CompletedTask;
        }
        //准备
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
        //取消准备
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
        //退出房间进入大厅
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
        //请求获胜
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
        //初始化基地血量
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
        //更新游戏波次信息UI
        public static async void UpdateGameWaveInfo(this DlgGameUI self, int CurrentWaveNumber, Dictionary<int, Dictionary<int, int>> MonsterIdNumberDict)//当前波次  当前波次所有怪
        {
            self.View.ERoundInfoWaveNumberTextText.SetText("Round  " + CurrentWaveNumber.ToString());
            self.HideAllNextWave();
            foreach (int roadid in MonsterIdNumberDict.Keys)
            {
                if (roadid == 1) 
                {
                    self.View.ESNextWave1.ShowWindow();
                    self.View.ESNextWave1.UpdateWaveInfo(MonsterIdNumberDict[roadid]);
                }
                if (roadid == 2)
                {
                    self.View.ESNextWave2.ShowWindow();
                    self.View.ESNextWave2.UpdateWaveInfo(MonsterIdNumberDict[roadid]);
                }
                if (roadid == 3) 
                {
                    self.View.ESNextWave3.ShowWindow();
                    self.View.ESNextWave3.UpdateWaveInfo(MonsterIdNumberDict[roadid]);
                }
                if (roadid == 4)
                {
                    self.View.ESNextWave4.ShowWindow();
                    self.View.ESNextWave4.UpdateWaveInfo(MonsterIdNumberDict[roadid]);
                }
                if (roadid == 5)
                {
                    self.View.ESNextWave5.ShowWindow();
                    self.View.ESNextWave5.UpdateWaveInfo(MonsterIdNumberDict[roadid]);
                }
                if (roadid == 6)
                {
                    self.View.ESNextWave6.ShowWindow();
                    self.View.ESNextWave6.UpdateWaveInfo(MonsterIdNumberDict[roadid]);
                }

            }
            await ETTask.CompletedTask;
        }
        //注册买的塔的位置到特定的按钮上
        public static async void SettingTower(this DlgGameUI self, Tower tower, long TowerId, int opttype, int optId,bool invalid)
        {
            for (int i = 0; i < self.CurrentTowers.Count; i++)
            {
                ESButton_CreateTower es = self.CurrentTowers[i];
                if(es.optId == optId) es.SettingTower(tower, TowerId, opttype,invalid).Coroutine();
            }
            await ETTask.CompletedTask;
        }
        //刷新波次事件
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
        //重新开始
        public static void RestartGame(this DlgGameUI self)
        {
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().RestartSingleGame();
        }
        //下一关
        public static void NextGame(this DlgGameUI self)
        {
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().NextSingleGame();
        }
    }
}
