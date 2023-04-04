using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class ResonanceBuffComponent :Entity,IAwake,IDestroy
    {
        public Dictionary<string, int> param = new Dictionary<string, int>();
    }
}
