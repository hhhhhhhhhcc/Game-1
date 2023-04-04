using System.Collections.Generic;

namespace ET
{
    public class TechnologicalBuildingSkill : Entity,IAwake,IDestroy,BeforeBuild
    {
        public Dictionary<string, int> param;
    }
}
