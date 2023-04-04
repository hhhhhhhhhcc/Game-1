namespace ET
{
    public class MeltSkillAwakeSystem : AwakeSystem<MeltSkill>
    {
        public override void Awake(MeltSkill self)
        {
            self.param = SkillConfigCategory.Instance.Get(1018).Params;
        }
    }

    [FriendClass(typeof(MeltSkill))]
    public static class MeltSkillSystem
    {
        public static string GetParam(this MeltSkill self)
        {
            return self.param;
        }
    }
}
