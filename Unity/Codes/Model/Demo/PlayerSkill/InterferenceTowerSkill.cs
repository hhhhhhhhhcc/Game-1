using System.Collections.Generic;

namespace ET
{
    public class InterferenceTowerSkill : Entity,IAwake,IDestroy,PlayerLogic,PlayerInitTowerSkill,PlayerInitZoneSkill
    {
        public Tower Tower;
        public int Timer;
        public int Time;
        public Dictionary<string,int> param = new Dictionary<string,int>();
        public int Zone;
    }
}
