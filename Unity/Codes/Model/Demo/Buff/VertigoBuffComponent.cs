using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class VertigoBuffComponent : Entity,IAwake,IDestroy,LogicBuff
    {
        public Dictionary<string,int> param = new Dictionary<string,int>();
        public int lasttime;
        public int timer;
    }
}
