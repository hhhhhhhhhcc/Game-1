using ET.EventType;

namespace ET
{
    public class AfterTroopCreateTroopEvent : AEventAsync<EventType.AfterUnitCreateTroop>
    {
        protected override async ETTask Run(AfterUnitCreateTroop args)
        {

            await ETTask.CompletedTask;
        }
    }
}
