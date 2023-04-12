namespace ET
{
    
    public class SceneChangeFinishEvent: AEventAsync<EventType.SceneChangeFinish>
    {
        protected override async ETTask Run(EventType.SceneChangeFinish args)
        {
            args.ZoneScene.GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Loading);
            await ETTask.CompletedTask;
        }
    }
    
}