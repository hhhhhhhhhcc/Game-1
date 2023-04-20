using JetBrains.Annotations;
using System.Collections.Generic;

namespace ET
{
    public class CanisterSkillAwakeSystem : AwakeSystem<CanisterSkill>
    {
        public override void Awake(CanisterSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1002).Params);
            self.SkillTime = self.param["chargetime"];
            self.FlySpeed = 5;
            self.PrefabName = "Arrow";
        }
    }

    [FriendClass(typeof(CanisterSkill))]
    [FriendClass(typeof(Tower))]
    public static class CanisterSkillSystem
    {
        public static void OnLogic(this CanisterSkill self,int dt)
        {
            self.SkillTimer = self.SkillTimer + dt;
            Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime }).Coroutine();
            if (self.SkillTimer >= self.SkillTime)
            {
                self.GetParent<Tower>().state = TowerState.SkillAttack;
            }
        }
        public static void OnSkill(this CanisterSkill self)//放技能
        {
            List<Monster> targetmonster = self.GetParent<Tower>().AttackTargetList;
            List<Monster> attackmonster = new List<Monster>();

            int attacknumber = self.param["targetconut"];
            if(attacknumber >= targetmonster.Count)//攻击数量大于总数 全体攻击
            {
                attackmonster = targetmonster;
            }
            else
            {
                for(int i=0;i<attacknumber;i++)
                {
                    attackmonster.Add(targetmonster[i]);
                }
            }
            for(int i=0;i<attackmonster.Count;i++)
            {
                int ExtraMultiPlier = 0;
                if (SkillHelper.OnChance(self.GetParent<Tower>()))
                {
                    ExtraMultiPlier = 100;
                }
                UnitFactory.CreateSingleBullet(self.ZoneScene().CurrentScene(),
                    self.GetParent<Tower>(),
                    attackmonster[i],
                    self.PrefabName,
                    self.FlySpeed,
                    0,
                    100 + ExtraMultiPlier,
                    self.GetParent<Tower>().ExtraCoin, SkillConfigCategory.Instance.Get(1002).Params).Coroutine();
            }
            attackmonster.Clear();
            self.SkillTimer = 0;
            self.GetParent<Tower>().state = TowerState.NormalAttack;
        }
    }

}
