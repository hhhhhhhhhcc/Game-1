using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class LevelComponent : Entity,IAwake,IDestroy
    {
        public List<int> LevelData = new List<int>();
    }
}
