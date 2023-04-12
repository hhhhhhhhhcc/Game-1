using System.Collections.Generic;

namespace ET
{
    public class TowerAddPropertiesSkill : Entity,IAwake,IDestroy,PlayerInitZoneSkill,PlayerLogic,PlayerInitTowerSkill
    {
        public Dictionary<string,int> param = new Dictionary<string,int>();
        public Tower Tower;
        public int Timer;
        public int Time;
        public int Zone;
    }
}
