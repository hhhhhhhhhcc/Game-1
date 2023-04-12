using ET.EventType;
using UnityEngine;

namespace ET
{
    [FriendClass(typeof(TowerChargeComponent))]
    public class TowerLaserEvent : AEventAsync<EventType.TowerLaser>
    {
        protected override async ETTask Run(TowerLaser a)
        {
            LineRenderer line = a.tower.GetComponent<GameObjectComponent>().GameObject.transform.Find("Laser").GetComponent<LineRenderer>();
            if (a.index == 1)//显示
            {
                line.gameObject.SetActive(true);
                if (a.monster.Count == 0)
                {
                    line.positionCount = 0;
                }
                if (a.monster.Count == 1)
                {
                    line.positionCount = 2;
                }
                else if (a.monster.Count >= 2)
                {
                    line.positionCount = a.monster.Count * 2 - 1;
                }

                float AttackPointX = a.tower.GetComponent<TowerChargeComponent>().AttackPoint.position.x;
                float AttackPointY = a.tower.GetComponent<TowerChargeComponent>().AttackPoint.position.y;
                for (int i=0;i<line.positionCount; i++)
                {
                    if(i % 2 == 0)//怪点
                    {
                        Monster monster = a.monster[i/2];
                        float monsterposx = monster.Position.x;
                        float monsterposy = monster.Position.y;
                        line.SetPosition(i, new Vector3(monsterposx, monsterposy, -1));
                    }
                    else // 自身点
                    {
                        line.SetPosition(i, new Vector3(AttackPointX, AttackPointY, -1));
                    }
                }
            }
            if(a.index == 2)//隐藏
            {
                line.gameObject.SetActive(false);
            }
            await ETTask.CompletedTask;
        }
    }
}
