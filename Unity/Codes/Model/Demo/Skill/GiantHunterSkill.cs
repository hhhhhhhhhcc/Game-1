using System.Collections.Generic;

namespace ET
{
    public class GiantHunterSkill  : Entity,IAwake,IDestroy,LogicSkill,Skill
    {
        public int SkillTimer;
        public int SkillTime;
        public int ContinuedTime;
        public int ContinuedTimer;
        public int ExtraTargetCount;
        public Dictionary<string, int> param;
        public Monster AttackMonster;
    }
}
