using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class EarthShakeSkill : Entity,IAwake,IDestroy
    {
        public string param;
    }
}
