using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(TowerFactory))]
    public class TowerFactoryComponent : Entity, IAwake, IDestroy
    {
        public Dictionary<int, TowerFactory> TowerFactorys = new Dictionary<int, TowerFactory>();
        public int Index;
    }
}
