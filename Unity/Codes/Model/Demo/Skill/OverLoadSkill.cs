using System.Collections.Generic;

namespace ET
{
    public class OverLoadSkill :Entity,IAwake,IDestroy, LogicSkill,Skill
    {
        public int SkillTimer;
        public int SkillTime;
        public int ContinuedTime;
        public int ContinuedTimer;
        public string PrefabName;
        public int FlySpeed;
        public Dictionary<string, int> param;
    }
}
