using System.Collections.Generic;

namespace ET
{
    public class IgnoreArmorSkillAwakeSystem : AwakeSystem<IgnoreArmorSkill>
    {
        public override void Awake(IgnoreArmorSkill  self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1003).Params);
            self.SkillTime = self.param["chargetime"];
            self.FlySpeed = 5;
            self.PrefabName = "Arrow";
        }
    }
    [FriendClass(typeof(IgnoreArmorSkill))]
    [FriendClass(typeof(Tower))]
    public static class IgnoreArmorSkillSystem
    {
        public static void OnLogic(this IgnoreArmorSkill self, int dt)
        {
            self.SkillTimer = self.SkillTimer + dt;
            Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime }).Coroutine();
            if (self.SkillTimer >= self.SkillTime)
            {
                self.GetParent<Tower>().state = TowerState.SkillAttack;
            }
        }
        public static void OnSkill(this IgnoreArmorSkill self)//放技能
        {
            int ExtraMultiPlier = 0;
            if (SkillHelper.OnChance(self.GetParent<Tower>()))
            {
                ExtraMultiPlier = 100;
            }
            List<Monster> targetmonster = self.GetParent<Tower>().AttackTargetList;
            UnitFactory.CreateSingleBullet(self.ZoneScene().CurrentScene(),
                self.GetParent<Tower>(),
                targetmonster[0],
                self.PrefabName,
                self.FlySpeed,
                self.param["isap"],
                self.param["multiplier"] + ExtraMultiPlier,
                self.GetParent<Tower>().ExtraCoin, SkillConfigCategory.Instance.Get(1003).Params).Coroutine();
            targetmonster.Clear();
            self.SkillTimer = 0;
            self.GetParent<Tower>().state = TowerState.NormalAttack;
        }
    }
}
