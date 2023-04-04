namespace ET
{
    [FriendClass(typeof(Tower))]
    public class HighTowerSkillAwakeSystem : AwakeSystem<HighTowerSkill>
    {
        public override void Awake(HighTowerSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1019).Params);
            self.GetParent<Tower>().AttackRange = self.GetParent<Tower>().AttackRange * (float)(100 + self.param["attackrangeadd"]) / 100.0f;
        }
    }

    public static class HighTowerSkillSystem
    {
        public static int GetAttackRangeAdd(this HighTowerSkill self)
        {
            return SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1019).Params)["attackrangeadd"];
        }
    }
}
