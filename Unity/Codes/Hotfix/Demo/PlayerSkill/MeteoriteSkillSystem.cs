using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class MeteoriteSkillAwakeSystem : AwakeSystem<MeteoriteSkill>
    {
        public override void Awake(MeteoriteSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(6001).Params);
            self.Time = self.param["time"];
            self.Timer = 0;
            self.IntervalTime = self.param["intervaltime"];
            self.IntervalTimer = 0;
        }
    }
    [FriendClass(typeof(MeteoriteSkill))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Monster))]

    public static class MeteoriteSkillSystem
    {
        public static void InitPos(this MeteoriteSkill self, List<float> posXY)
        {
            self.PosX = posXY[0];
            self.PosY = posXY[1];
        }
        public static void InitZone(this MeteoriteSkill self, int Zone)
        {
            self.Zone = Zone;
        }
        public static void OnLogic(this MeteoriteSkill self, int dt)
        {
            self.Timer = self.Timer + dt;
            self.IntervalTimer = self.IntervalTimer + dt;
            if(self.IntervalTimer >= self.IntervalTime)
            {
                //造成伤害
                float damagerange = self.param["damagerange"];//伤害范围
                int attackdamage = self.param["attackdamage"];//伤害
                List<Monster> allmonster = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().AllEnemy;
                for(int i=0;i<allmonster.Count; i++)
                {
                    Monster monster = allmonster[i];
                    if(monster != null)
                    {
                        if(monster.Zone == self.Zone)
                        {
                            float distance = Vector2.Distance(monster.Position,new Vector2(self.PosX,self.PosY));
                            float attackrange = damagerange / 1000.0f;
                            if(distance <= attackrange)
                            {
                                //造成伤害
                                DamageHelper.PlayerSkillAttackMonster(self.ZoneScene().CurrentScene(), attackdamage,0, monster);
                            }
                        }
                    }
                }
                self.IntervalTimer = self.IntervalTimer % self.IntervalTime;
            }
            if(self.Timer >= self.Time)
            {
                self?.Dispose();
            }
        }
    }
}
