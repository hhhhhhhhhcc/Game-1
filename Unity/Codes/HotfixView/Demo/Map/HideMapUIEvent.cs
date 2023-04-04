using ET.EventType;

namespace ET
{
    public class HideMapUIEvent : AEventAsync<EventType.HideMapUI>
    {
        protected override async ETTask Run(HideMapUI args)
        {
            args.currentscene.GetComponent<MapComponent>().Dispose();
            args.currentscene.GetComponent<FlyDamageValueViewComponent>().Dispose();
            await ETTask.CompletedTask;
        }
    }
}
