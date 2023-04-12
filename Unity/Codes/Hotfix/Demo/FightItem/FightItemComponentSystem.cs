using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(FightItemComponent))]
    [FriendClass(typeof(FightItem))]
    public static class FightItemComponentSystem
    {
        public static void Clear(this FightItemComponent self)
        {
            ForeachHelper.Foreach(self.FightItemDict, (long id, FightItem fightitem) =>
            {
                self.GetChild<FightItem>(id).Dispose();
                fightitem?.Dispose();
            });
            
            self.FightItemDict.Clear();
        }
        public static void AddFightItem(this FightItemComponent self, FightItem fightitem)//添加战斗单元
        {
            if(self.FightItemDict.ContainsKey(fightitem.Id))//存在id直接返回否则添加
            {
                return;
            }
            self.AddChild(fightitem);
            self.FightItemDict.Add(fightitem.Id, fightitem);
        }
        public static void AddFightItemTalent(this FightItemComponent self,FightItem fightitem)//点天赋
        {
            if(!self.FightItemDict.ContainsKey(fightitem.Id))
            {
                return;//不存在id
            }
            self.FightItemDict[fightitem.Id] = fightitem;
        }
        public static List<int> GetTowerTalentIdByConfigId(this FightItemComponent self,int configid)//(3001 3002 3003) (3001,3004)
        {
            List<int> skillids = new List<int>();
            foreach(FightItem item in self.FightItemDict.Values)
            {
                if(configid - item.ConfigId <= 2 && configid - item.ConfigId >= 0)
                {
                    skillids = item.AddedTalent;
                }
            }
            return skillids;
        }
        public static void UpgradeFightItem(this FightItemComponent self,long id)
        {
            if(!self.FightItemDict.ContainsKey(id))
            {
                return;//不存在id
            }
            if ((self.FightItemDict[id].AddedTalent.Count + self.FightItemDict[id].Upgrading) >= 0 && (self.FightItemDict[id].AddedTalent.Count + self.FightItemDict[id].Upgrading) < 3)//可升级
            {
                self.FightItemDict[id].Upgrading++;
            }
        }
        public static void ResetFightItemTalent(this FightItemComponent self, long id)
        {
            if (!self.FightItemDict.ContainsKey(id))
            {
                return;//不存在id
            }
            int level = self.FightItemDict[id].AddedTalent.Count + self.FightItemDict[id].Upgrading;
            self.FightItemDict[id].AddedTalent.Clear();
            self.FightItemDict[id].Upgrading = level;
        }
        public static List<int> GetPetTalentIdByConfigId(this FightItemComponent self, int configid)//(3001 3002 3003) (3001,3004)
        {
            List<int> skillids = new List<int>();
            foreach (FightItem item in self.FightItemDict.Values)
            {
                if (configid == item.ConfigId)
                {
                    skillids = item.AddedTalent;
                }
            }
            return skillids;
        }
    }
}
