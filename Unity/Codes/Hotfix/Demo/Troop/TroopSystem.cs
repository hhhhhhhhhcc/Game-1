namespace ET
{
    [FriendClass(typeof(Troop))]
    public static class TroopSystem
    {
        public static void OnLogic(this Troop self,int dt)
        {
            self.AttackIntervalTimer = self.AttackIntervalTimer + dt;
            if(self.AttackIntervalTimer >= self.AttackInterval )
            {
                //攻击
                self.AttackIntervalTimer = 0;
            }
        }
    }
}
