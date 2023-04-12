using System;

namespace ET
{
    [Timer(TimerType.HallAutoGenerateMonster)]
    public class HallAutoGenerateMonsterTimer : ATimer<HallComponent>
    {
        public override void Run(HallComponent self)
        {
            UnitFactory.CreateMonster(self.ZoneScene().CurrentScene(), 6001, IdGenerater.Instance.GenerateId(), 0, 1).Coroutine();
        }
    }
    [Timer(TimerType.HallLogic)]
    public class HallLogicTimer : ATimer<HallComponent>
    {
        public override void Run(HallComponent self)
        {
            self.HallLogicEvent();
        }
    }
    [FriendClass(typeof(GameComponent))]
    public class HallComponentAwakeSystem : AwakeSystem<HallComponent>
    {
        public override void Awake(HallComponent self)
        {
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MonsterNavs = self.ZoneScene().CurrentScene().GetComponent<NavVectorComponent>().GetPosByMapName("Map0");
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(2000, TimerType.HallAutoGenerateMonster, self);
            self.HallLogicTimer = TimerComponent.Instance.NewRepeatedTimer(66, TimerType.HallLogic, self);
        }
    }
    public class HallComponentDestroySystem : DestroySystem<HallComponent>
    {
        public override void Destroy(HallComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = 0;
            TimerComponent.Instance.Remove(ref self.HallLogicTimer);
            self.HallLogicTimer = 0;
        }
    }

    public static class HallComponentSystem
    {
        public static void HallLogicEvent(this HallComponent self)
        {
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().OnLogicBullet(66);
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().OnLogicMonster(66);
            self.ZoneScene().CurrentScene().GetComponent<GameComponent>().OnLogicTower(66);
        }
    }
}
