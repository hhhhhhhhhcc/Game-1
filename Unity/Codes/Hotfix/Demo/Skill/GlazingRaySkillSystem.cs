using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class GlazingRaySkillAwakeSystem : AwakeSystem<GlazingRaySkill>
    {
        public override void Awake(GlazingRaySkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1017).Params);
            self.SkillTime = self.param["chargetime"];
            self.SkillTimer = 0;
        }
    }
    [FriendClass(typeof(GlazingRaySkill))]
    [FriendClass(typeof(Tower))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Monster))]
    public static class GlazingRaySkillSystem
    {
        public static void OnLogic(this GlazingRaySkill self, int dt)
        {
            self.SkillTimer = self.SkillTimer + dt;
            Game.EventSystem.PublishAsync(new EventType.TowerChargeBar() { tower = self.GetParent<Tower>(), SizeX = (float)self.SkillTimer / (float)self.SkillTime }).Coroutine();
            if (self.SkillTimer >= self.SkillTime)
            {
                self.GetParent<Tower>().state = TowerState.SkillAttack;
            }    
        }
        public static void OnSkill(this GlazingRaySkill self)
        {
            float targetrange = (float)(self.param["targetrange"]);
            List<Monster> effectmonster = new List<Monster>();
            effectmonster.Add(self.GetParent<Tower>().AttackTargetList[0]);
            List<Monster> allmonster = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().AllEnemy;
            foreach(Monster monster in allmonster)
            {
                if (monster != self.GetParent<Tower>().AttackTargetList[0])
                {
                     float distance = Vector2.Distance(self.GetParent<Tower>().AttackTargetList[0].Position, monster.Position);
                     if(distance <= targetrange / 1000.0f)
                     {
                        effectmonster.Add(monster);
                     }
                }
            }
            string newparams = SkillConfigCategory.Instance.Get(1017).Params + "physicsdamage," + self.GetParent<Tower>().PhysicsAttack.ToString() + ";magicdamage," + self.GetParent<Tower>().MagicAttack.ToString() + ";";
            foreach (Monster monster in effectmonster)
            {
                BuffHelper.MonsterAddBuff(monster, newparams).Coroutine();
            }
            self.GetParent<Tower>().state = TowerState.NormalAttack;
            self.SkillTimer = 0;
        }
    }
}
