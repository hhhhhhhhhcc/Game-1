using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(FightItemComponent))]
    [FriendClass(typeof(FightItem))]
    public static class FightItemHelper
    {
        public static void Clear(Scene scene)
        {
            scene?.GetComponent<FightItemComponent>().Clear();  
        }
        public static void AddFightItem(Scene zonescene, FightItem fightitem)
        {
            zonescene?.GetComponent<FightItemComponent>()?.AddFightItem(fightitem);       
        }
        public static void AddFightItemTalent(Scene zonescene,FightItem fightitem)
        {
            zonescene?.GetComponent<FightItemComponent>()?.AddFightItemTalent(fightitem);          
        }
        public static List<FightItem> GetFightItemsByType(Scene zonescene,FightItemType type)
        {
            List<FightItem> fightItems = new List<FightItem>();
            foreach(FightItem item in zonescene.GetComponent<FightItemComponent>().FightItemDict.Values)
            {
                if(item.Config.FightItemType == (int)type)
                {
                    fightItems.Add(item);
                }
            }
            return fightItems;
        }
        public static FightItem GetFightItemByConfigId(Scene zonescene,int configid)
        {
            configid = (configid - ((configid - 1) % 3 + 1)) + 1;
            foreach(FightItem item in zonescene.GetComponent<FightItemComponent>().FightItemDict.Values)
            {
                if(item.ConfigId == configid)
                {
                    return item;
                }
            }
            return null;
        }
        public static void UpgradeFightItem(Scene zonescene, long id)
        {
            zonescene?.GetComponent<FightItemComponent>()?.UpgradeFightItem(id);
        }
        public static void ResetFightItemTalent(Scene zonescene,long id)
        {
            zonescene?.GetComponent<FightItemComponent>()?.ResetFightItemTalent(id);
        }
    }
}
