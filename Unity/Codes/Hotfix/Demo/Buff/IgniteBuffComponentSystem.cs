namespace ET
{
    public class IgniteBuffComponentAwakeSystem : AwakeSystem<IgniteBuffComponent>
    {
        public override void Awake(IgniteBuffComponent self)
        {
            self.BuffIntervalTimer = 0;
            self.BuffTimer = 0;
        }
    }
    [FriendClass(typeof(IgniteBuffComponent))]
    public static class IgniteBuffComponentSystem
    {
         public static void Init(this IgniteBuffComponent self,string param)
         {
            self.param = SkillHelper.GetSkillString(param);
            self.BuffIntervalTime = self.param["damageinterval"];
            self.BuffTimer = 0;
            self.BuffTime = self.param["lasttime"];
            self.PhysicsAttack = self.param["physicsdamage"] * (100 - self.param["damagepercent"]) / 100;
            self.MagicAttack = self.param["magicdamage"] * (100 - self.param["damagepercent"]) / 100;
        }
        public static void OnLogic(this IgniteBuffComponent self,int dt)
        {
            self.BuffIntervalTimer = self.BuffIntervalTimer + dt;
            self.BuffTimer = self.BuffTimer + dt;
            if (self.BuffIntervalTimer >= self.BuffIntervalTime)
            {
                //造成伤害时间归0
                DamageHelper.BuffAttackMonster(self.ZoneScene().CurrentScene(), self.PhysicsAttack, self.MagicAttack, self.GetParent<Monster>(), 0).Coroutine();
                self.BuffIntervalTimer = 0;
            }
            if (self.BuffTimer >= self.BuffTime)
            {
                self.Dispose();
            }
        }
    }
}
