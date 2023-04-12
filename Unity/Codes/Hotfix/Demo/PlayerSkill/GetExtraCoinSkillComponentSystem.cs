namespace ET
{
    public class GetExtraCoinSkillComponentAwakeSystem : AwakeSystem<GetExtraCoinSkillComponent>
    {
        public override void Awake(GetExtraCoinSkillComponent self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(6004).Params);
            self.Time = self.param["time"];
            self.Timer = 0;
        }
    }

    [FriendClass(typeof(GetExtraCoinSkillComponent))]
    public static class GetExtraCoinSkillComponentSystem 
    {
        public static int GetExtraCoin(this GetExtraCoinSkillComponent self)
        {
            if (UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Position) == self.Zone)
            {
                return self.param["ExtraCoin"];
            }
            return 0;
        }
        public static void InitZone(this GetExtraCoinSkillComponent self,int Zone)
        {
            self.Zone = Zone;
        }
        public static void OnLogic(this GetExtraCoinSkillComponent self, int dt)
        {
            self.Timer = self.Timer + dt;
            if (self.Timer >= self.Time)
            {
                self.Dispose();
            }
        }
    }
}
