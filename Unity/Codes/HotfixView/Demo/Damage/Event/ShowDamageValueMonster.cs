using ET.EventType;
using UnityEngine;

namespace ET
{
    public class ShowDamageValueMonster : AEventAsync<EventType.ShowDamageValueMonster>
    {
        protected override async ETTask Run(EventType.ShowDamageValueMonster a)
        {
            a.monster.GetComponent<HeadHpViewComponent>().SetMonsterHp();
            a.monster.GetComponent<HeadHpViewComponent>().ShowHpBar();
            float px = a.monster.Position.x;
            float py = a.monster.Position.y;
            //a.currentscene.GetComponent<FlyDamageValueViewComponent>().SpawnFlyDamage(new Vector2(px,py), a.damagevalue).Coroutine();
            await ETTask.CompletedTask;
        }
    }
}
