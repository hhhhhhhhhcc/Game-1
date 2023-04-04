using System.Collections.Generic;

namespace ET
{
    public class OvercLockingSkill : Entity,IAwake,IDestroy
    {
        public Dictionary<string,int> param = new Dictionary<string,int>();
    }
}
