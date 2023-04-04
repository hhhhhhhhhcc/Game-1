namespace ET
{
    public class LockVertigoBuffComponentAwakeSystem : AwakeSystem<LockVertigoBuffComponent>
    {
        public override void Awake(LockVertigoBuffComponent self)
        {
            self.BuffTimer = 0;
        }
    }
    [FriendClass(typeof(LockVertigoBuffComponent))]
    public static class LockVertigoBuffComponentSystem
    {
        public static void Init(this LockVertigoBuffComponent self,string param)
        {
            self.param = param;
            self.paramdict = SkillHelper.GetSkillString(param);
            self.BuffTime = self.paramdict["bufftime"];
        }
        public static void OnLogic(this LockVertigoBuffComponent self,int dt)
        {
            self.BuffTimer = self.BuffTimer + dt;
            if(self.BuffTimer >= self.BuffTime)
            {
                string newparam = "buff," + self.paramdict["2buff"].ToString() + ";bufftime," + self.paramdict["2bufftime"] + ";";
                BuffHelper.MonsterAddBuff(self.GetParent<Monster>(), newparam).Coroutine();
                self.Dispose();
            }
        }
    }
}
