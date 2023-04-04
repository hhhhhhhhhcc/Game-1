namespace ET
{
    public class TechnologicalBuildingSkillAwakeSystem : AwakeSystem<TechnologicalBuildingSkill>
    {
        public override void Awake(TechnologicalBuildingSkill self)
        {
            
        }
    }
    [FriendClass(typeof(TechnologicalBuildingSkill))]
    public static class TechnologicalBuildingSkillSystem
    {
        public static int getbuildloss(this TechnologicalBuildingSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1005).Params);
            return self.param["buildloss"];
        }
    }
}
