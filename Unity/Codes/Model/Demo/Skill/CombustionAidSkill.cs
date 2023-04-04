
using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class CombustionAidSkill : Entity,IAwake,IDestroy
    {
        public Dictionary<string, int> param;
    }
}
