using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(BagComponent))]
    [FriendClass(typeof(Item))]
    public static class BagComponentSystem
    {
        public static void Clear(this BagComponent self)
        {
            ForeachHelper.Foreach(self.ItemDict, (long id, Item item) =>
            {
                item?.Dispose();
            });
            self.ItemDict.Clear();
        }
        public static void AddItem(this BagComponent self,Item item)
        {
            bool IsHaveIt = false;
            foreach(Item currentitem in self.ItemDict.Values)
            {
                if(currentitem.Id == item.Id)//存在物品
                {
                    IsHaveIt = true;
                }
            }
            if (IsHaveIt == true) 
            {
                self.ItemDict[item.Id] = item;
                return;
            }
            self.AddChild(item);
            self.ItemDict.Add(item.Id, item);
        }
        public static void ReduceItem(this BagComponent self,Item item)//消耗物品
        {
            self.ItemDict.TryGetValue(item.Id,out Item Item);
            if(Item != null)
            {
                self.ItemDict[item.Id] = item;
                if(item.ItemNumber <= 0)
                {
                    self.RemoveItem(item);
                }
                return;
            }
        }
        public static void RemoveItem(this BagComponent self,Item item)
        {
            if(self.ItemDict.ContainsKey(item.Id))
            {
                self.ItemDict.Remove(item.Id);
            }
        }

    }
}
