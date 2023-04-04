using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class SniperEyepiecesSkill : Entity,IAwake,IDestroy,BeforeBuild
    {
        public Dictionary<string, int> param = new Dictionary<string, int>();
    }
}
