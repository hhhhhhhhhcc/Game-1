namespace ET
{
    public class EarthShakeSkillAwakeSystem : AwakeSystem<EarthShakeSkill>
    {
        public override void Awake(EarthShakeSkill self)
        {
            self.param = SkillConfigCategory.Instance.Get(1013).Params;
        }
    }
    [FriendClass(typeof(EarthShakeSkill))]
    public static class EarthShakeSkillSystem
    {
        public static string GetParams(this EarthShakeSkill self)
        {
            return self.param;
        }
    }
}
