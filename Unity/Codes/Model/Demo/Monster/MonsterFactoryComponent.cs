using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(MonsterFactory))]
    public class MonsterFactoryComponent : Entity,IAwake,IDestroy
    {
        public Dictionary<int,MonsterFactory> MonsterFactorys = new Dictionary<int,MonsterFactory>();
        public int Index;
        
    }
}
