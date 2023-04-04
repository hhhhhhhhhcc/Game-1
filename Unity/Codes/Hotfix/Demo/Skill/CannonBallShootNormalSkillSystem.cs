using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(Tower))]
    public class CannonBallShootNormalSkillAwakeSystem : AwakeSystem<CannonBallShootNormalSkill>
    {
        public override void Awake(CannonBallShootNormalSkill self)
        {
            self.AttackInterval = self.GetParent<Tower>().AttackInterval;
            self.AttackIntervalTimer = 0;
            self.PrefabName = "Bullet2";
            self.FlySpeed = 5;
            self.RemainAttackNumber = 0;
            self.RemainAttackLogic = 0;
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1008).Params);
            self.BuffId = 0;
        }
    }
    [FriendClass(typeof(CannonBallShootNormalSkill))]
    [FriendClass(typeof(Tower))]
    public static class CannonBallShootNormalSkillSystem
    {
        public static void OnLogic(this CannonBallShootNormalSkill self, int dt)
        {
            self.AttackIntervalTimer = self.AttackIntervalTimer + dt;
            List<Monster> attacktargetlist = self.GetParent<Tower>().AttackTargetList;
            if (self.RemainAttackLogic > 0 && attacktargetlist.Count > 0)//例如两只箭延时攻击分开打
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
            else
            {
                self.RemainAttackNumber = 0;
                self.RemainAttackLogic = 0;
            }
            if (self.AttackIntervalTimer >= self.AttackInterval)
            {
                if (attacktargetlist.Count > 0)
                {
                    if (self.GetParent<Tower>().state == TowerState.NormalAttack)
                    {
                        self.AttackIntervalTimer = 0;//初始化攻击时间
                        self.Attack(attacktargetlist);//直接攻击
                        self.RemainAttackNumber = self.GetParent<Tower>().AttackNumber;//获得攻击数量
                        self.RemainAttackNumber--;//攻击数量--
                        if (self.RemainAttackNumber > 0)//若攻击了还大于0 则给延时攻击帧赋值为2 例如攻击两个 攻击了之后number = 1，logic = 2
                        {
                            self.RemainAttackLogic = 2;
                        }
                    }
                    else if (self.GetParent<Tower>().state == TowerState.SkillAttack)
                    {
                        SkillHelper.OnSkill(self.GetParent<Tower>());
                    }
                    self.AttackIntervalTimer = 0;//初始化攻击时间
                }
            }
            SkillHelper.LogicAddBuff(self.GetParent<Tower>());
        }
        public static void Attack(this CannonBallShootNormalSkill self,List<Monster> attacktargetlist)
        {
            string allparams = "";
            if (self.GetParent<Tower>().GetComponent<EarthShakeSkill>() != null)
            {
                allparams = allparams + SkillConfigCategory.Instance.Get(1013).Params;
            }
            UnitFactory.CreateRangeBullet(self.ZoneScene().CurrentScene(),
                    self.GetParent<Tower>(),
                    attacktargetlist[0],
                    self.PrefabName,
                    self.FlySpeed,
                    self.param["damagerange"],
                    0,
                    100,
                    self.GetParent<Tower>().ExtraCoin, allparams).Coroutine();

        }
    }
}
