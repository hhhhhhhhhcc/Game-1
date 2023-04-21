using System.Collections.Generic;

namespace ET
{
    public class ThiefSkillAwakeSystem : AwakeSystem<ThiefSkill>
    {
        public override void Awake(ThiefSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1010).Params);
            self.SkillTime = self.param["chargetime"];
            self.FlySpeed = 5;
            self.PrefabName = "Bullet2";
        }
    }
    [FriendClass(typeof(ThiefSkill))]
    [FriendClass(typeof(Tower))]
    public static class ThiefSkillSystem 
    {
        public static void OnLogic(this ThiefSkill self, int dt)
        {
            self.SkillTimer = self.SkillTimer + dt;
            Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime, towerstate = self.GetParent<Tower>().GetTowerState() }).Coroutine();
            if (self.SkillTimer >= self.SkillTime)
            {
                self.GetParent<Tower>().state = TowerState.SkillAttack;
            }
        }
        public static void OnSkill(this ThiefSkill self)//放技能
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
                      self.GetParent<Tower>().ExtraCoin + self.param["hitcoin"], SkillConfigCategory.Instance.Get(1010).Params).Coroutine();
            self.SkillTimer = 0;
            self.GetParent<Tower>().state = TowerState.NormalAttack;
        }
    }
}
