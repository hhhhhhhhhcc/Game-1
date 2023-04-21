using System.Collections.Generic;

namespace ET
{
    public class OverLoadSkillAwakeSystem : AwakeSystem<OverLoadSkill>
    {
        public override void Awake(OverLoadSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1024).Params);
            self.SkillTime = self.param["chargetime"];
            self.ContinuedTime = self.param["lasttime"];
            self.ContinuedTimer = 0;
            self.SkillTimer = 0;
            self.PrefabName = "Bullet3";
            self.FlySpeed = 5;
        }
    }
    [FriendClass(typeof(OverLoadSkill))]
    [FriendClass(typeof(Tower))]
    public static class OverLoadSkillSystem
    {
        public static void OnLogic(this OverLoadSkill self,int dt) 
        {
            if(self.GetParent<Tower>().state == TowerState.NormalAttack)
            {
                self.SkillTimer = self.SkillTimer + dt;
                Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime, towerstate = self.GetParent<Tower>().GetTowerState() }).Coroutine();
                if(self.SkillTimer >= self.SkillTime && self.GetParent<Tower>().AttackTargetList.Count > 0)
                {
                    self.GetParent<Tower>().AttackInterval = self.GetParent<Tower>().AttackInterval * 100 / (100 + self.param["attackspeedadd"]) ;
                    self.GetParent<Tower>().state = TowerState.SkillAttack;
                    self.SkillTimer = 0;
                }
            }
            else if(self.GetParent<Tower>().state == TowerState.SkillAttack)
            {
                self.ContinuedTimer = self.ContinuedTimer + dt;
                Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = 1.0f - (float)self.ContinuedTimer / (float)self.ContinuedTime, towerstate = self.GetParent<Tower>().GetTowerState() }).Coroutine();
                if (self.ContinuedTimer >= self.ContinuedTime)
                {
                    self.GetParent<Tower>().AttackInterval = self.GetParent<Tower>().AttackInterval * (100 + self.param["attackspeedadd"]) / 100;
                    self.GetParent<Tower>().state = TowerState.NormalAttack;
                    self.ContinuedTimer = 0;
                }
            }
        }
        public static void OnSkill(this OverLoadSkill self)
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
            string buffparam = "";
            if (self.GetParent<Tower>().GetComponent<FreezeFireSkill>() != null)
            {
                buffparam = self.GetParent<Tower>().GetComponent<FreezeFireSkill>().GetParams();
            }
            Dictionary<string, int> param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1022).Params);
            UnitFactory.CreateMulRangeBullet(self.ZoneScene().CurrentScene(),
                 self.GetParent<Tower>(),
                 self.GetParent<Tower>().AttackTargetList[0],
                 self.PrefabName,
                 self.FlySpeed,
                 param["damagerange"] * (100 + damagerangeadd) / 100,
                 param["damageinterval"],
                 param["lasttime"] + lasttimeadd,
                 isap,
                 100,
                 self.GetParent<Tower>().ExtraCoin, buffparam).Coroutine();
        }
    }
}
