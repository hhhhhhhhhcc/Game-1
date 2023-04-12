namespace ET
{
    public class MonsterFactoryAwakeSystem : AwakeSystem<MonsterFactory>
    {
        public override void Awake(MonsterFactory self)
        {
            
        }
    }
    [FriendClass(typeof(MonsterFactory))]
    public static class MonsterFactorySystem
    {
        public static void Init(this MonsterFactory self,int configId, int number, int interval, int navId, int zone)
        {
            self.ConfigId = configId;
            self.Interval = interval;
            self.NavId = navId;
            self.Zone = zone;
            self.Number = number;
            self.Timer = 0;
        }
        public static bool OnLogic(this MonsterFactory self,int dt)
        {
            if(self.Number > 0)
            {
                self.Timer = self.Timer + dt;
                if(self.Timer > self.Interval)
                {
                    self.Timer = self.Timer - self.Interval;
                    self.Number--;
                    UnitFactory.CreateMonster(self.ZoneScene().CurrentScene(), self.ConfigId, IdGenerater.Instance.GenerateId(), self.NavId, self.Zone).Coroutine();
                }
                if (self.Number == 0) return true;
            }
            return false;
        }
    }
}
