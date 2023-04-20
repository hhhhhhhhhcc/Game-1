namespace ET
{
    [ActorMessageHandler]
    public class C2M_AdjustFormHandler : AMActorLocationHandler<Unit, C2M_AdjustForm>
    {
        protected override async ETTask Run(Unit unit, C2M_AdjustForm message)
        {
            NumericComponent num = unit.GetComponent<NumericComponent>();
            num.Set(NumericType.TowerId1, message.Tower1);
            num.Set(NumericType.TowerId2, message.Tower2);
            num.Set(NumericType.TowerId3, message.Tower3);
            num.Set(NumericType.TowerId4, message.Tower4);
            num.Set(NumericType.Monster1, message.Pet1);
            num.Set(NumericType.Monster2, message.Pet2);
            num.Set(NumericType.Monster3, message.Pet3);
            num.Set(NumericType.Monster4, message.Pet4);
            unit.GetComponent<UnitSaveDBComponent>()?.SaveChange();
            await ETTask.CompletedTask;
        }
    }
}
