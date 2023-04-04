using System.Collections.Generic;

namespace ET
{
    public class BlowUpSkillAwakeSystem : AwakeSystem<BlowUpSkill>
    {
        public override void Awake(BlowUpSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1023).Params);
            self.SkillTime = self.param["chargetime"];
            self.FlySpeed = 5;
            self.PrefabName = "Bullet2";
        }
    }
    [FriendClass(typeof(BlowUpSkill))]
    [FriendClass(typeof(Tower))]
    public static class BlowUpSkillSystem
    {
        public static void OnLogic(this BlowUpSkill self,int dt)
        {
            self.SkillTimer = self.SkillTimer + dt;
            Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime }).Coroutine();
            if (self.SkillTimer >= self.SkillTime)
            {
                self.GetParent<Tower>().state = TowerState.SkillAttack;
            }
        }
        public static void OnSkill(this BlowUpSkill self)
        {
            int isap = 0;
            if (self.GetParent<Tower>().GetComponent<LiquidFireSkill>() != null)
            {
                isap = self.GetParent<Tower>().GetComponent<LiquidFireSkill>().GetAP();
            }
            int damagerangeadd = 0;
            if (self.GetParent<Tower>().GetComponent<CombustionAidSkill>() != null)
            {
                damagerangeadd = self.GetParent<Tower>().GetComponent<CombustionAidSkill>().GetRangeAdd();
            }
            int lasttimeadd = 0;
            if (self.GetParent<Tower>().GetComponent<SunSpotSkill>() != null)
            {
                lasttimeadd = self.GetParent<Tower>().GetComponent<SunSpotSkill>().GetLastTimeAdd();
            }
            string param = "";
            if(self.GetParent<Tower>().GetComponent<FreezeFireSkill>() != null)
            {
                param = self.GetParent<Tower>().GetComponent<FreezeFireSkill>().GetParams();
            }
            List<Monster> attackmonster = self.GetParent<Tower>().AttackTargetList;
            UnitFactory.CreateRangeBullet(self.ZoneScene().CurrentScene(),
                  self.GetParent<Tower>(),
                  attackmonster[0],
                  self.PrefabName,
                  self.FlySpeed,
                  self.param["damagerange"] + damagerangeadd,
                  isap,
                  self.param["multiplier"] + lasttimeadd,
                  self.GetParent<Tower>().ExtraCoin, param).Coroutine();
            self.SkillTimer = 0;
            self.GetParent<Tower>().state = TowerState.NormalAttack;
        }
    }
}
