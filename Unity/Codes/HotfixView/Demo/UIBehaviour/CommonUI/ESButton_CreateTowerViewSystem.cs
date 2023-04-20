using DG.Tweening;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace ET
{
    [ObjectSystem]
    public class ESButton_CreateTowerAwakeSystem : AwakeSystem<ESButton_CreateTower, Transform>
    {
        public override void Awake(ESButton_CreateTower self, Transform transform)
        {
            self.uiTransform = transform;
        }
    }
    [FriendClass(typeof(Tower))]
    public class ESButton_CreateTowerUpdateSystem : UpdateSystem<ESButton_CreateTower>
    {
        public override void Update(ESButton_CreateTower self)
        {
            //造塔之后塔信息和范围
            if (self.tower != null)//造塔这里是查看升级  查看属性是另外的敌方
            {
                if (self.UpInfoTrigger)
                {
                    self.UpInfoTimer = self.UpInfoTimer + Time.deltaTime;

                    if (self.UpInfoTimer >= 0.1f)
                    {
                        self.ETowerInfoImage.gameObject.SetActive(true);
                        self.ETowerInfoAttackBaseImage.gameObject.SetActive(true);
                        self.ETowerInfoAttackIntervalBaseImage.gameObject.SetActive(true);
                        self.ETowerInfoAttackTypeBaseImage.gameObject.SetActive(true);
                        self.EUpArrowImage.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerConfirm");//图片
                        int attackrangeadd = SkillHelper.GetBeforeBuildRange(self.ZoneScene(), self.TowerConfigId + 1);
                        TowerConfig towerconfig = TowerConfigCategory.Instance.Get(self.TowerConfigId + 1);
                        self.E_TowerRangeImage.transform.localScale = new Vector3(towerconfig.Range / 1000.0f * (float)(100 + attackrangeadd) / 100.0f, towerconfig.Range / 1000.0f * (float)(100 + attackrangeadd) / 100.0f, 1);
                        self.ETowerInfoNameTextText.SetText(towerconfig.Name);
                        self.ETowerInfoDescriptionText.SetText(towerconfig.Introduction);
                        if (towerconfig.Attack[0] != 0)
                        {
                            self.ETowerInfoAttackValueText.SetText(towerconfig.Attack[0].ToString());
                        }
                        if (towerconfig.Attack[1] != 0)
                        {
                            self.ETowerInfoAttackValueText.SetText(towerconfig.Attack[1].ToString());
                        }
                        string AttackInterval;
                        if (towerconfig.AttackInterval <= 1000) AttackInterval = "快";
                        else if (towerconfig.AttackInterval > 1000 && towerconfig.AttackInterval <= 2000) AttackInterval = "中";
                        else if (towerconfig.AttackInterval > 2000) AttackInterval = "慢";
                        else AttackInterval = "无";
                        self.ETowerInfoAttackIntervalValueText.SetText(AttackInterval);
                    }
                }
                else if (self.SaleTirgger)
                {
                    self.SaleTimer = self.SaleTimer + Time.deltaTime;
                    if (self.SaleTimer >= 0.1f)
                    {
                        self.ETowerInfoImage.gameObject.SetActive(true);
                        self.ETowerInfoAttackBaseImage.gameObject.SetActive(false);
                        self.ETowerInfoAttackIntervalBaseImage.gameObject.SetActive(false);
                        self.ETowerInfoAttackTypeBaseImage.gameObject.SetActive(false);
                        self.EDeleteSaleImage.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerConfirm");//图片
                        int returnmoney = 0;
                        for (int i = (int)(self.TowerConfigId - (self.TowerConfigId - 1) % 3); i <= self.TowerConfigId; i++)
                        {
                            returnmoney = returnmoney + SkillHelper.GetBuildLossMoney(self.ZoneScene(), i) * (100 - SkillHelper.GetSaleLoss(self.ZoneScene(), i)) / 100;
                        }
                        self.ETowerInfoNameTextText.SetText("出售防御塔");
                        self.ETowerInfoDescriptionText.SetText("出售该防御塔可获得" + returnmoney.ToString() + "金币");
                    }
                }
                else
                {
                    self.ETowerInfoImage.gameObject.SetActive(false);
                    self.InitIcon();
                    self.UpInfoTimer = 0;
                    self.SaleTimer = 0;
                }
            }
            if (self.tower == null)//造塔前的范围和伤害等等
            {
                if (self.BeforeBuildTrigger)
                {
                    self.BeforeBuildTimer = self.BeforeBuildTimer + Time.deltaTime;
                    if (self.BeforeBuildTimer >= 0.1f)
                    {
                        self.E_TowerRangeImage.transform.gameObject.SetActive(true);
                        self.ETowerInfoImage.gameObject.SetActive(true);
                        self.ETowerInfoAttackBaseImage.gameObject.SetActive(true);
                        self.ETowerInfoAttackIntervalBaseImage.gameObject.SetActive(true);
                        self.ETowerInfoAttackTypeBaseImage.gameObject.SetActive(true);
                        if (self.BeforeTowerConfigId1 == self.beforebuildconfigId) self.Espritetower1Image.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerConfirm");//图片
                        if (self.BeforeTowerConfigId2 == self.beforebuildconfigId) self.Espritetower2Image.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerConfirm");//图片
                        if (self.BeforeTowerConfigId3 == self.beforebuildconfigId) self.Espritetower3Image.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerConfirm");//图片
                        if (self.BeforeTowerConfigId4 == self.beforebuildconfigId) self.Espritetower4Image.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerConfirm");//图片
                        int attackrangeadd = SkillHelper.GetBeforeBuildRange(self.ZoneScene(), self.beforebuildconfigId);
                        TowerConfig towerconfig = TowerConfigCategory.Instance.Get(self.beforebuildconfigId);
                        self.E_TowerRangeImage.transform.localScale = new Vector3(towerconfig.Range / 1000.0f * (float)(100 + attackrangeadd) / 100.0f, towerconfig.Range / 1000.0f * (float)(100 + attackrangeadd) / 100.0f, 1);
                        self.ETowerInfoNameTextText.SetText(towerconfig.Name);
                        self.ETowerInfoDescriptionText.SetText(towerconfig.Introduction);
                        if (towerconfig.Attack[0] != 0)
                        {
                            self.ETowerInfoAttackValueText.SetText(towerconfig.Attack[0].ToString());
                        }
                        if (towerconfig.Attack[1] != 0)
                        {
                            self.ETowerInfoAttackValueText.SetText(towerconfig.Attack[1].ToString());
                        }
                        string AttackInterval;
                        if (towerconfig.AttackInterval <= 1000) AttackInterval = "快";
                        else if (towerconfig.AttackInterval > 1000 && towerconfig.AttackInterval <= 2000) AttackInterval = "中";
                        else if (towerconfig.AttackInterval > 2000) AttackInterval = "慢";
                        else AttackInterval = "无";
                        self.ETowerInfoAttackIntervalValueText.SetText(AttackInterval);
                    }
                }
                else
                {
                    self.E_TowerRangeImage.transform.gameObject.SetActive(false);
                    self.ETowerInfoImage.gameObject.SetActive(false);
                    self.InitIcon();
                    self.BeforeBuildTimer = 0;
                }
            }
        }
    }
    [ObjectSystem]
    public class ESButton_CreateTowerDestroySystem : DestroySystem<ESButton_CreateTower>
    {
        public override void Destroy(ESButton_CreateTower self)
        {
            self.DestroyWidget();
        }
    }
    [FriendClass(typeof(ESButton_CreateTower))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(FightItem))]
    [FriendClass(typeof(Tower))]
    public static class ESButton_CreateTowerSystem
    {
        public static void RegisterEventAndShowLabelAndRegisterPosition(this ESButton_CreateTower self, int Position,int OptId)
        {
            self.optId = OptId;
            self.EButton_CreateTowerButton.AddListener(() => { self.ShowCreateButtonList(); });
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent numeric = unit.GetComponent<NumericComponent>();
            self.Position = Position;
            int TowerId1 = numeric.GetAsInt(NumericType.TowerId1);
            int TowerId2 = numeric.GetAsInt(NumericType.TowerId2);
            int TowerId3 = numeric.GetAsInt(NumericType.TowerId3);
            int TowerId4 = numeric.GetAsInt(NumericType.TowerId4);
            self.BeforeTowerConfigId1 = TowerId1;
            self.BeforeTowerConfigId2 = TowerId2;
            self.BeforeTowerConfigId3 = TowerId3;
            self.BeforeTowerConfigId4 = TowerId4;
            float X = self.EButton_CreateTowerButton.transform.position.x;
            float Y = self.EButton_CreateTowerButton.transform.position.y;
            int NoZeroTowerCount = 4;
            //根据TowerId判断能不能造塔的显示或者隐藏
            if (TowerId1 == 0)
            {
                self.Ecreatebt1Image.gameObject.SetActive(false);
                NoZeroTowerCount--;
            }
            else
            {
                self.Ecreatemoneytext1Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId1).ToString());//钱
            }
            if (TowerId2 == 0)
            {
                self.Ecreatebt2Image.gameObject.SetActive(false);
                NoZeroTowerCount--;
            }
            else
            {
                self.Ecreatemoneytext2Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId2).ToString());
            }
            if (TowerId3 == 0)
            {
                self.Ecreatebt3Image.gameObject.SetActive(false);
                NoZeroTowerCount--;
            }
            else
            {
                self.Ecreatemoneytext3Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId3).ToString());
            }
            if (TowerId4 == 0)
            {
                self.Ecreatebt4Image.gameObject.SetActive(false);
                NoZeroTowerCount--;
            }
            else
            {
                self.Ecreatemoneytext4Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId4).ToString());
            }
            if (NoZeroTowerCount == 1)
            {
                self.Ecreatebt1Image.transform.localPosition = new Vector2(0, 130);
            }
            if (NoZeroTowerCount == 2)
            {
                self.Ecreatebt1Image.transform.localPosition = new Vector2(0, 130);
                self.Ecreatebt2Image.transform.localPosition = new Vector2(0, -130);
            }
            if (NoZeroTowerCount == 3)
            {
                self.Ecreatebt1Image.transform.localPosition = new Vector2(-100, 100);
                self.Ecreatebt2Image.transform.localPosition = new Vector2(100, 100);
                self.Ecreatebt3Image.transform.localPosition = new Vector2(0, -130);
            }
            self.InitIcon();
            //绑定造塔按钮
            self.Espritetower1Button.AddListener(() =>
            {
                self.CreateTower(X, Y, TowerId1).Coroutine();
            });
            self.Espritetower2Button.AddListener(() =>
            {
                self.CreateTower(X, Y, TowerId2).Coroutine();
            });
            self.Espritetower3Button.AddListener(() =>
            {
                self.CreateTower(X, Y, TowerId3).Coroutine();
            });
            self.Espritetower4Button.AddListener(() =>
            {
                self.CreateTower(X, Y, TowerId4).Coroutine();
            });
            int pos = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Position);
            if (self.Position != pos)
            {
                self.EButton_CreateTowerButton.gameObject.SetActive(false);
                self.EButton_CreateTowerBaseImage.gameObject.SetActive(false);
            } 
            /*
            if (FightItemHelper.GetFightItemByConfigId(self.ZoneScene(),TowerId1).AddedTalent.Contains(4))
            {
                Dictionary<string,int> param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1005).Params);
                int reduce = param["buildreduce"];
                self.Ecreatemoneytext1Text.SetText((TowerConfigCategory.Instance.GetTowerNeedMoneyByTowerId(TowerId1) * (100-reduce) / 100).ToString());//钱
            }
            if (FightItemHelper.GetFightItemByConfigId(self.ZoneScene(), TowerId2).AddedTalent.Contains(4))
            {
                Dictionary<string, int> param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1005).Params);
                int reduce = param["buildreduce"];
                self.Ecreatemoneytext1Text.SetText((TowerConfigCategory.Instance.GetTowerNeedMoneyByTowerId(TowerId2) * (100 - reduce) / 100).ToString());//钱
            }
            if (FightItemHelper.GetFightItemByConfigId(self.ZoneScene(), TowerId3).AddedTalent.Contains(4))
            {
                Dictionary<string, int> param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1005).Params);
                int reduce = param["buildreduce"];
                self.Ecreatemoneytext1Text.SetText((TowerConfigCategory.Instance.GetTowerNeedMoneyByTowerId(TowerId3) * (100 - reduce) / 100).ToString());//钱
            }
            if (FightItemHelper.GetFightItemByConfigId(self.ZoneScene(), TowerId4).AddedTalent.Contains(4))
            {
                Dictionary<string, int> param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1005).Params);
                int reduce = param["buildreduce"];
                self.Ecreatemoneytext1Text.SetText((TowerConfigCategory.Instance.GetTowerNeedMoneyByTowerId(TowerId4) * (100 - reduce) / 100).ToString());//钱
            }*/
            self.EDeleteUpButton.AddListener(() => { self.DeleteTower().Coroutine(); });//售卖塔
            self.EUpButton.AddListener(() => { self.UpTower(X, Y).Coroutine(); });
            self.E_PlayerSkillButtonButton.AddListener(() => { self.ReleasePlayerSkillByChooseTower(); });
            //self.EclosetextText.SetText("关闭");
            self.ShowTowerInfo = self.EButton_CreateTowerEventTrigger;
            self.RegisterTowerInfos(TowerId1, TowerId2, TowerId3, TowerId4);
        }
        public static void RefreshButtonByMoney(this ESButton_CreateTower self)
        {
            int gamemoney = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.GameMoney);

            int NeedMoney;
            if(self.BeforeTowerConfigId1 != 0)
            {
                NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), self.BeforeTowerConfigId1);
                if (gamemoney >= NeedMoney)
                {
                    self.Espritetower1Button.interactable = true;
                    self.Ecreatebt1Image.color = new Vector4(1, 1, 1, 1);
                }
                else
                {
                    self.Espritetower1Button.interactable = false;
                    self.Ecreatebt1Image.color = new Vector4(0.3515625f, 0.3515625f, 0.3515625f, 1);
                }
            }
            if(self.BeforeTowerConfigId2 != 0)
            {
                NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), self.BeforeTowerConfigId2);
                if (gamemoney >= NeedMoney)
                {
                    self.Espritetower2Button.interactable = true;
                    self.Ecreatebt2Image.color = new Vector4(1, 1, 1, 1);
                }
                else
                {
                    self.Espritetower2Button.interactable = false;
                    self.Ecreatebt2Image.color = new Vector4(0.3515625f, 0.3515625f, 0.3515625f, 1);
                }
            }
            if(self.BeforeTowerConfigId3 != 0)
            {
                NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), self.BeforeTowerConfigId3);
                if (gamemoney >= NeedMoney)
                {
                    self.Espritetower3Button.interactable = true;
                    self.Ecreatebt3Image.color = new Vector4(1, 1, 1, 1);
                }
                else
                {
                    self.Espritetower3Button.interactable = false;
                    self.Ecreatebt3Image.color = new Vector4(0.3515625f, 0.3515625f, 0.3515625f, 1);
                }
            }
            if(self.BeforeTowerConfigId4 != 0)
            {
                NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), self.BeforeTowerConfigId4);
                if (gamemoney >= NeedMoney)
                {
                    self.Espritetower4Button.interactable = true;
                    self.Ecreatebt4Image.color = new Vector4(1, 1, 1, 1);
                }
                else
                {
                    self.Espritetower4Button.interactable = false;
                    self.Ecreatebt4Image.color = new Vector4(0.3515625f, 0.3515625f, 0.3515625f, 1);
                }
            }
            if(self.TowerConfigId != 0)
            {
                NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), self.TowerConfigId + 1);
                if(gamemoney >= NeedMoney)
                {
                    self.EUpButton.interactable = true;
                    self.EUpArrowImage.color = new Vector4(1, 1, 1, 1);
                }
                else
                {
                    self.EUpButton.interactable = false;
                    self.EUpArrowImage.color = new Vector4(0.3515625f, 0.3515625f, 0.3515625f, 1);
                }
            }
            else
            {
                self.EUpButton.interactable = true;
                self.EUpArrowImage.color = new Vector4(1, 1, 1, 1);
            }
            self.EDeleteUpButton.interactable = true;
        }
        public static void InitIcon(this ESButton_CreateTower self)
        {
            if (self.BeforeTowerConfigId1 != 0) self.Espritetower1Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(self.BeforeTowerConfigId1).PrefabName);//图片
            if (self.BeforeTowerConfigId2 != 0) self.Espritetower2Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(self.BeforeTowerConfigId2).PrefabName);//图片
            if (self.BeforeTowerConfigId3 != 0) self.Espritetower3Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(self.BeforeTowerConfigId3).PrefabName);//图片
            if (self.BeforeTowerConfigId4 != 0) self.Espritetower4Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(self.BeforeTowerConfigId4).PrefabName);//图片
            self.EUpArrowImage.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerUp");
            self.EDeleteSaleImage.sprite = IconHelper.LoadIconSprite("BuildTowerUI", "TowerSale");
        }
        public static void RegisterPosition(this ESButton_CreateTower self, int position)
        {
            self.Position = position;
        }
        public static void RegisterTowerInfos(this ESButton_CreateTower self, int towerid1, int towerid2, int towerid3, int towerid4)
        {
            //造塔后升级按钮的信息和范围
            EventTrigger.Entry entry1 = new EventTrigger.Entry();
            entry1.eventID = EventTriggerType.PointerEnter;
            entry1.callback.AddListener((data1) =>
            {
                self.ShowUpInfos();
            });
            self.EUpEventTrigger.triggers.Add(entry1);

            EventTrigger.Entry entry2 = new EventTrigger.Entry();
            entry2.eventID = EventTriggerType.PointerExit;
            entry2.callback.AddListener((data2) =>
            {
                self.CloseUpInfos();
            });
            self.EUpEventTrigger.triggers.Add(entry2);
            //造塔前的范围 -- 1
            EventTrigger.Entry entry3 = new EventTrigger.Entry();
            entry3.eventID = EventTriggerType.PointerEnter;
            entry3.callback.AddListener((data3) =>
            {
                self.ShowBeforeBuildTowerRange(towerid1);
            });
            self.Espritetower1EventTrigger.triggers.Add(entry3);

            EventTrigger.Entry entry4 = new EventTrigger.Entry();
            entry4.eventID = EventTriggerType.PointerExit;
            entry4.callback.AddListener((data4) =>
            {
                self.HideBeforeBuildTowerRange();
            });
            self.Espritetower1EventTrigger.triggers.Add(entry4);
            //-- 2
            EventTrigger.Entry entry5 = new EventTrigger.Entry();
            entry5.eventID = EventTriggerType.PointerEnter;
            entry5.callback.AddListener((data5) =>
            {
                self.ShowBeforeBuildTowerRange(towerid2);
            });
            self.Espritetower2EventTrigger.triggers.Add(entry5);

            EventTrigger.Entry entry6 = new EventTrigger.Entry();
            entry6.eventID = EventTriggerType.PointerExit;
            entry6.callback.AddListener((data6) =>
            {
                self.HideBeforeBuildTowerRange();
            });
            self.Espritetower2EventTrigger.triggers.Add(entry6);
            //-- 3
            EventTrigger.Entry entry7 = new EventTrigger.Entry();
            entry7.eventID = EventTriggerType.PointerEnter;
            entry7.callback.AddListener((data7) =>
            {
                self.ShowBeforeBuildTowerRange(towerid3);
            });
            self.Espritetower3EventTrigger.triggers.Add(entry7);

            EventTrigger.Entry entry8 = new EventTrigger.Entry();
            entry8.eventID = EventTriggerType.PointerExit;
            entry8.callback.AddListener((data8) =>
            {
                self.HideBeforeBuildTowerRange();
            });
            self.Espritetower3EventTrigger.triggers.Add(entry8);
            //-- 4
            EventTrigger.Entry entry9 = new EventTrigger.Entry();
            entry9.eventID = EventTriggerType.PointerEnter;
            entry9.callback.AddListener((data9) =>
            {
                self.ShowBeforeBuildTowerRange(towerid4);
            });
            self.Espritetower4EventTrigger.triggers.Add(entry9);

            EventTrigger.Entry entry10 = new EventTrigger.Entry();
            entry10.eventID = EventTriggerType.PointerExit;
            entry10.callback.AddListener((data10) =>
            {
                self.HideBeforeBuildTowerRange();
            });
            self.Espritetower4EventTrigger.triggers.Add(entry10);

            //出售按钮 显示卖掉的钱
            EventTrigger.Entry entry11 = new EventTrigger.Entry();
            entry11.eventID = EventTriggerType.PointerEnter;
            entry11.callback.AddListener((data11) =>
            {
                self.ShowSaleInfos();
            });
            self.EDeleteUpEventTrigger.triggers.Add(entry11);

            EventTrigger.Entry entry12 = new EventTrigger.Entry();
            entry12.eventID = EventTriggerType.PointerExit;
            entry12.callback.AddListener((data12) =>
            {
                self.HideSaleInfos();
            });
            self.EDeleteUpEventTrigger.triggers.Add(entry12);
        }
        public static void ShowBeforeBuildTowerRange(this ESButton_CreateTower self, int configId)
        {
            self.BeforeBuildTrigger = true;
            self.beforebuildconfigId = configId;
        }
        public static void HideBeforeBuildTowerRange(this ESButton_CreateTower self)
        {
            self.BeforeBuildTrigger = false;
            self.BeforeBuildTimer = 0;
        }
        public static void ShowUpInfos(this ESButton_CreateTower self)
        {
            self.UpInfoTrigger = true;
        }
        public static void CloseUpInfos(this ESButton_CreateTower self)
        {
            self.UpInfoTrigger = false;
            self.UpInfoTimer = 0;
        }
        public static void ShowSaleInfos(this ESButton_CreateTower self)
        {
            self.SaleTirgger = true;
        }
        public static void HideSaleInfos(this ESButton_CreateTower self)
        {
            self.SaleTirgger = false;
            self.SaleTimer = 0;
        }
        public static void ShowCreateButtonList(this ESButton_CreateTower self)
        {
            int Position = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position);
            if (self.ZoneScene().CurrentScene().GetComponent<GameComponent>().GameEnding == false) return;
            if (Position != self.Position) return;
            self.RefreshButtonByMoney();
            self.E_TowerRangeImage.gameObject.SetActive(true);
            self.EListImage.transform.gameObject.SetActive(false);
            self.EUpListImage.transform.gameObject.SetActive(false);
            self.UpInfoTrigger = false;
            self.SaleTirgger = false;
            self.BeforeBuildTrigger = false;
            self.UpInfoTimer = 0;
            self.SaleTimer = 0;
            self.BeforeBuildTimer = 0;
            self.CloseMapOtherList().Coroutine();
            if (self.ETowerInfoImage.gameObject.activeSelf == true)
            {
                self.ETowerInfoImage.gameObject.SetActive(false);
            }
            if (self.TowerLevel == 0)
            {
                self.EListImage.transform.gameObject.SetActive(true);
            }
            else if (self.TowerLevel == 1 || self.TowerLevel == 2)
            {
                //显示升级或者售出
                self.EUpListImage.gameObject.SetActive(true);
                self.EUPMoneyTextText.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), self.TowerConfigId + 1).ToString());

                self.EUpButton.gameObject.SetActive(true);
            }
            else if (self.TowerLevel == 3)
            {
                //只显示售出
                self.EUpListImage.gameObject.SetActive(true);
                self.EUpButton.gameObject.SetActive(false);
            }
            if (self.TowerLevel == 3) return;
        }
        public static async ETTask CloseListInfo(this ESButton_CreateTower self)
        {
            self.EUpListImage.gameObject.SetActive(false);
            self.EListImage.gameObject.SetActive(false);
            self.E_TowerRangeImage.gameObject.SetActive(false);
            await ETTask.CompletedTask;
        }
        public static async ETTask CloseUpTowerList(this ESButton_CreateTower self)
        {
            self.EUpListImage.gameObject.SetActive(false);
            await ETTask.CompletedTask;
        }
        public static async ETTask CloseCreateButtonList(this ESButton_CreateTower self)
        {
            self.EListImage.gameObject.SetActive(false);
            await ETTask.CompletedTask;
        }
        public static async ETTask DeleteTower(this ESButton_CreateTower self)
        {
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().HideUnitInfo();
            self.InitIcon();
            self.EUpListImage.gameObject.SetActive(false);
            try
            {
                int errorcode = await GameHelper.DeleteTower(self.ZoneScene(), self.TowerId,self.optId);
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
            self.E_TowerRangeImage.transform.gameObject.SetActive(false);
            self.BeforeBuildTrigger = false;
            self.UpInfoTrigger = false;
            self.SaleTirgger = false;
            self.UpInfoTimer = 0;
            self.SaleTimer = 0;
            self.BeforeBuildTimer = 0;
            await ETTask.CompletedTask;
        }
        public static async ETTask CreateTower(this ESButton_CreateTower self, float PX, float PY, int TowerConfigId)
        {
            self.EListImage.gameObject.SetActive(false);
            self.E_TowerRangeImage.gameObject.SetActive(false);
            self.ETowerInfoImage.gameObject.SetActive(false);
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().HideUnitInfo();
            //先判断钱 再发送消息
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent component = unit.GetComponent<NumericComponent>();
            int playerposition = component.GetAsInt(NumericType.Position);
            if (playerposition != self.Position) return;
            int CurrentMoney = component.GetAsInt(NumericType.GameMoney);//当前钱
            int NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerConfigId);
            if (CurrentMoney < NeedMoney) return;

            //视角尺寸计算
            Transform cameratransform = GlobalComponent.Instance.MainCamera;
            float Scale = self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetVisualScale(0);
            //其余操作都在返回后更改
            try
            {
                int errorcode = await GameHelper.CreateTower(self.ZoneScene(), TowerConfigId, PX * 10000, PY * 10000,self.optId);
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
            //在帧同步处绑定塔
            self.BeforeBuildTrigger = false;
            self.UpInfoTrigger = false;
            self.SaleTirgger = false;
            self.UpInfoTimer = 0;
            self.SaleTimer = 0;
            self.BeforeBuildTimer = 0;
            self.InitIcon();
        }
        public static async ETTask UpTower(this ESButton_CreateTower self, float PX, float PY)
        {
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().HideUnitInfo();
            self.EUpListImage.transform.gameObject.SetActive(false);
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent component = unit.GetComponent<NumericComponent>();
            int playerposition = component.GetAsInt(NumericType.Position);
            if (playerposition != self.Position) return;
            int CurrentMoney = component.GetAsInt(NumericType.GameMoney);//当前钱
            int NewTowerConfigId = self.TowerConfigId + 1;//新的塔ConfigId
            int NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), NewTowerConfigId);
            if (CurrentMoney < NeedMoney) return;
            try
            {
                int errorcode = await GameHelper.UpTower(self.ZoneScene(), self.TowerId,self.optId);
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
            //在帧同步处绑定塔
            self.E_TowerRangeImage.transform.gameObject.SetActive(false);
            self.BeforeBuildTrigger = false;
            self.UpInfoTrigger = false;
            self.SaleTirgger = false;
            self.UpInfoTimer = 0;
            self.SaleTimer = 0;
            self.BeforeBuildTimer = 0;
            self.InitIcon();
            await ETTask.CompletedTask;
        }
        public static async ETTask SettingTower(this ESButton_CreateTower self, Tower tower, long TowerId, int opttype,bool invalid)
        {
            if (opttype == (int)OptType.CreateTower)
            {
                if(invalid == false)//不能点击建造
                {
                    self.EButton_CreateTowerButton.gameObject.SetActive(false);
                }
                else
                {
                    self.tower = tower;
                    self.TowerConfigId = tower.Config.Id;
                    self.TowerId = TowerId;
                    self.TowerLevel = (tower.Config.Id - 1) % 3 + 1;
                    int returnmoney = 0;
                    for (int i = (int)(self.TowerConfigId - (self.TowerConfigId - 1) % 3); i <= self.TowerConfigId; i++)
                    {
                        returnmoney = returnmoney + SkillHelper.GetBuildLossMoney(self.ZoneScene(), i) * (100 - SkillHelper.GetSaleLoss(self.ZoneScene(), i)) / 100;
                    }
                    self.EDeleteMoneyTextText.SetText(returnmoney.ToString());
                    self.EButton_CreateTowerBaseImage.color = new Vector4(1, 1, 1, 0);
                    self.EButton_CreateTowerButton.gameObject.SetActive(true);
                }
            }
            if (opttype == (int)OptType.UpTower)
            {
                if(invalid == false)
                {
                    self.EButton_CreateTowerButton.gameObject.SetActive(false);
                }
                else
                {
                    self.TowerId = TowerId;
                    self.TowerConfigId = self.tower.Config.Id;
                    self.TowerLevel = (self.tower.Config.Id - 1) % 3 + 1;
                    int returnmoney = 0;
                    for (int i = (int)(self.TowerConfigId - (self.TowerConfigId - 1) % 3); i <= self.TowerConfigId; i++)
                    {
                        returnmoney = returnmoney + SkillHelper.GetBuildLossMoney(self.ZoneScene(), i) * (100 - SkillHelper.GetSaleLoss(self.ZoneScene(), i)) / 100;
                    }
                    self.EDeleteMoneyTextText.SetText(returnmoney.ToString());
                    self.EButton_CreateTowerBaseImage.color = new Vector4(1, 1, 1, 0);
                    self.EButton_CreateTowerButton.gameObject.SetActive(true);
                }
            }
            if (opttype == (int)OptType.DeleteTower)
            {
                if(invalid == false)
                {
                    self.EButton_CreateTowerButton.gameObject.SetActive(false);
                }
                else
                {
                    self.tower = null;
                    self.TowerConfigId = 0;
                    self.TowerId = 0;
                    self.TowerLevel = 0;
                    self.EButton_CreateTowerBaseImage.color = new Vector4(1, 1, 1, 1);
                    self.EButton_CreateTowerButton.gameObject.SetActive(true);
                }
            }
            await ETTask.CompletedTask;
        }
        public static async ETTask CloseMapOtherList(this ESButton_CreateTower self)
        {
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().CloseOtherList(self);
            await ETTask.CompletedTask;
        }
        public static void ShowPlayerSkillButton(this ESButton_CreateTower self)//dlggameui调用
        {
            self.E_PlayerSkillButtonButton.gameObject.SetActive(true);
        }
        public static void HidePlayerSkillButton(this ESButton_CreateTower self)//dlggameui调用
        {
            self.E_PlayerSkillButtonButton.gameObject.SetActive(false);
        }
        public static void ReleasePlayerSkillByChooseTower(this ESButton_CreateTower self)
        {
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().ReleasePlayerSkill(0, 0, new List<long>() { self.tower.Id });
        }
    }
}
