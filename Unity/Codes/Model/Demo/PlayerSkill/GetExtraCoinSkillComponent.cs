using System.Collections.Generic;

namespace ET
{
    public class GetExtraCoinSkillComponent : Entity,IAwake,IDestroy,PlayerLogic, PlayerAfterKillCoin,PlayerInitZoneSkill
    {
        public Dictionary<string,int> param = new Dictionary<string,int>();
        public int Time;
        public int Timer;
        public int Zone;
    }
}
