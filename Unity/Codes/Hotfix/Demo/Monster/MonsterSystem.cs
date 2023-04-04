using System;
using System.Collections.Generic;

namespace ET
{
    public class MonsterAwakeSystem : AwakeSystem<Monster,int>
    {
        public override void Awake(Monster self,int configId)
        {
            self.ConfigId = configId;
            self.State = MonsterState.Run;
            self.IsDead = false;
            self.DelayAnimatorLogic = 0;
        }
    }
    public static class MonsterSystem
    {
        public static void OnLogic(this Monster self,int dt)
        {
            self.GetComponent<MonsterMoveComponent>().OnLogic(dt);
            List<Type> types = new List<Type>();
            foreach(Type type in self.Components.Keys)
            {
                types.Add(type);
            }
            for(int i= types.Count - 1;i>=0;i--)
            {
                Type type = types[i];
                if (typeof(LogicBuff).IsAssignableFrom(type))
                {
                    Entity component = self.Components[type];
                    object[] param = new object[] { component, dt };
                    Type system = Type.GetType(type.FullName + "System");
                    system.GetMethod("OnLogic").Invoke(component, param);
                }
            }
        }
    }
}
