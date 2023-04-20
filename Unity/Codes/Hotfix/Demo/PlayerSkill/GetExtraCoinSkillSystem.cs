namespace ET
{
    public class GetExtraCoinSkillComponentAwakeSystem : AwakeSystem<GetExtraCoinSkill>
    {
        public override void Awake(GetExtraCoinSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(6004).Params);
            self.Time = self.param["time"];
            self.Timer = 0;
        }
    }

    [FriendClass(typeof(GetExtraCoinSkill))]
    public static class GetExtraCoinSkillSystem 
    {
        public static int GetExtraCoin(this GetExtraCoinSkill self)
        {
            if (UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position) == self.Zone)
            {
                return self.param["extracoin"];
            }
            return 0;
        }
        public static void InitZone(this GetExtraCoinSkill self,int Zone)
        {
            self.Zone = Zone;
        }
        public static void OnLogic(this GetExtraCoinSkill self, int dt)
        {
            self.Timer = self.Timer + dt;
            if (self.Timer >= self.Time)
            {
                self?.Dispose();
            }
        }
    }
}
