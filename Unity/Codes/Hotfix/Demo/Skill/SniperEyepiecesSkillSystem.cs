namespace ET
{
    [FriendClass(typeof(Tower))]
    public class SniperEyepiecesSkillAwakeSystem : AwakeSystem<SniperEyepiecesSkill>
    {
        public override void Awake(SniperEyepiecesSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1006).Params);
            self.GetParent<Tower>().AttackRange = self.GetParent<Tower>().AttackRange * (100 + self.param["attackrangeadd"]) / 100;
        }
    }

    public static class SniperEyepiecesSkillSystem
    {
        public static int GetAttackRangeAdd(this SniperEyepiecesSkill self)
        {
            return SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1006).Params)["attackrangeadd"];
        }
    }
}
