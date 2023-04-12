namespace ET
{
    public class InterferenceTowerSkillAwakeSystem : AwakeSystem<InterferenceTowerSkill>
    {
        public override void Awake(InterferenceTowerSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(6005).Params);
            self.Timer = 0;
            self.Time = self.param["time"];
        }
    }
    [FriendClass(typeof(Tower))]
    public class InterferenceTowerSkillDestroySystem : DestroySystem<InterferenceTowerSkill>
    {
        public override void Destroy(InterferenceTowerSkill self)
        {
            self.Tower.state = TowerState.NormalAttack;
        }
    }
    [FriendClass(typeof(InterferenceTowerSkill))]
    [FriendClass(typeof(Tower))]

    public static class InterferenceTowerSkillSystem
    {
        
        public static void InitTower(this InterferenceTowerSkill self,long TowerId)//towerid  位置X,Y
        {
            Tower tower = self.ZoneScene().CurrentScene().GetComponent<TowerComponent>().GetChild<Tower>(TowerId);
            self.Tower = tower;
            self.Tower.state = TowerState.Crotrol;
        }
        public static void InitZone(this InterferenceTowerSkill self,int Zone)
        {
            self.Zone = Zone;
        }
        public static void OnLogic(this InterferenceTowerSkill self,int dt)
        {
            self.Timer = self.Timer + dt;
            if (self.Timer >= self.Time)
            {
                self.Dispose();
            }
        }
    }
}
