using System.Collections.Generic;

namespace ET
{
    public class BlowUpSkill : Entity,IAwake,IDestroy,LogicSkill,Skill
    {
        public int SkillTimer;
        public int SkillTime;
        public string PrefabName;
        public int FlySpeed;
        public Dictionary<string, int> param;
    }
}
