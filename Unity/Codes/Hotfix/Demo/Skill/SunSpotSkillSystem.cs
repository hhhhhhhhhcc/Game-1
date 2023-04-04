namespace ET
{
    public class SunSpotSkillAwakeSystem : AwakeSystem<SunSpotSkill>
    {
        public override void Awake(SunSpotSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1027).Params);
        }
    }
    [FriendClass(typeof(SunSpotSkill))]
    public static class SunSpotSkillSystem
    {
        public static int GetLastTimeAdd(this SunSpotSkill self)
        {
            return self.param["lasttimeadd"];
        }
    }
}
