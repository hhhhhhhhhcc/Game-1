using UnityEngine;

namespace ET
{
    public class TimeChangeMonsterPos : AEventAsync<EventType.TimeChangeMonsterPos>

    {
        protected override async ETTask Run(EventType.TimeChangeMonsterPos args)
        {
            args.monster.Position = args.monster.Position + args.v.normalized * Time.deltaTime * args.speed;
            await ETTask.CompletedTask;
        }
    }
}
