using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class HaloSkill : Entity,IAwake,IDestroy
    {
        public string param;
    }
}
