using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(TowerFactoryComponent))]
    public static class TowerFactoryComponentSystem
    {
        public static async void OnLogic(this TowerFactoryComponent self, int dt)
        {
            List<int> deleteIndex = new List<int>();
            foreach (int index in self.TowerFactorys.Keys)
            {
                TowerFactory factory = self.TowerFactorys[index];
                bool IsDelete = await factory.OnLogic(dt);
                if (IsDelete)
                {
                    deleteIndex.Add(index);
                }
            }

            if (deleteIndex.Count > 0)
            {
                for (int i = 0; i < deleteIndex.Count; i++)
                {
                    int index = deleteIndex[i];
                    if (self.TowerFactorys.ContainsKey(index))
                    {
                        TowerFactory factory = self.TowerFactorys[index];
                        long factoryId = factory.Id;
                        self.GetChild<TowerFactory>(factoryId).Dispose();
                        self.TowerFactorys.Remove(index);
                    }
                }
            }
        }
        public static void AddTowerFactory(this TowerFactoryComponent self, TowerFactory factory)
        {
            self.Index++;
            self.TowerFactorys.Add(self.Index, factory);
        }
    }
}
