using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class ReaperSkill : Entity,IAwake,IDestroy
    {
        public Dictionary<string, int> param;
    }
}
