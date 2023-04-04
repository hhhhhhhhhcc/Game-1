using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class LockVertigoBuffComponent : Entity,IAwake,IDestroy,LogicBuff
    {
        public int BuffTime;
        public int BuffTimer;
        public string param;
        public Dictionary<string, int> paramdict;
    }
}
