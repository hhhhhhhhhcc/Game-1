using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(Tower))]
    public class LaserShootNormalSkillAwakeSystem : AwakeSystem<LaserShootNormalSkill>
    {
        public override void Awake(LaserShootNormalSkill self)
        {
            self.AttackInterval = self.GetParent<Tower>().AttackInterval;
            self.AttackIntervalTimer = 0;
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1015).Params);
        }
    }
    [FriendClass(typeof(Tower))]
    public class LaserShootNormalSkillUpdateSystem : UpdateSystem<LaserShootNormalSkill>
    {
        public override void Update(LaserShootNormalSkill self)
        {
            if(self.GetParent<Tower>().state == TowerState.NormalAttack)
            {
                int AttackNumber = self.GetParent<Tower>().AttackNumber;
                List<Monster> AttackTargetList = self.GetParent<Tower>().AttackTargetList;
                self.UpdateLaser(AttackNumber, AttackTargetList);
            }
        }
    }

    [FriendClass(typeof(LaserShootNormalSkill))]
    [FriendClass(typeof(Tower))]
    [FriendClass(typeof(Monster))]
    public static class LaserShootNormalSkillSystem
    {
        public static void OnLogic(this LaserShootNormalSkill self, int dt)
        {
            self.AttackIntervalTimer = self.AttackIntervalTimer + dt;
            int AttackNumber = self.GetParent<Tower>().AttackNumber;
            List<Monster> AttackTargetList = self.GetParent<Tower>().AttackTargetList;
            self.Attack(AttackNumber, AttackTargetList);
        }
        public static async void Attack(this LaserShootNormalSkill self,int AttackNumber,List<Monster> AttackTargetList)
        {
            if (AttackTargetList.Count <= 0)//攻击列表没怪
            { 
                return;
            }
            else
            {
                if (self.AttackIntervalTimer >= self.AttackInterval)//激光直接攻击
                {
                    if(self.GetParent<Tower>().state == TowerState.NormalAttack)
                    {
                        List<Monster> attackmonsterlist = new List<Monster>();
                        if (AttackNumber >= AttackTargetList.Count)//攻击数量大于等于总数则全攻击
                        {
                            attackmonsterlist = AttackTargetList;
                        }
                        else//攻击数量小于总数则部分攻击
                        {
                            for (int i = 0; i < AttackNumber; i++)
                            {
                                attackmonsterlist.Add(AttackTargetList[i]);
                            }
                        }    
                        for (int i = 0; i < attackmonsterlist.Count; i++)
                        {
                            if (self.GetParent<Tower>().GetComponent<MeltSkill>() != null)
                            {
                                BuffHelper.MonsterAddBuff(attackmonsterlist[i], self.GetParent<Tower>().GetComponent<MeltSkill>().GetParam()).Coroutine();
                            }
                            int multiplier = self.param["multiplier"];
                            if(self.GetParent<Tower>().GetComponent<ReaperSkill>() != null)
                            {
                                if ((float)attackmonsterlist[i].Hp / (float)attackmonsterlist[i].MaxHp <= (float)self.GetParent<Tower>().GetComponent<ReaperSkill>().GetHpLack() / 100.0f)
                                {
                                    multiplier = self.GetParent<Tower>().GetComponent<ReaperSkill>().GetMultiplier();
                                }
                            }
                            DamageHelper.TowerSingleAttackMonster(self.ZoneScene().CurrentScene(),
                                self.GetParent<Tower>(),
                                attackmonsterlist[i],
                                self.GetParent<Tower>().PhysicsAttack,
                                self.GetParent<Tower>().MagicAttack,
                                self.param["isap"],
                                multiplier, self.GetParent<Tower>().ExtraCoin).Coroutine();
                        }
                    }
                    else
                    {
                        SkillHelper.OnSkill(self.GetParent<Tower>());
                    }
                    self.AttackIntervalTimer = 0;//初始化攻击时间
                }
                if(self.GetParent<Tower>().GetComponent<HaloSkill>() != null)
                {
                    BuffHelper.MonsterAddBuff(AttackTargetList[0], self.GetParent<Tower>().GetComponent<HaloSkill>().GetParam()).Coroutine();
                    for(int i = 1; i < AttackTargetList.Count;i++)
                    {
                        BuffHelper.MonsterRemoveBuff(AttackTargetList[i], self.GetParent<Tower>().GetComponent<HaloSkill>().GetParam()).Coroutine();
                    }
                }
            }
            await ETTask.CompletedTask;
        }
        public static void UpdateLaser(this LaserShootNormalSkill self, int AttackNumber, List<Monster> AttackTargetList)
        {
            if (AttackTargetList.Count <= 0)//攻击列表没怪
            {
                Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Tower>(), AnimatorName = "Idle" }).Coroutine();
                Game.EventSystem.PublishAsync(new EventType.TowerLaser() { currentscene = self.ZoneScene().CurrentScene(), tower = self.GetParent<Tower>(), monster = null, index = 2 }).Coroutine();
                return;
            }
            else
            {
                if (self.GetParent<Tower>().state == TowerState.NormalAttack)
                {
                    List<Monster> attackmonsterlist = new List<Monster>();
                    if (AttackNumber >= AttackTargetList.Count)//攻击数量大于等于总数则全攻击
                    {
                        attackmonsterlist = AttackTargetList;
                    }
                    else//攻击数量小于总数则部分攻击
                    {
                        for (int i = 0; i < AttackNumber; i++)
                        {
                            attackmonsterlist.Add(AttackTargetList[i]);
                        }
                    }
                    Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Tower>(), AnimatorName = "Run" }).Coroutine();
                    Game.EventSystem.PublishAsync(new EventType.TowerLaser() { currentscene = self.ZoneScene().CurrentScene(), tower = self.GetParent<Tower>(), monster = attackmonsterlist, index = 1 }).Coroutine();
                }
            }
        }
    }
}
