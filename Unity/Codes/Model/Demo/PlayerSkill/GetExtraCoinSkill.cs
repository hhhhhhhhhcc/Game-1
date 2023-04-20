using System.Collections.Generic;

namespace ET
{
    public class GetExtraCoinSkill : Entity,IAwake,IDestroy,LogicSkill, PlayerAfterKillCoin
    {
        public Dictionary<string,int> param = new Dictionary<string,int>();
        public int Time;
        public int Timer;
        public int Zone;
    }
}
