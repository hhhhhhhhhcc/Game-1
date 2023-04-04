namespace ET
{
    public class LiquidFireAwakeSystem : AwakeSystem<LiquidFireSkill>
    {
        public override void Awake(LiquidFireSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1025).Params);
        }
    }
    [FriendClass(typeof(LiquidFireSkill))]
    public static class LiquidFireSkillSystem
    {
        public static int GetAP(this LiquidFireSkill self)
        {
            return self.param["isap"];
        }
    }
}
