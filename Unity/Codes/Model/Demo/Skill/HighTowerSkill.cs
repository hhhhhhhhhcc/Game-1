using System.Collections.Generic;

namespace ET
{
    public class HighTowerSkill : Entity,IAwake,IDestroy,BeforeBuild
    {
        public Dictionary<string, int> param;
    }
}
