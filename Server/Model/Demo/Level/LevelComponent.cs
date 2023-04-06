using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Unit))]
    public class LevelComponent : Entity,IAwake,IDestroy,ITransfer,IUnitCache
    {
        public List<int> LevelData = new List<int>();
    }
}
