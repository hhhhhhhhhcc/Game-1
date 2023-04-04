using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class EcoMaterialSkill : Entity,IAwake,IDestroy,AfterBuild
    {
        public Dictionary<string, int> param;
    }
}
