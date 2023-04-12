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
            if (self.tower != null)
            {
                if (self.InfoIsTrigger)
                {
                    self.InfoTimer = self.InfoTimer + Time.deltaTime;
                }
                else
                {
                    self.InfoTimer = 0;
                }
                if (self.InfoTimer >= 1)
                {
                    if (self.TowerLevel == 0) return;
                    if (self.E_TowerRangeImage.gameObject.activeSelf == false)
                    {
                        self.E_TowerRangeImage.gameObject.SetActive(true);
                        self.E_TowerRangeImage.transform.localScale = new Vector3(self.tower.AttackRange, self.tower.AttackRange, 1);
                    }
                    if (self.ETowerInfoImage.gameObject.activeSelf == false)
                    {
                        self.ETowerInfoImage.gameObject.SetActive(true);
                    }
                    TowerConfig towerconfig = TowerConfigCategory.Instance.Get(self.TowerConfigId);

                    if (self.TowerLevel < 3)
                    {
                        self.ELabel_TowerNameText.SetText(towerconfig.Name);
                        self.ELabel_TowerAttackValueText.SetText("攻击伤害:" + towerconfig.Attack.ToString());
                        self.ELabel_TowerAttackIntervalText.SetText("攻击间隔:" + ((float)towerconfig.AttackInterval / 10000.0f).ToString());
                        TowerConfig nextconfig = TowerConfigCategory.Instance.Get(self.TowerConfigId + 1);
                        self.ELabel_TowerNextMoneyText.SetText("下一级造价:" + nextconfig.Price.ToString());
                    }
                    else
                    {
                        self.ELabel_TowerNameText.SetText(towerconfig.Name);
                        self.ELabel_TowerAttackValueText.SetText("攻击伤害:" + towerconfig.Attack.ToString());
                        self.ELabel_TowerAttackIntervalText.SetText("攻击间隔:" + ((float)towerconfig.AttackInterval / 10000.0f).ToString());
                        self.ELabel_TowerNextMoneyText.SetText("最高级");
                    }
                }
            }
            //造塔前的范围
            if (self.tower == null)
            {
                if (self.RangeTrigger)
                {
                    self.RangeTimer = self.RangeTimer + Time.deltaTime;
                }
                else
                {
                    self.RangeTimer = 0;
                }
                if (self.RangeTimer > 1)
                {
                    self.E_TowerRangeImage.transform.gameObject.SetActive(true);
                    int attackrangeadd = SkillHelper.GetBeforeBuildRange(self.ZoneScene(), self.beforebuildconfigId);
                    TowerConfig towerconfig = TowerConfigCategory.Instance.Get(self.beforebuildconfigId);
                    self.E_TowerRangeImage.transform.localScale = new Vector3(towerconfig.Range / 1000.0f * (float)(100 + attackrangeadd) / 100.0f, towerconfig.Range / 1000.0f * (float)(100 + attackrangeadd) / 100.0f, 1);
                }
                else
                {
                    self.E_TowerRangeImage.transform.gameObject.SetActive(false);
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
    public static class ESButton_CreateTowerSystem
    {
        public static void RegisterEventAndShowLabelAndRegisterPosition(this ESButton_CreateTower self, int Position)
        {
            self.EButton_CreateTowerButton.AddListener(() => { self.ShowCreateButtonList().Coroutine(); });
            self.EclosebtButton.AddListener(() => { self.CloseCreateButtonList().Coroutine(); });
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent numeric = unit.GetComponent<NumericComponent>();
            self.Position = Position;
            int TowerId1 = numeric.GetAsInt(NumericType.TowerId1);
            int TowerId2 = numeric.GetAsInt(NumericType.TowerId2);
            int TowerId3 = numeric.GetAsInt(NumericType.TowerId3);
            int TowerId4 = numeric.GetAsInt(NumericType.TowerId4);
            float X = self.EButton_CreateTowerButton.transform.position.x;
            float Y = self.EButton_CreateTowerButton.transform.position.y;
            //根据TowerId判断能不能造塔的显示或者隐藏
            if (TowerId1 == 0) 
            {
                self.Ecreatebt1Image.gameObject.SetActive(false);
            }
            if (TowerId2 == 0)
            {
                self.Ecreatebt2Image.gameObject.SetActive(false);
            }
            if (TowerId3 == 0)
            {
                self.Ecreatebt3Image.gameObject.SetActive(false);
            }
            if (TowerId4 == 0)
            {
                self.Ecreatebt4Image.gameObject.SetActive(false);
            }
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
            //显示造塔的Id
            self.Ecreatemoneytext1Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId1).ToString());//钱
            self.Espritetower1Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(TowerId1).PrefabName);//图片
            self.Ecreatemoneytext2Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId2).ToString());
            self.Espritetower2Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(TowerId2).PrefabName);
            self.Ecreatemoneytext3Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId3).ToString());
            self.Espritetower3Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(TowerId3).PrefabName);
            self.Ecreatemoneytext4Text.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), TowerId4).ToString());
            self.Espritetower4Image.sprite = IconHelper.LoadIconSprite("Tower", TowerConfigCategory.Instance.Get(TowerId4).PrefabName);
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
            self.ECloseUpButton.AddListener(() => { self.CloseUpTowerList().Coroutine(); });
            self.EUpButton.AddListener(() => { self.UpTower(X, Y).Coroutine(); });
            //self.EclosetextText.SetText("关闭");
            self.ShowTowerInfo = self.EButton_CreateTowerEventTrigger;
            self.RegisterTowerInfos(TowerId1, TowerId2, TowerId3, TowerId4);
        }
        public static void RegisterPosition(this ESButton_CreateTower self, int position)
        {
            self.Position = position;
        }
        public static void RegisterTowerInfos(this ESButton_CreateTower self, int towerid1, int towerid2, int towerid3, int towerid4)
        {
            //造塔后的信息和范围
            EventTrigger.Entry entry1 = new EventTrigger.Entry();
            entry1.eventID = EventTriggerType.PointerEnter;
            entry1.callback.AddListener((data1) =>
            {
                self.ShowInfos();
            });
            self.ShowTowerInfo.triggers.Add(entry1);

            EventTrigger.Entry entry2 = new EventTrigger.Entry();
            entry2.eventID = EventTriggerType.PointerExit;
            entry2.callback.AddListener((data2) =>
            {
                self.CloseInfos();
            });
            self.ShowTowerInfo.triggers.Add(entry2);
            //造塔前的范围 -- 1
            EventTrigger.Entry entry3 = new EventTrigger.Entry();
            entry3.eventID = EventTriggerType.PointerEnter;
            entry3.callback.AddListener((data3) =>
            {
                self.ShowTowerRange(towerid1);
            });
            self.Espritetower1EventTrigger.triggers.Add(entry3);

            EventTrigger.Entry entry4 = new EventTrigger.Entry();
            entry4.eventID = EventTriggerType.PointerExit;
            entry4.callback.AddListener((data4) =>
            {
                self.HideTowerRange();
            });
            self.Espritetower1EventTrigger.triggers.Add(entry4);
            //-- 2
            EventTrigger.Entry entry5 = new EventTrigger.Entry();
            entry5.eventID = EventTriggerType.PointerEnter;
            entry5.callback.AddListener((data5) =>
            {
                self.ShowTowerRange(towerid2);
            });
            self.Espritetower2EventTrigger.triggers.Add(entry5);

            EventTrigger.Entry entry6 = new EventTrigger.Entry();
            entry6.eventID = EventTriggerType.PointerExit;
            entry6.callback.AddListener((data6) =>
            {
                self.HideTowerRange();
            });
            self.Espritetower2EventTrigger.triggers.Add(entry6);
            //-- 3
            EventTrigger.Entry entry7 = new EventTrigger.Entry();
            entry7.eventID = EventTriggerType.PointerEnter;
            entry7.callback.AddListener((data7) =>
            {
                self.ShowTowerRange(towerid3);
            });
            self.Espritetower3EventTrigger.triggers.Add(entry7);

            EventTrigger.Entry entry8 = new EventTrigger.Entry();
            entry8.eventID = EventTriggerType.PointerExit;
            entry8.callback.AddListener((data8) =>
            {
                self.HideTowerRange();
            });
            self.Espritetower3EventTrigger.triggers.Add(entry8);
            //-- 4
            EventTrigger.Entry entry9 = new EventTrigger.Entry();
            entry9.eventID = EventTriggerType.PointerEnter;
            entry9.callback.AddListener((data9) =>
            {
                self.ShowTowerRange(towerid4);
            });
            self.Espritetower4EventTrigger.triggers.Add(entry9);

            EventTrigger.Entry entry10 = new EventTrigger.Entry();
            entry10.eventID = EventTriggerType.PointerExit;
            entry10.callback.AddListener((data10) =>
            {
                self.HideTowerRange();
            });
            self.Espritetower4EventTrigger.triggers.Add(entry10);
        }
        public static void ShowTowerRange(this ESButton_CreateTower self, int configId)
        {
            self.RangeTrigger = true;
            self.beforebuildconfigId = configId;
        }
        public static void HideTowerRange(this ESButton_CreateTower self)
        {
            self.RangeTrigger = false;
        }
        public static void ShowInfos(this ESButton_CreateTower self)
        {
            self.InfoIsTrigger = true;

        }
        public static void CloseInfos(this ESButton_CreateTower self)
        {
            if (self.ETowerInfoImage.gameObject.activeSelf == true)
            {
                self.ETowerInfoImage.gameObject.SetActive(false);
            }
            if (self.E_TowerRangeImage.gameObject.activeSelf == true)
            {
                self.E_TowerRangeImage.gameObject.SetActive(false);
            }
            self.InfoIsTrigger = false;
        }
        public static async ETTask ShowCreateButtonList(this ESButton_CreateTower self)
        {
            int Position = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position);
            if (self.ZoneScene().CurrentScene().GetComponent<GameComponent>().GameEnding == false) return;
            if (Position != self.Position) return;
            self.EListImage.transform.gameObject.SetActive(false);
            self.EUpListImage.transform.gameObject.SetActive(false);
            self.InfoIsTrigger = false;
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
                self.ELabel_UpText.SetText(SkillHelper.GetBuildLossMoney(self.ZoneScene(), self.TowerConfigId + 1).ToString());

                self.EUpButton.gameObject.SetActive(true);
            }
            else if (self.TowerLevel == 3)
            {
                //只显示售出
                self.EUpListImage.gameObject.SetActive(true);
                self.EUpButton.gameObject.SetActive(false);
            }
            if (self.TowerLevel == 3) return;
            await ETTask.CompletedTask;
        }
        public static async ETTask CloseListInfo(this ESButton_CreateTower self)
        {
            self.EUpListImage.gameObject.SetActive(false);
            self.EListImage.gameObject.SetActive(false);
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
            try
            {
                int errorcode = await GameHelper.DeleteTower(self.ZoneScene(), self.TowerId, self.TowerConfigId, self.EButton_CreateTowerButton.transform.position.x * 10000, self.EButton_CreateTowerButton.transform.position.y * 10000);
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
            self.RangeTrigger = false;
            self.EUpListImage.gameObject.SetActive(false);
            await ETTask.CompletedTask;
        }
        public static async ETTask CreateTower(this ESButton_CreateTower self, float PX, float PY, int TowerConfigId)
        {
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
                int errorcode = await GameHelper.CreateTower(self.ZoneScene(), TowerConfigId, PX * 10000, PY * 10000);
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
            self.EListImage.gameObject.SetActive(false);
            self.RangeTrigger = false;
        }
        public static async ETTask UpTower(this ESButton_CreateTower self, float PX, float PY)
        {
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
                int errorcode = await GameHelper.UpTower(self.ZoneScene(), NewTowerConfigId, self.TowerId, PX * 10000, PY * 10000);
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
            self.EUpListImage.transform.gameObject.SetActive(false);
            self.RangeTrigger = false;
            await ETTask.CompletedTask;
        }
        public static async ETTask SettingTower(this ESButton_CreateTower self, Tower tower, long TowerId, int opttype)
        {
            if (opttype == (int)OptType.CreateTower)
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
                self.EDeleteMoneyText.SetText(returnmoney.ToString());
                self.EButton_CreateTowerBaseImage.color = new Vector4(1, 1, 1, 0);
            }
            if (opttype == (int)OptType.UpTower)
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
                self.EDeleteMoneyText.SetText(returnmoney.ToString());
                self.EButton_CreateTowerBaseImage.color = new Vector4(1, 1, 1, 0);
            }
            if (opttype == (int)OptType.DeleteTower)
            {
                self.tower = null;
                self.TowerConfigId = 0;
                self.TowerId = 0;
                self.TowerLevel = 0;
                self.EButton_CreateTowerBaseImage.color = new Vector4(1, 1, 1, 1);
            }

            await ETTask.CompletedTask;
        }
        public static async ETTask CloseMapOtherList(this ESButton_CreateTower self)
        {
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().CloseOtherList(self);
            await ETTask.CompletedTask;
        }
    }
}
