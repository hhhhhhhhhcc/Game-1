using ET.EventType;

namespace ET
{
    public class SettingTowerEvent : AEventAsync<EventType.SettingTower>
    {
        protected override async ETTask Run(SettingTower args)
        {
            Scene zonescene = args.zonescene;
            zonescene.GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SettingTower(args.tower,args.TowerId,args.opttype,args.optId,args.invalid);
            await ETTask.CompletedTask;
        }
    }
}
