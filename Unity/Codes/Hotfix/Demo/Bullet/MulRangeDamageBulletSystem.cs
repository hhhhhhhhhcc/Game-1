﻿using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace ET
{
    public class MulRangeDamageBulletAwakeSystem : AwakeSystem<MulRangeDamageBullet>
    {
        public override void Awake(MulRangeDamageBullet self)
        {
            self.IsTrigger = false;
            self.AllTimer = 0;
            self.AllTime = 0;
            self.SingleDamageInterval = 0;
            self.SingleDamageIntervalTimer = 0;
        }
    }
    public class MulRangeDamageBulletUpdateSystem : UpdateSystem<MulRangeDamageBullet>
    {
        public override void Update(MulRangeDamageBullet self)
        {
            self.ToTarget();
        }
    }

    [FriendClass(typeof(MulRangeDamageBullet))]
    [FriendClass(typeof(Monster))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Bullet))]
    public static class MulRangeDamageBulletSystem
    {
        public static async ETTask OnLogic(this MulRangeDamageBullet self, int dt)
        {
            if(self.IsTrigger == true)
            {
                self.SingleDamageIntervalTimer = self.SingleDamageIntervalTimer + dt;
                self.AllTimer = self.AllTimer + dt;
                if (self.SingleDamageIntervalTimer > self.SingleDamageInterval)
                {
                    self.SingleDamageIntervalTimer = self.SingleDamageIntervalTimer - self.SingleDamageInterval;
                    List<Monster> damagemonster = new List<Monster>();
                    List<Monster> monsters = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().AllEnemy;
                    if (monsters == null) return;
                    float radius = self.DamageRange;
                    Log.Debug(radius.ToString());
                    for (int i = 0; i < monsters.Count; i++)
                    {
                        Monster currentmonster = monsters[i];
                        if (currentmonster == null || currentmonster.IsDead) continue;
                        if (Vector3.Distance(self.DirPos, currentmonster.Position) <= ((float)radius/1000.0f))
                        {
                            damagemonster.Add(currentmonster);
                        }
                    }
                    DamageHelper.BulletRangeAttackMonster(self.ZoneScene().CurrentScene(), self.GetParent<Bullet>(), damagemonster, self.PhysicsDamage, self.MagicDamage,self.IsAP,self.Multiplier,self.GetParent<Bullet>().ExtraCoin).Coroutine();
                }
                if (self.AllTimer > self.AllTime)
                {
                    await Game.EventSystem.PublishAsync(new EventType.BulletDestroy() { currentscene = self.ZoneScene().CurrentScene(), Bullet = self.GetParent<Bullet>(),IsDelay = false,DelayAnimatorName = "Trigger" });
                }
                return;
            }
            Vector3 dst = self.DirPos;
            Vector3 src = self.GetParent<Bullet>().Position;
            Vector3 dir = dst - src;//向目标点方向向量
            float len = dir.magnitude;//获取向量长度
            float time = len / self.Speed;//获取到目标点 总的时间
            float dt_ms = dt / (float)1000.0f;//一帧的时间66
            if (time <= dt_ms)//造成伤害
            {
                self.IsTrigger = true;
                Game.EventSystem.PublishAsync(new EventType.BulletBeforeDestroyAnimator() { entity = self.GetParent<Bullet>() ,AnimatorName = "Trigger" }).Coroutine();
                self.GetParent<Bullet>().LogicPos = self.GetParent<Bullet>().Position;//迭代完位置后 用帧位置来记录当前位置 用于下一次帧同步
                return;
            }
            else
            {
                self.GetParent<Bullet>().LogicPos = self.GetParent<Bullet>().LogicPos + dir.normalized * dt_ms * self.Speed;
                self.GetParent<Bullet>().Position = self.GetParent<Bullet>().LogicPos;//迭代完位置后 用帧位置来记录当前位置 用于下一次帧同步

                await ETTask.CompletedTask;
            }
        }
        public static async void ToTarget(this MulRangeDamageBullet self)
        {
            //if (self == null) return;
            if (self?.ZoneScene()?.CurrentScene()?.GetComponent<GameComponent>()?.SingleGameModeState == false || self.IsTrigger == true) return;
            if (self.DirPos == null)
            {
                await Game.EventSystem.PublishAsync(new EventType.BulletDestroy() { currentscene = self.ZoneScene().CurrentScene(), Bullet = self.GetParent<Bullet>() });
                return;
            }
            Vector3 v = self.DirPos - self.GetParent<Bullet>().Position;//子弹位移方向
            self.GetParent<Bullet>().Position = self.GetParent<Bullet>().Position + v.normalized * Time.deltaTime * self.Speed;
            if (v.x != 0)//朝向
            {
                self.GetParent<Bullet>().Rotation = Quaternion.Euler(0, 0, Mathf.Atan(v.y / v.x) * Mathf.Rad2Deg);
            }
            if (v.x < 0)
            {
                self.GetParent<Bullet>().Rotation = Quaternion.Euler(0, 0, Mathf.Atan(v.y / v.x) * Mathf.Rad2Deg + 180);
            }
        }
    }
}

