using ET.EventType;

namespace ET
{
    public class RefreshTalentUIEvent : AEventAsync<EventType.RefreshTalentUI>
    {
        protected override async ETTask Run(RefreshTalentUI args)
        {
            args.zonescene.GetComponent<UIComponent>().GetDlgLogic<DlgTalentUI>().RefreshByTab();
            await ETTask.CompletedTask;
        }
    }
}
