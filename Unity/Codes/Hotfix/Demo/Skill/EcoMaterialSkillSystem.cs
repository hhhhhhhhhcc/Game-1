namespace ET
{
    public class EcoMaterialSkillAwakeSystem : AwakeSystem<EcoMaterialSkill>
    {
        public override void Awake(EcoMaterialSkill self)
        {
           
        }
    }
    [FriendClass(typeof(EcoMaterialSkill))]
    public static class EcoMaterialSkillSystem
    {
        public static int getsaleloss(this EcoMaterialSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1011).Params);
            return self.param["saleloss"];
        }
    }
}
