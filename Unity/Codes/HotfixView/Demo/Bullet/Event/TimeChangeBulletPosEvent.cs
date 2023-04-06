using ET.EventType;
using UnityEngine;

namespace ET
{
    public class TimeChangeBulletPosEvent : AEventAsync<EventType.TimeChangeBulletPos>
    {
        protected override async ETTask Run(TimeChangeBulletPos args)
        {
            Bullet bullet = args.bullet;
            bullet.Position = bullet.Position + args.v.normalized * Time.deltaTime * args.speed;
            if (args.v.x != 0)//朝向
            {
                args.bullet.Rotation = Quaternion.Euler(0, 0, Mathf.Atan(args.v.y / args.v.x) * Mathf.Rad2Deg);
            }
            if (args.v.x < 0)
            {
                args.bullet.Rotation = Quaternion.Euler(0, 0, Mathf.Atan(args.v.y / args.v.x) * Mathf.Rad2Deg + 180);
            }
            await ETTask.CompletedTask;
        }
    }
}
