using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class BurningBuffComponent : Entity,IAwake,IDestroy,LogicBuff
    {
        public int lasttime;
        public int lasttimer;
        public int intervaltime;
        public int intervaltimer;
        public int PhysicsDamage;
        public int MagicDamage;
        public Dictionary<string,int> param = new Dictionary<string,int>();
    }
}
