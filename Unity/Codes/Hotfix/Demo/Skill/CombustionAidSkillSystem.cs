namespace ET
{
    public class CombustionAidSkillAwakeSystem : AwakeSystem<CombustionAidSkill>
    {
        public override void Awake(CombustionAidSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1026).Params);
        }
    }
    [FriendClass(typeof(CombustionAidSkill))]
    public static class CombustionAidSkillSystem
    {
        public static int GetRangeAdd(this CombustionAidSkill self)
        {
            return self.param["damagerangeadd"];
        }
    }
}
