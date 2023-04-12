using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(MonsterFactoryComponent))]
    public static class MonsterFactoryComponentSystem
    {
        public static void OnLogic(this MonsterFactoryComponent self,int dt)
        {
            List<int> deleteIndex = new List<int>();
            foreach(int index in self.MonsterFactorys.Keys)
            {
                MonsterFactory factory = self.MonsterFactorys[index];
                bool IsDelete = factory.OnLogic(dt);
                if (IsDelete)
                {
                    deleteIndex.Add(index);
                }
            }
            if(deleteIndex.Count > 0)
            {
                for(int i=0;i<deleteIndex.Count;i++)
                {
                    int index = deleteIndex[i];
                    if (self.MonsterFactorys.ContainsKey(index))
                    {
                        MonsterFactory factory = self.MonsterFactorys[index];
                        long factoryId = factory.Id;
                        self.GetChild<MonsterFactory>(factoryId).Dispose();
                        self.MonsterFactorys.Remove(index);
                    }
                }
            }
        }
        public static void AddMonsterFactory(this MonsterFactoryComponent self,MonsterFactory factory)
        {
            self.Index++;
            self.MonsterFactorys.Add(self.Index, factory);
        }
    }
}
