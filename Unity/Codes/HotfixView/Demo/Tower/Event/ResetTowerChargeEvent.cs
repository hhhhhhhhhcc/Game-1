using ET.EventType;

namespace ET
{
    public class ResetTowerChargeEvent : AEventAsync<EventType.ResetTowerCharge>
    {
        protected override async ETTask Run(ResetTowerCharge args)
        {
            if(args.tower.GetComponent<TowerChargeComponent>() != null)
            {
                args.tower.GetComponent<TowerChargeComponent>().Init();
            }
            await ETTask.CompletedTask;
        }
    }
}
