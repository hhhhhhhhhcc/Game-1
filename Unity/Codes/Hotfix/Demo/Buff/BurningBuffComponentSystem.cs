using UnityEngine;

namespace ET
{
    public class BurningBuffComponentAwakeSystem : AwakeSystem<BurningBuffComponent>
    {
        public override void Awake(BurningBuffComponent self)
        {
            self.intervaltimer = 0;
            self.lasttimer = 0;
        }
    }
    public class BurningBuffComponentDestroySystem : DestroySystem<BurningBuffComponent>
    {
        public override void Destroy(BurningBuffComponent self)
        {
            
        }
    }
    [FriendClass(typeof(BurningBuffComponent))]
    public static class BurningBuffComponentSystem
    {
        public static void Init(this BurningBuffComponent self,string Extra)//重复添加 间隔时间不归0 总时间归0
        {
            self.param = SkillHelper.GetSkillString(Extra);
            self.lasttimer = 0;
        }
        public static async ETTask OnLogic(this BurningBuffComponent self,int dt)
        {
            self.intervaltimer = self.intervaltimer + dt;
            self.lasttimer = self.lasttimer + dt;
            if(self.intervaltimer >= self.intervaltime)
            {
                //造成伤害时间归0
                DamageHelper.BuffAttackMonster(self.ZoneScene().CurrentScene(), self.PhysicsDamage, self.MagicDamage, self.GetParent<Monster>(), 0).Coroutine();
                self.intervaltimer = 0;
            }
            if(self.lasttimer >= self.lasttime)
            {
                self.Dispose();
            }
            await ETTask.CompletedTask;
        }
    }
}
