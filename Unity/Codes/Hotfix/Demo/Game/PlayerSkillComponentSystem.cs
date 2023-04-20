using System;
using System.Collections.Generic;

namespace ET
{
    public static class PlayerSkillComponentSystem
    {
        public static void OnLogic(this PlayerSkillComponent self,int dt)
        {
            List<Type> types = new List<Type>();
            foreach (Type type in self.Components.Keys)
            {
                types.Add(type);
            }
            for (int i = types.Count - 1; i >= 0; i--)
            {
                Type type = types[i];
                if (typeof(LogicSkill).IsAssignableFrom(type))
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
