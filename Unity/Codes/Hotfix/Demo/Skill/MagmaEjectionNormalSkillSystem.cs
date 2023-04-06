using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(Tower))]
    public class MagmaEjectionNormalSkillAwakeSystem : AwakeSystem<MagmaEjectionNormalSkill>
    {
        public override void Awake(MagmaEjectionNormalSkill self)
        {
            self.AttackIntervalTimer = 0;
            self.PrefabName = "Bullet3";
            self.FlySpeed = 5;
            self.RemainAttackNumber = 0;
            self.RemainAttackLogic = 0;
            self.param = new Dictionary<string, int>();
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1022).Params);
        }
    }
    [FriendClass(typeof(MagmaEjectionNormalSkill))]
    [FriendClass(typeof(Tower))]
    public static class MagmaEjectionNormalSkillSystem
    {
        public static void OnLogic(this MagmaEjectionNormalSkill self, int dt)
        {
            self.AttackIntervalTimer = self.AttackIntervalTimer + dt;
            List<Monster> attacktargetlist = self.GetParent<Tower>().AttackTargetList;
            if (self.RemainAttackLogic > 0 && attacktargetlist.Count > 0)//例如两只箭延时攻击分开打 延时剩余攻击数量大于 并且攻击列表数量大于0
            {
                self.RemainAttackLogic--;
                if (self.RemainAttackLogic == 0)
                {
                    self.Attack(attacktargetlist);
                    self.RemainAttackNumber--;
                    if (self.RemainAttackNumber > 0)
                    {
                        self.RemainAttackLogic = 2;
                    }
                }
            }
            else//若有一个不满足则都归0
            {
                self.RemainAttackLogic = 0;
                self.RemainAttackNumber = 0;
            }
            if (self.AttackIntervalTimer >= self.GetParent<Tower>().AttackInterval)
            {
                if(attacktargetlist.Count > 0)
                {
                    if(self.GetParent<Tower>().state == TowerState.NormalAttack)
                    {
                        self.Attack(attacktargetlist);//直接攻击
                        self.RemainAttackNumber = self.GetParent<Tower>().AttackNumber;//获得攻击数量
                        self.RemainAttackNumber--;//攻击数量--
                        if (self.RemainAttackNumber > 0)//若攻击了还大于0 则给延时攻击帧赋值为2 例如攻击两个 攻击了之后number = 1，logic = 2
                        {
                            self.RemainAttackLogic = 2;
                        }
                    }
                    else if(self.GetParent<Tower>().state == TowerState.SkillAttack)
                    {
                        SkillHelper.OnSkill(self.GetParent<Tower>());
                    }
                    self.AttackIntervalTimer = 0;//初始化攻击时间  
                }
            }
        }
        public static void Attack(this MagmaEjectionNormalSkill self,List<Monster> attackmonsterlist)
        {
            int isap = 0;
            if(self.GetParent<Tower>().GetComponent<LiquidFireSkill>() != null)
            {
                isap = self.GetParent<Tower>().GetComponent<LiquidFireSkill>().GetAP();
            }
            int damagerangeadd = 0;
            if(self.GetParent<Tower>().GetComponent<CombustionAidSkill>() != null)
            {
               damagerangeadd = self.GetParent<Tower>().GetComponent<CombustionAidSkill>().GetRangeAdd();
            }
            int lasttimeadd = 0;
            if(self.GetParent<Tower>().GetComponent<SunSpotSkill>() != null)
            {
                lasttimeadd = self.GetParent<Tower>().GetComponent<SunSpotSkill>().GetLastTimeAdd();
            }
            string param = "";
            if (self.GetParent<Tower>().GetComponent<FreezeFireSkill>() != null)
            {
                param = self.GetParent<Tower>().GetComponent<FreezeFireSkill>().GetParams();
            }
            UnitFactory.CreateMulRangeBullet(self.ZoneScene().CurrentScene(),
                    self.GetParent<Tower>(),
                    attackmonsterlist[0],
                    self.PrefabName,
                    self.FlySpeed,
                    self.param["damagerange"] * (100 + damagerangeadd) / 100,
                    self.param["damageinterval"],
                    self.param["lasttime"] + lasttimeadd,
                    isap,
                    100,
                    self.GetParent<Tower>().ExtraCoin, param).Coroutine();

        }
    }
}
