
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class GiantHunterSkillAwakeSystem : AwakeSystem<GiantHunterSkill>
    {
        public override void Awake(GiantHunterSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1016).Params);
            self.ContinuedTimer = 0;
            self.SkillTimer = 0;
            self.SkillTime = self.param["chargetime"];
            self.ContinuedTime = self.param["lasttime"];
            self.ExtraTargetCount = self.param["targetcount"];
            self.AttackMonster = null;
        }
    }
    [FriendClass(typeof(GiantHunterSkill))]
    [FriendClass(typeof(Tower))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Monster))]
    public static class GiantHunterSkillSystem
    {
        public static void OnLogic(this GiantHunterSkill self, int dt)
        {
            if(self.GetParent<Tower>().state == TowerState.SkillAttack)
            {
                self.ContinuedTimer = self.ContinuedTimer + dt;
                Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = 1.0f - (float)self.ContinuedTimer / (float)self.ContinuedTime }).Coroutine();
                if (self.ContinuedTimer >= self.ContinuedTime)
                {
                    self.GetParent<Tower>().state = TowerState.NormalAttack;
                    self.ContinuedTimer = 0;//持续时间归0
                }
            }
            else if(self.GetParent<Tower>().state == TowerState.NormalAttack)
            {
                self.SkillTimer = self.SkillTimer + dt;
                Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime }).Coroutine();
                if (self.SkillTimer >= self.SkillTime && self.GetParent<Tower>().AttackTargetList.Count > 0)
                {
                    self.GetParent<Tower>().state = TowerState.SkillAttack;
                    self.SkillTimer = 0;//充能时间归0
                }   
            }
        }
        public static void OnSkill(this GiantHunterSkill self)//放技能
        {
            List<Monster> allmonster = self.GetParent<Tower>().AttackTargetList;
            List<Monster> attackmonster = new List<Monster>();
            if (allmonster.Count > 0)
            {
                attackmonster.Add(allmonster[0]);
                allmonster.Remove(allmonster[0]);
                if(allmonster.Count > 1)
                {
                    if (!allmonster.Contains(self.AttackMonster))//如果跑出了范围就选择使attackmonster为null 方便下一个判断为空 添加新的怪
                    {
                        self.AttackMonster = null;
                    }
                    if (self.AttackMonster == null)
                    {
                        allmonster.Sort(Method);
                        self.AttackMonster = allmonster[0];
                        attackmonster.Add(self.AttackMonster);
                    }
                    else
                    {
                        if(self.AttackMonster.Hp > 0)
                        {
                            attackmonster.Add(self.AttackMonster);
                        }
                        if (self.AttackMonster.Hp == 0)//Hp为0选择新的目标
                        {
                            allmonster.Sort(Method);
                            self.AttackMonster = allmonster[0];
                            attackmonster.Add(self.AttackMonster);
                        }
                    }
                }             
                if (self.GetParent<Tower>().GetComponent<HaloSkill>() != null)
                {
                    BuffHelper.MonsterAddBuff(allmonster[0], self.GetParent<Tower>().GetComponent<HaloSkill>().GetParam()).Coroutine();
                    if(allmonster.Count > 1)
                    {
                        for (int i = 1; i < allmonster.Count; i++)
                        {
                            BuffHelper.MonsterRemoveBuff(allmonster[i], self.GetParent<Tower>().GetComponent<HaloSkill>().GetParam()).Coroutine();
                        }
                    }  
                }
            }
            for(int i=0;i<attackmonster.Count;i++)
            {
                Monster m = attackmonster[i];
                if (self.GetParent<Tower>().GetComponent<MeltSkill>() != null)
                {
                    BuffHelper.MonsterAddBuff(m, self.GetParent<Tower>().GetComponent<MeltSkill>().GetParam()).Coroutine();
                }
                int multiplier = 100;
                if (self.GetParent<Tower>().GetComponent<ReaperSkill>() != null)
                {
                    if ((float)m.Hp / (float)m.MaxHp <= (float)self.GetParent<Tower>().GetComponent<ReaperSkill>().GetHpLack() / 100.0f)
                    {
                        multiplier = self.GetParent<Tower>().GetComponent<ReaperSkill>().GetMultiplier();
                    }
                }
                if (i == 0)//第一个怪正常攻击
                {
                    DamageHelper.TowerSingleAttackMonster(self.ZoneScene().CurrentScene(),
                           self.GetParent<Tower>(),
                           m,
                           self.GetParent<Tower>().PhysicsAttack,
                           self.GetParent<Tower>().MagicAttack,
                           0,
                           multiplier, self.GetParent<Tower>().ExtraCoin).Coroutine();
                    BuffHelper.MonsterAddBuff(m, SkillConfigCategory.Instance.Get(1016).Params).Coroutine();
                }
                else
                {
                    DamageHelper.TowerSingleAttackMonster(self.ZoneScene().CurrentScene(),
                           self.GetParent<Tower>(),
                           m,
                           self.GetParent<Tower>().PhysicsAttack,
                           self.GetParent<Tower>().MagicAttack,
                           100,
                           multiplier, self.GetParent<Tower>().ExtraCoin).Coroutine();
                    BuffHelper.MonsterAddBuff(m, SkillConfigCategory.Instance.Get(1016).Params).Coroutine();
                }
            }
            Log.Debug(attackmonster.Count.ToString());
            Game.EventSystem.PublishAsync(new EventType.ChangeUnitAnimatorState() { currentscene = self.ZoneScene().CurrentScene(), entity = self.GetParent<Tower>(), AnimatorName = "Run" }).Coroutine();
            Game.EventSystem.PublishAsync(new EventType.TowerLaser() { currentscene = self.ZoneScene().CurrentScene(), tower = self.GetParent<Tower>(), monster = attackmonster, index = 1 }).Coroutine();
        }
        public static int Method(Monster a,Monster b)
        {
            if(b.Hp > a.Hp)
            {
                return 1;
            }
            else if(b.Hp == a.Hp)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
