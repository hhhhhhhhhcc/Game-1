using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class BountyHunterSkill : Entity,IAwake,IDestroy
    {
        public Dictionary<string, int> param = new Dictionary<string, int>();
    }
}
