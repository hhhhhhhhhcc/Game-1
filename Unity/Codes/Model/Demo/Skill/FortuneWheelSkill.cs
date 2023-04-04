using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class FortuneWheelSkill : Entity,IAwake,IDestroy,ChanceSkill
    {
        public Dictionary<string, int> param = new Dictionary<string, int>();
    }
}
