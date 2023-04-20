using System.Collections.Generic;

namespace ET
{
    public class TowerFactoryAwakeSystem : AwakeSystem<TowerFactory>
    {
        public override void Awake(TowerFactory self)
        {

        }
    }
    [FriendClass(typeof(TowerFactory))]
    public static class TowerFactorySystem
    {
        public static void Init(this TowerFactory self, long TowerId,int configId, int number, int interval,  int zone,float TowerPx,float TowerPy,List<int> Talents,int optId,int opttype)
        {
            self.TowerId = TowerId;
            self.ConfigId = configId;
            self.Interval = interval;
            self.Zone = zone;
            self.Number = number;
            self.TowerPx = TowerPx;
            self.TowerPy = TowerPy;
            self.Talents = Talents;
            self.optId = optId;
            self.opttype = opttype;
            self.Timer = 0;
            if(opttype == (int)OptType.CreateTower)
            {
                Game.EventSystem.PublishAsync(new EventType.SettingTower()
                {
                    zonescene = self.ZoneScene(),
                    tower = null,
                    TowerId = 0,
                    invalid = false,
                    opttype = self.opttype,
                    optId = self.optId
                }).Coroutine();
                //抛出造塔事件
            };
            if (opttype == (int)OptType.UpTower)
            {
                Game.EventSystem.PublishAsync(new EventType.SettingTower()
                {
                    zonescene = self.ZoneScene(),
                    tower = null,
                    TowerId = 0,
                    invalid = false,
                    opttype = self.opttype,
                    optId = self.optId
                }).Coroutine();
                //抛出升级事件
            };
            if (opttype == (int)OptType.DeleteTower)
            {
                Game.EventSystem.PublishAsync(new EventType.SettingTower()
                {
                    zonescene = self.ZoneScene(),
                    tower = null,
                    TowerId = 0,
                    invalid = false,
                    opttype = self.opttype,
                    optId = self.optId
                }).Coroutine();
                //抛出升级事件
            };
            Log.Debug(self.TowerId.ToString());
        }
        public static async ETTask<bool> OnLogic(this TowerFactory self, int dt)
        {
            if(self.opttype == (int)OptType.CreateTower)
            {
                if (self.Number > 0)
                {
                    self.Timer = self.Timer + dt;
                    if (self.Timer >= self.Interval)
                    {
                        self.Timer = self.Timer - self.Interval;
                        self.Number--;
                        Tower tower = await UnitFactory.CreateTower(self.ZoneScene().CurrentScene(), self.ConfigId, self.TowerPx, self.TowerPy, self.Zone, self.TowerId, self.Talents);
                        Game.EventSystem.PublishAsync(new EventType.SettingTower()
                        {
                            zonescene = self.ZoneScene(),
                            tower = tower,
                            TowerId = self.TowerId,
                            invalid = true,
                            opttype = self.opttype,
                            optId = self.optId
                        }).Coroutine();
                    }
                    if (self.Number == 0) return true;
                }
            }
            if(self.opttype == (int)OptType.UpTower)
            {
                if(self.Number > 0)
                {
                    self.Timer = self.Timer + dt;
                    if(self.Timer >= self.Interval)
                    {
                        self.Timer = self.Timer - self.Interval;
                        self.Number--;
                        UnitFactory.UpTower(self.ZoneScene().CurrentScene(), self.TowerId, self.Talents);
                        Game.EventSystem.PublishAsync(new EventType.SettingTower()
                        {
                            zonescene = self.ZoneScene(),
                            tower = null,
                            TowerId = self.TowerId,
                            invalid = true,
                            opttype = self.opttype,
                            optId = self.optId
                        }).Coroutine();
                    }
                    if (self.Number == 0) return true;
                }
            }
            if(self.opttype == (int)OptType.DeleteTower)
            {
                if (self.Number > 0)
                {
                    self.Timer = self.Timer + dt;
                    if (self.Timer >= self.Interval)
                    {
                        self.Timer = self.Timer - self.Interval;
                        self.Number--;
                        UnitFactory.DeleteTower(self.ZoneScene().CurrentScene(), self.TowerId).Coroutine();
                        Game.EventSystem.PublishAsync(new EventType.SettingTower()
                        {
                            zonescene = self.ZoneScene(),
                            tower = null,
                            TowerId = self.TowerId,
                            invalid = true,
                            opttype = self.opttype,
                            optId = self.optId
                        }).Coroutine();
                    }
                    if (self.Number == 0) return true;
                }
            }
            await ETTask.CompletedTask;
            return false;

        }
    }
}
