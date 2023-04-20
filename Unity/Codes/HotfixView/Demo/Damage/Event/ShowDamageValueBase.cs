using ET.EventType;
using UnityEngine;

namespace ET
{
    public class ShowDamageValueBase : AEventAsync<EventType.ShowDamageValueBase>
    {
        protected override async ETTask Run(EventType.ShowDamageValueBase a)
        {
            a.baseitem.GetComponent<HeadHpViewComponent>().SetBaseHp();
            a.baseitem.GetComponent<HeadHpViewComponent>().ShowHpBar();
            Vector3 pos = a.baseitem.Position;
            //a.currentscene.GetComponent<FlyDamageValueViewComponent>().SpawnFlyDamage(pos, a.damagevalue).Coroutine();
            //显示基地上方血量变化
            a.currentscene.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetBaseHp(a.baseitem);
            await ETTask.CompletedTask;
        }
    }
}
