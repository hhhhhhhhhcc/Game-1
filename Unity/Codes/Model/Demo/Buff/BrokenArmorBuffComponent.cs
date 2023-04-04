using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class BrokenArmorBuffComponent : Entity,IAwake,IDestroy,LogicBuff
    {
        public int BuffTimer;
        public int BuffTime;
        public Dictionary<string, int> param = new Dictionary<string, int>();
        public bool IsTrigger;
        public float TheoryPhysicsDefense;
        public float TheoryMagicDefense;
    }
}
