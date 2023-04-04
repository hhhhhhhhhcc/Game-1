using ET.EventType;
using UnityEngine;

namespace ET
{
    public class MonsterMoveEvent : AEventAsync<EventType.MonsterMove>
    {
        protected override async ETTask Run(MonsterMove args)
        {
            args.monster.GetComponent<GameObjectComponent>().GameObject.GetComponent<SpriteRenderer>().flipX = args.flip;
        }
    }
}
