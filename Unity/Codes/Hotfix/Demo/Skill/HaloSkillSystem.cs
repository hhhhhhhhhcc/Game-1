namespace ET
{
    public class HaloSkillAwakeSystem : AwakeSystem<HaloSkill>
    {
        public override void Awake(HaloSkill self)
        {
            self.param = SkillConfigCategory.Instance.Get(1020).Params;
        }
    }
    [FriendClass(typeof(HaloSkill))]
    public static class HaloSkillSystem
    {
        public static string GetParam(this HaloSkill self)
        {
            return self.param;
        }
    }
}
