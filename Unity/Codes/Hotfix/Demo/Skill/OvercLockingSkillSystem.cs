namespace ET
{
    [FriendClass(typeof(Tower))]
    public class OvercLockingSkillAwakeSystem : AwakeSystem<OvercLockingSkill>
    {
        public override void Awake(OvercLockingSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1012).Params);
            self.GetParent<Tower>().AttackInterval = self.GetParent<Tower>().AttackInterval / (100 + self.param["attackspeedadd"]) * 100;
        }
    }

    public static class OvercLockingSkillSystem
    {
    }
}
