using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class DecelerateBuffComponent : Entity, IAwake, IDestroy, LogicBuff
    {
        public bool IsTrigger;
        public Dictionary<string, int> param = new Dictionary<string, int>();
        public int lasttime;
        public int timer;
        public int effect;
    }
}
