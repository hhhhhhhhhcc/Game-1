namespace ET
{
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(Troop))]
    public class TroopComponent : Entity,IAwake,IDestroy
    {

    }
}
