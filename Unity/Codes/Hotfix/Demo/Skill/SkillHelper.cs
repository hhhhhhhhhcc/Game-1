using System.Collections.Generic;
using System;
using System.Reflection;

namespace ET
{
    public static class SkillHelper
    {
        public static Dictionary<string,int> GetSkillString(string SkillParams) 
        {
            Dictionary<string,int> list = new Dictionary<string,int>();
            string[] param = SkillParams.Split(';');
            for(int i=0;i<param.Length;i++)
            {
                string[] temp = param[i].Split(',');
                if(temp.Length == 2)
                {
                    string name = temp[0];
                    int numeric = int.Parse(temp[1]);
                    if(!list.ContainsKey(name))
                    {
                        list.Add(name, numeric);
                    }
                }
            }
            return list;
        }
        public static void OnSkill(Entity entity)
        {
            foreach (Type type in entity.Components.Keys)
            {
                if (typeof(Skill).IsAssignableFrom(type))
                {
                    Entity component = entity.Components[type];
                    Type system = Type.GetType(type.FullName + "System");
                    system.GetMethod("OnSkill").Invoke(component, new object[] {component});
                }
            }
        }
        public static void LogicAddBuff(Entity entity)
        {
            foreach (Type type in entity.Components.Keys)
            {
                if (typeof(LogicAddBuff).IsAssignableFrom(type))
                {
                    Entity component = entity.Components[type];
                    Type system = Type.GetType(type.FullName + "System");
                    system.GetMethod("OnAddBuff").Invoke(component, new object[] { component });
                }
            }
        }
        
        public static bool OnChance(Entity entity)
        {
            foreach (Type type in entity.Components.Keys)
            {
                if (typeof(ChanceSkill).IsAssignableFrom(type))
                {
                    Entity component = entity.Components[type];
                    Type system = Type.GetType(type.FullName + "System");
                    object chance = system.GetMethod("OnChance").Invoke(component, new object[] { component });
                    return (bool)chance;
                }
            }
            return false;
        }
        public static int GetBuildLossMoney(Scene zonescene,int ConfigId)
        {
            List<int> TalentId = zonescene.GetComponent<FightItemComponent>().GetTowerTalentIdByConfigId(ConfigId);
            for(int i = 0;i < TalentId.Count;i++)
            {
                int skillid = TalentConfigCategory.Instance.Get(TalentId[i]).SkillId;
                SkillConfig skillconfig = SkillConfigCategory.Instance.Get(skillid);
                string skillscript = skillconfig.Script;
                Type type = Type.GetType("ET." + skillscript);//technological 类
                if(typeof(BeforeBuild).IsAssignableFrom(type))
                {
                    object obj = type.Assembly.CreateInstance(type.FullName);//technological 类实例
                    Type system = Type.GetType(type.FullName + "System");//technologicalsystem
                    MethodInfo method = system.GetMethod("getbuildloss");
                    if(method != null)
                    {
                        object objloss = method.Invoke(obj, new object[] { obj });
                        int loss = (int)objloss;
                        return TowerConfigCategory.Instance.GetTowerNeedMoneyByTowerId(ConfigId) * (100 - loss) / 100;
                    }
                }
            }
            return TowerConfigCategory.Instance.GetTowerNeedMoneyByTowerId(ConfigId);
        }
        public static int GetSaleLoss(Scene zonescene, int ConfigId)
        {
            List<int> TalentId = zonescene.GetComponent<FightItemComponent>().GetTowerTalentIdByConfigId(ConfigId);
            for (int i = 0; i < TalentId.Count; i++)
            {
                int skillid = TalentConfigCategory.Instance.Get(TalentId[i]).SkillId;
                SkillConfig skillconfig = SkillConfigCategory.Instance.Get(skillid);
                string skillscript = skillconfig.Script;
                Type type = Type.GetType("ET." + skillscript);//technological 类
                if (typeof(AfterBuild).IsAssignableFrom(type))
                {
                    object obj = type.Assembly.CreateInstance(type.FullName);//technological 类实例
                    Type system = Type.GetType(type.FullName + "System");//technologicalsystem
                    MethodInfo method = system.GetMethod("getsaleloss");
                    if(method != null)
                    {
                        object objloss = method.Invoke(obj, new object[] { obj });
                        return (int)objloss;
                    }
                }
            }
            return 30;
        }
        public static int GetBeforeBuildRange(Scene zonescene, int ConfigId)
        {
            List<int> TalentId = zonescene.GetComponent<FightItemComponent>().GetTowerTalentIdByConfigId(ConfigId);
            for (int i = 0; i < TalentId.Count; i++)
            {
                int skillid = TalentConfigCategory.Instance.Get(TalentId[i]).SkillId;
                SkillConfig skillconfig = SkillConfigCategory.Instance.Get(skillid);
                string skillscript = skillconfig.Script;
                Type type = Type.GetType("ET." + skillscript);//technological 类
                if (typeof(BeforeBuild).IsAssignableFrom(type))
                {
                    object obj = type.Assembly.CreateInstance(type.FullName);//technological 类实例
                    Type system = Type.GetType(type.FullName + "System");//technologicalsystem
                    MethodInfo method = system.GetMethod("GetAttackRangeAdd");
                    if(method != null)
                    {
                        object attackrangeadd = method.Invoke(obj, new object[] { obj });
                        return (int)attackrangeadd;
                    }
                }
            }
            return 0;
        }
        public static int GetExtraKillCoin(Scene currentscene)//玩家技能击杀额外金币
        {
            int AllExtraCoin = 0;
            PlayerSkillComponent playerskillcomponent = currentscene.GetComponent<GameComponent>().GetComponent<PlayerSkillComponent>();
            foreach (Type type in playerskillcomponent.Components.Keys)
            {
                if (typeof(PlayerAfterKillCoin).IsAssignableFrom(type))
                {
                    Entity component = playerskillcomponent.Components[type];
                    Type system = Type.GetType(type.FullName + "System");
                    MethodInfo method = system.GetMethod("GetExtraCoin");
                    if (method == null) continue;
                    object extracoin = method.Invoke(component, new object[] { component });
                    AllExtraCoin = AllExtraCoin + (int)extracoin;
                }
            }
            return AllExtraCoin;
        }
        public static void ReleasePlayerSkill(Scene currentscene)
        {

        }
    }
}
