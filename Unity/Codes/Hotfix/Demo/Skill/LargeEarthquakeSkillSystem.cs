using JetBrains.Annotations;
using System.Collections.Generic;

namespace ET
{
    public class LargeEarthquakeSkillAwakeSystem : AwakeSystem<LargeEarthquakeSkill>
    {
        public override void Awake(LargeEarthquakeSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1009).Params);
            self.SkillTime = self.param["chargetime"];
            self.FlySpeed = 5;
            self.PrefabName = "Bullet2";
        }
    }

    [FriendClass(typeof(LargeEarthquakeSkill))]
    [FriendClass(typeof(Tower))]
    public static class LargeEarthquakeSkillSystem
    {
        public static void OnLogic(this LargeEarthquakeSkill self, int dt)
        {
            self.SkillTimer = self.SkillTimer + dt;
            Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime }).Coroutine();
            if (self.SkillTimer >= self.SkillTime)
            {
                self.GetParent<Tower>().state = TowerState.SkillAttack;
            }
        }
        public static void OnSkill(this LargeEarthquakeSkill self)//放技能
        {
            List<Monster> targetmonster = self.GetParent<Tower>().AttackTargetList;

            UnitFactory.CreateRangeBullet(self.ZoneScene().CurrentScene(),
                      self.GetParent<Tower>(),
                      targetmonster[0],
                      self.PrefabName,
                      self.FlySpeed,
                      self.param["damagerange"],
                      0,
                      100,
                      self.GetParent<Tower>().ExtraCoin, SkillConfigCategory.Instance.Get(1009).Params).Coroutine();
            self.SkillTimer = 0;
            self.GetParent<Tower>().state = TowerState.NormalAttack;
        }
    }

}
