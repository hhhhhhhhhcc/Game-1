
namespace ET
{
    public class ReaperSkillAwakeSystem : AwakeSystem<ReaperSkill>
    {
        public override void Awake(ReaperSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1021).Params);
        }
    }
    [FriendClass(typeof(ReaperSkill))]
    public static class ReaperSkillSystem
    {
        public static int GetHpLack(this ReaperSkill self)
        {
            return self.param["hplack"];
        }
        public static int GetMultiplier(this ReaperSkill self)
        {
            return self.param["multiplier"];
        }
    }
}
