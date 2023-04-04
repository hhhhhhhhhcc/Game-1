using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class IgniteBuffComponent : Entity,IAwake,IDestroy,LogicBuff
    {
        public int BuffTimer;
        public int BuffTime;
        public Dictionary<string, int> param;
        public int BuffIntervalTime;
        public int BuffIntervalTimer;
        public int PhysicsAttack;
        public int MagicAttack;
    }
}
