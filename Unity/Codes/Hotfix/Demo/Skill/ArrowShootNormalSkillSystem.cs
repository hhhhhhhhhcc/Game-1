using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(Tower))]
    public class ArrowShootNormalSkillAwakeSystem : AwakeSystem<ArrowShootNormalSkill>
    {
        public override void Awake(ArrowShootNormalSkill self)
        {
            self.AttackIntervalTimer = 0;
            self.PrefabName = "Arrow";
            self.FlySpeed = 5;
            self.RemainAttackNumber = 0;
            self.RemainAttackLogic = 0;
            self.param = new Dictionary<string, int>();
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1001).Params);
        }
    }
    [FriendClass(typeof(ArrowShootNormalSkill))]
    [FriendClass(typeof(Tower))]
    public static class ArrowShootNormalSkillSystem
    {
        public static void OnLogic(this ArrowShootNormalSkill self, int dt)
        {
            self.AttackIntervalTimer = self.AttackIntervalTimer + dt;
            List<Monster> attacktargetlist = self.GetParent<Tower>().AttackTargetList;
            if (self.RemainAttackLogic > 0 && attacktargetlist.Count > 0)//例如两只箭延时攻击分开打
            {
                self.RemainAttackLogic--;
                if (self.RemainAttackLogic == 0)
                {
                    if (self.GetParent<Tower>().state == TowerState.NormalAttack)
                    {
                        self.Attack(attacktargetlist);
                    }
                    if (self.GetParent<Tower>().state == TowerState.SkillAttack)
                    {
                        SkillHelper.OnSkill(self.GetParent<Tower>());
                    }
                    self.RemainAttackNumber--;
                    if (self.RemainAttackNumber > 0)
                    {
                        self.RemainAttackLogic = 2;
                    }
                }
            }
            else
            {
                self.RemainAttackLogic = 0;
                self.RemainAttackNumber = 0;
            }
            if (self.AttackIntervalTimer >= self.GetParent<Tower>().AttackInterval)
            {
                if(attacktargetlist.Count > 0)
                {
                    /*self.Attack(attacktargetlist);//直接攻击
                        self.RemainAttackNumber = self.GetParent<Tower>().AttackNumber;//获得攻击数量
                        self.RemainAttackNumber--;//攻击数量--
                        if (self.RemainAttackNumber > 0)//若攻击了还大于0 则给延时攻击帧赋值为2 例如攻击两个 攻击了之后number = 1，logic = 2
                        {
                            self.RemainAttackLogic = 2;
                        }*/
                    self.RemainAttackNumber = 1;
                    self.RemainAttackLogic = 2;
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState()
                    {
                        currentscene = self.ZoneScene().CurrentScene(),
                        entity = self.GetParent<Tower>(),
                        AnimatorName = self.GetParent<Tower>().getanimatorname()
                    }).Coroutine();
                    self.AttackIntervalTimer = 0;//初始化攻击时间
                }
            }
        }
        public static void Attack(this ArrowShootNormalSkill self,List<Monster> attacktargetlist)
        {
            int ExtraMultiPlier = 0;
            if (SkillHelper.OnChance(self.GetParent<Tower>()))
            {
                ExtraMultiPlier = 100;
            }
            UnitFactory.CreateSingleBullet(self.ZoneScene().CurrentScene(),
                    self.GetParent<Tower>(),
                    attacktargetlist[0],
                    self.PrefabName,
                    self.FlySpeed,
                    0,
                    100 + ExtraMultiPlier,
                    self.GetParent<Tower>().ExtraCoin, SkillConfigCategory.Instance.Get(1001).Params).Coroutine();
            
        }
    }
}
