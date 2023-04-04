namespace ET
{
    public class FreezeFireSkillAwakeSystem : AwakeSystem<FreezeFireSkill>
    {
        public override void Awake(FreezeFireSkill self)
        {
            self.param = SkillConfigCategory.Instance.Get(1028).Params;
        }
    }
    [FriendClass(typeof(FreezeFireSkill))]
    public static class FreezeFireSkillSystem
    {
        public static string GetParams(this FreezeFireSkill self)
        {
            return self.param;
        }
    }
}
