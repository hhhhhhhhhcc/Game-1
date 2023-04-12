namespace ET
{
    public class TowerAddPropertiesSkillAwakeSystem : AwakeSystem<TowerAddPropertiesSkill>
    {
        public override void Awake(TowerAddPropertiesSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(6003).Params);
            self.Time = self.param["time"];
            self.Timer = 0; 
        }
    }
    [FriendClass(typeof(TowerAddPropertiesSkill))]
    public static class TowerAddPropertiesSkillSystem
    {
        public static void InitTower(this TowerAddPropertiesSkill self, long TowerId)//towerid  位置X,Y
        {
            Tower tower = self.ZoneScene().CurrentScene().GetComponent<TowerComponent>().GetChild<Tower>(TowerId);
            self.Tower = tower;
            //属性添加放在出了数据之后
        }
        public static void InitZone(this TowerAddPropertiesSkill self,int Zone)
        {
            self.Zone = Zone;
        }
        public static void OnLogic(this TowerAddPropertiesSkill self,int dt)
        {
            self.Timer = self.Timer + dt;
            if(self.Timer >= self.Time)
            {
                self.Dispose();
            }
        }
    }
}
