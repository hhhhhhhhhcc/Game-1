using System.Collections.Generic;

namespace ET
{
    public class GlazingRaySkill : Entity,IAwake,IDestroy,LogicSkill,Skill
    {
        public int SkillTimer;
        public int SkillTime;
        public Dictionary<string, int> param;
    }
}
