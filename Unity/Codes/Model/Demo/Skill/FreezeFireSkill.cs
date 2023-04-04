using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class FreezeFireSkill : Entity,IAwake,IDestroy
    {
        public string param;
    }
}
