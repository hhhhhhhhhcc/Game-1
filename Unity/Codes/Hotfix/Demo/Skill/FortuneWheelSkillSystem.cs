
namespace ET
{
    public class FortuneWheelSkillAwakeSystem : AwakeSystem<FortuneWheelSkill>
    {
        public override void Awake(FortuneWheelSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1007).Params);
        }
    }

    [FriendClass(typeof(FortuneWheelSkill))]
    public static class FortuneWheelSkillSystem
    {
        public static bool OnChance(this FortuneWheelSkill self)
        {
            return self.ZoneScene().CurrentScene().GetComponent<GameComponent>().GetChance(self.param["doublechance"]);
        }
    }
}
