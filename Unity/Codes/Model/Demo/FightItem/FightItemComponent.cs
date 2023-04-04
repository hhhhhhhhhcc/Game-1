using System.Collections.Generic;

namespace ET
{
    [ChildType(typeof(FightItem))]
    [ComponentOf(typeof(Scene))]
    public class FightItemComponent: Entity, IAwake, IDestroy
    {
        public Dictionary<long, FightItem> FightItemDict = new Dictionary<long, FightItem>();
    }
}
