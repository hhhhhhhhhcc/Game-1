using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class SunSpotSkill : Entity,IAwake,IDestroy
    {
        public Dictionary<string, int> param;
    }
}
