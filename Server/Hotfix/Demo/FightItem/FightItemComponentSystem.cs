﻿using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public class FightItemComponentAwakeSystem : AwakeSystem<FightItemComponent>
    {
        public override void Awake(FightItemComponent self)
        {

        }
    }
    public class FightItemComponentDestroySystem : DestroySystem<FightItemComponent>
    {
        public override void Destroy(FightItemComponent self)
        {
            foreach (var item in self.FightItemDict.Values)
            {
                item?.Dispose();
            }
            self.FightItemDict.Clear();
        }
    }
    public class FightItemComponentDeserializeSystem : DeserializeSystem<FightItemComponent>
    {
        public override void Deserialize(FightItemComponent self)
        {
            foreach (Entity entity in self.Children.Values)
            {
                self.AddContainer(entity as FightItem);
            }
        }
    }
    [FriendClass(typeof(FightItemComponent))]
    [FriendClass(typeof(FightItem))]
    public static class FightItemComponentSystem
    {
        public static bool AddContainer(this FightItemComponent self, FightItem fightitem)//若能添加 则添加到战斗单元组件
        {
            if (self.FightItemDict.ContainsKey(fightitem.Id))
            {
                return false;
            }
            self.FightItemDict.Add(fightitem.Id, fightitem);
            return true;
        }
        public static bool IsCanAddFightItemByConfigId(this FightItemComponent self, int ConfigId)//判断是否存在这个战斗单元Id
        {
            if (!FightItemConfigCategory.Instance.Contain(ConfigId))
            {
                return false;
            }
            return true;
        }
        public static bool AddFightItemByConfigId(this FightItemComponent self, int ConfigId,bool IsNotAsync = false)//添加战斗单元流程
        {
            if (!FightItemConfigCategory.Instance.Contain(ConfigId))
            {
                return false;
            }
            foreach (FightItem item in self.FightItemDict.Values)
            {
                if (item.ConfigId == ConfigId)//有物品
                {
                    return false;
                }
            }
            FightItem newFightItem = FightItemFactory.Create(self, ConfigId);
            if (!self.AddFightItem(newFightItem,IsNotAsync))
            {
                newFightItem?.Dispose();
                return false;
            }
            return true;
        }
        public static bool AddFightItem(this FightItemComponent self, FightItem fightitem,bool IsNotAsync)//添加战斗单元
        {
            if (fightitem == null || fightitem.IsDisposed)
            {
                return false;
            }
            if (!self.AddContainer(fightitem))
            {
                return false;
            }
            if (fightitem.Parent != self)
            {
                self.AddChild(fightitem);
            }
            if(IsNotAsync)
            {
                FightItemUpdateNoticeHelper.AsyncAddFightItem(self.GetParent<Unit>(), fightitem, self.message);
            }
            return true;
        }
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool IsCanAddFightItemTalentByConfigId(this FightItemComponent self,int TalentConfigId)//判断是否存在这个天赋点
        {
            if(!TalentConfigCategory.Instance.Contain(TalentConfigId))
            {
                return false;
            }
            return true;
        }
        public static bool AddFightItemTalent(this FightItemComponent self,long Id,int TalentConfigId)//添加战斗单元天赋点流程
        {
            if (!self.FightItemDict.ContainsKey(Id))
            {
                return false;
            }
            FightItem fightitem = self.FightItemDict[Id];
            string fightitemtalentCode = fightitem.Config.TalentCode;
            List<int> talents = TalentConfigCategory.Instance.GetTalentIdByCode(fightitemtalentCode);
            if (!talents.Contains(TalentConfigId))
            {
                return false;
            }
            if(fightitem.AddedTalent.Contains(TalentConfigId))
            {
                return false;
            }
            if(fightitem.Upgrading > 0)
            {
                fightitem.AddedTalent.Add(TalentConfigId);
                fightitem.Upgrading--;
                FightItemUpdateNoticeHelper.AsyncAddFightItemTalent(self.GetParent<Unit>(), fightitem, self.message);
            }
            return true;
        }
        //---------------------------------------------------------------------------------
        public static bool UpgradeFightItem(this FightItemComponent self,Unit unit,long Id)//升级塔
        {
            FightItem fightitem = self.FightItemDict[Id];
            int level = fightitem.AddedTalent.Count;

            if ((level + fightitem.Upgrading) >= 0 && (level + fightitem.Upgrading) < 3)//可升级
            {
                self.FightItemDict[Id].Upgrading++;
            }
            //扣钱
            int NeedMoney = TalentCostConfigCategory.Instance.GetCostByCodeAndLevel(fightitem.Config.TalentCode, fightitem.AddedTalent.Count + self.FightItemDict[Id].Upgrading);
            int HaveMoney = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Gold);
            if(HaveMoney >= NeedMoney)
            {
                unit.GetComponent<NumericComponent>().Set(NumericType.Gold, HaveMoney - NeedMoney);
            }
            FightItemUpdateNoticeHelper.AsyncUpgradeFightItem(self.GetParent<Unit>(), self.FightItemDict[Id], self.message);
            return true;
        }
        public static bool ResetFightItemTalent(this FightItemComponent self,Unit unit,long Id)
        {
            if(!self.FightItemDict.ContainsKey(Id))
            {
                return false;
            }
            FightItem fightitem = self.FightItemDict[Id];
            int level = fightitem.AddedTalent.Count + fightitem.Upgrading;//原来的等级
            fightitem.AddedTalent.Clear();
            fightitem.Upgrading = level;
            FightItemUpdateNoticeHelper.AsyncResetFightItemTalent(self.GetParent<Unit>(), self.FightItemDict[Id], self.message);
            return true;
        }
    }
}
