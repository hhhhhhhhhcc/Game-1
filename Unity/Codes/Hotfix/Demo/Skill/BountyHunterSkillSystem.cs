namespace ET
{
    [FriendClass(typeof(Tower))]
    public class BountyHunterSkillAwakeSystem : AwakeSystem<BountyHunterSkill>
    {
        public override void Awake(BountyHunterSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1004).Params);
            self.GetParent<Tower>().ExtraCoin = self.GetParent<Tower>().ExtraCoin + self.param["killcoin"];
        }
    }

    public static class BountyHunterSkillSystem
    {

    }
}
