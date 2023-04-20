using System;
using System.Collections.Generic;
using UnityEngine;
namespace ET
{
 
    public class GameComponentAwakeSystem : AwakeSystem<GameComponent>
    {
        public override void Awake(GameComponent self)
        {
            self.AllEnemy = new List<Monster>();
            self.AllTower = new List<Tower>();
            self.AllBullet = new List<Bullet>();
            self.AllBase = new List<Base>();
            self.AllTroop = new List<Troop>();
            self.waves = new List<MonsterWaveConfig>();
            self.WaveNumber = new List<int>();
            self.wavedic = new Dictionary<int, List<MonsterWaveConfig>>();
            self.MonsterTime = new List<int>();
            self.MonsterId = new List<int>();
            self.NextOpts = new List<OptionEvent>();
            self.chance = new List<int>();
            self.currentchanceindex = 0;
            self.CurrentMonsterIndex = 0;
            self.MonsterTimer = 0;
            self.WaveInfoTimer = 0;
            self.LastFrameOpt = null;
            self.MoneyTimer = 0;
            self.FrameDt = 66;
            self.Frameid = 0;
            self.SingleGameModeState = true;
            self.MonsterNavs = new List<Vector3[]>();
            self.MonsterNavDict = new List<int[]>();
            self.IsViewNextWave = false;
        }
    }
    public class GameComponentDestroySystem : DestroySystem<GameComponent>
    {
        public override void Destroy(GameComponent self)
        {
            self.Destroy().Coroutine();
        }
    }
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Base))]
    [FriendClass(typeof(Tower))]
    public static class GameComponentSystem 
    {
        public static async ETTask InitLevel(this GameComponent self, int LevelId,int MatchMode)
        {
            LevelConfig levelConfig = LevelConfigCategory.Instance.Get(LevelId);
            self.MonsterWaveInterval = levelConfig.MonsterWaveInterval;
            self.LevelId = LevelId;
            self.MatchMode = MatchMode;
            MapConfig mapconfig = MapConfigCategory.Instance.Get(levelConfig.MapId);
            self.MonsterNavs = self.ZoneScene().CurrentScene().GetComponent<NavVectorComponent>().GetPosByMapName(mapconfig.MapName);
            self.MaxVisualX = mapconfig.MaxVisualX;
            self.MaxVisualY = mapconfig.MaxVisualY;
            self.RoadNumber = mapconfig.RoadNumber;
            self.waves = MonsterWaveConfigCategory.Instance.GetAllConfigByWaveCode(levelConfig.MonsterWaveCode);
            self.ListToDictionary();
            self.DictionaryToTimerMonster();
            self.AddComponent<PlayerSkillComponent>();
            await Game.EventSystem.PublishAsync(new EventType.ShowGameUI() { ZoneScene = self.ZoneScene(), MatchMode = MatchMode });
            await Game.EventSystem.PublishAsync(new EventType.ShowMapUI() { currentscene = self.ZoneScene().CurrentScene(), MapName = mapconfig.MapName });
        }
        public static void InitChance(this GameComponent self,List<int> chance)
        {
            self.chance = chance;
        }
        public static bool GetChance(this GameComponent self,int number)
        {
            if(number <= self.chance[self.currentchanceindex])
            {
                self.currentchanceindex++;
                return true;
            }
            return false;
        }
        public static void ListToDictionary(this GameComponent self)
        {
            for(int i=0;i<self.waves.Count;i++)
            {
                MonsterWaveConfig wave = self.waves[i];
                if(self.wavedic.TryGetValue(wave.Group,out List<MonsterWaveConfig> list))
                {
                    list.Add(wave);
                }
                else
                {
                    List<MonsterWaveConfig> lists = new List<MonsterWaveConfig>();
                    lists.Add(wave);
                    self.wavedic.Add(wave.Group, lists);
                }
            }
        }
        public static void DictionaryToTimerMonster(this GameComponent self)
        {
            int CurrentTime = 0;
            int maxTime = 0;
            for (int i = 1; i <= self.wavedic.Count; i++)//遍历游戏总波次的字典 2
            {
                CurrentTime = CurrentTime + self.MonsterWaveInterval[i - 1];
                //每一波的开始 用CurrentTime记录波次
                self.WaveNumber.Add(CurrentTime);
                List<MonsterWaveConfig> waves = self.wavedic[i];
                for (int j = 0; j < waves.Count; j++)//同一波的不同类型 龙,弓箭手 
                {
                    int TempTime = CurrentTime;
                    MonsterWaveConfig config = waves[j];
                    int Timing = config.Timing;
                    TempTime = TempTime + Timing;
                    for(int k = 0;k<config.MonsterNumber;k++)//不同类型的每个怪
                    {
                        self.MonsterTime.Add(TempTime);
                        self.MonsterId.Add(config.MonsterId);
                        self.MonsterNavDict.Add(config.RoadIndex);
                        if(k!=config.MonsterNumber-1)
                        {
                            TempTime = TempTime + config.MonsterInterval;
                        }
                    }
                    if (maxTime < TempTime) maxTime = TempTime;
                }
                CurrentTime = maxTime;
            }
            //排序
            for(int i=0;i<self.MonsterTime.Count;i++)
            {
                for(int j=0;j<self.MonsterTime.Count - 1;j++)
                {
                    if (self.MonsterTime[j] > self.MonsterTime[j+1])
                    {
                        int temp = self.MonsterTime[j];
                        self.MonsterTime[j] = self.MonsterTime[j+1];
                        self.MonsterTime[j + 1] = temp;
                        temp = self.MonsterId[j];
                        self.MonsterId[j] = self.MonsterId[j + 1];
                        self.MonsterId[j + 1] = temp;
                        int[] listtemp = self.MonsterNavDict[j];
                        self.MonsterNavDict[j] = self.MonsterNavDict[j + 1];
                        self.MonsterNavDict[j + 1] = listtemp;
                    }
                }
            }
            self.InitGame().Coroutine();
        }
        public static async ETTask InitGame(this GameComponent self)
        {
            self.GameEnding = true;
            if(self.MatchMode == 1)//单人一个基地
            {
                self.Base1 = await UnitFactory.CreateBase(self.ZoneScene().CurrentScene(), 1, 0);
            }
            if(self.MatchMode == 2)//双人两个基地
            {
                self.Base1 = await UnitFactory.CreateBase(self.ZoneScene().CurrentScene(), 1, 0);
                self.Base2 = await UnitFactory.CreateBase(self.ZoneScene().CurrentScene(), 2, self.RoadNumber - 1);
            }

            await ETTask.CompletedTask;
        }
        public static void RemoveTower(this GameComponent self,Tower tower)
        {
            if(self.AllTower.Contains(tower))
            {
                self.AllTower.Remove(tower);
            }
        }
        public static void RemoveBullet(this GameComponent self,Bullet bullet)
        {
            if (self == null) return;
            if(self.AllBullet.Contains(bullet))
            {
                self.AllBullet.Remove(bullet);
            }
        }
        public static void RemoveMonster(this GameComponent self,Monster monster)
        {
            if(self.AllEnemy.Contains(monster))
            {
                self.AllEnemy.Remove(monster);
            }
        }
        public static Base GetBaseByZone(this GameComponent self,int zone)
        {
            if (zone == 1) return self.Base1;
            if (zone == 2) return self.Base2;
            return null;
        }
        public static async ETTask WinGame(this GameComponent self,int winposition,int basehp)
        {
            try
            {
                int errorcode = await GameHelper.RequestWin(self.ZoneScene(),winposition,basehp);
                if (errorcode != ErrorCode.ERR_Success)
                {
                    Log.Error(errorcode.ToString());
                    return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }
        }
        public static async ETTask Destroy(this GameComponent self)
        {
            foreach (Monster monster in self.AllEnemy)
            {
                monster?.Dispose();
            }
            foreach (Tower tower in self.AllTower)
            {
                tower?.Dispose();
            }
            foreach (Base baseitem in self.AllBase)
            {
                baseitem?.Dispose();
            }
            self.AllEnemy.Clear();
            self.AllTower.Clear();
            self.AllBase.Clear();
            await ETTask.CompletedTask;
        }
        public static async void OnLogicCreateMonster(this GameComponent self,int dt)//帧同步出怪
        {
            self.MonsterTimer = self.MonsterTimer + dt;
            if(self.CurrentMonsterIndex <= self.MonsterTime.Count - 1)
            {
                if (self.MonsterTimer >= self.MonsterTime[self.CurrentMonsterIndex])
                {
                    //出怪
                    if (self.LevelId <= 100)//单人
                    {
                        if (self.GameEnding == false || self?.ZoneScene() == null) return;
                        for(int i = 0; i < self.MonsterNavDict[self.CurrentMonsterIndex].Length;i++)
                        {
                            await UnitFactory.CreateMonster(self.ZoneScene()?.CurrentScene(), self.MonsterId[self.CurrentMonsterIndex], IdGenerater.Instance.GenerateId(), self.MonsterNavDict[self.CurrentMonsterIndex][i] - 1, 1,false);
                        }
                    }
                    else
                    {
                        if (self.GameEnding == false || self?.ZoneScene() == null) return;
                        for (int i = 0; i < self.MonsterNavDict[self.CurrentMonsterIndex].Length; i++)
                        {
                            if(self.MonsterNavDict[self.CurrentMonsterIndex][i] / 2 < self.RoadNumber - 1 )
                            {
                                await UnitFactory.CreateMonster(self.ZoneScene()?.CurrentScene(), self.MonsterId[self.CurrentMonsterIndex], IdGenerater.Instance.GenerateId(), self.MonsterNavDict[self.CurrentMonsterIndex][i] - 1, 1,false);
                            }
                            else
                            {
                                await UnitFactory.CreateMonster(self.ZoneScene()?.CurrentScene(), self.MonsterId[self.CurrentMonsterIndex], IdGenerater.Instance.GenerateId(), self.MonsterNavDict[self.CurrentMonsterIndex][i] - 1, 2,false);
                            }
                        }
                    }
                    //end
                    self.CurrentMonsterIndex++;
                    self.OnLogicCreateMonster(0);
                }
            }
            else
            {
                if(self.MatchMode == 1 && self.AllEnemy.Count == 0 && self.GameEnding == true)
                {
                    self.GameEnding = false;
                    GameHelper.RequestWin(self.ZoneScene(), 1,self.Base1.Hp).Coroutine();
                }
            }
        }
        public static async ETTask OnLogicUpdate(this GameComponent self,LogicFrame frame)
        {
            
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent num = unit.GetComponent<NumericComponent>();
            int currentframeid = num.GetAsInt(NumericType.Frameid);

            if(frame.frameid < currentframeid)
            {
                return;
            }
            for (int i=0;i<frame.unsync_frames.Count;i++)
            {
                if(currentframeid > frame.unsync_frames[i].frameid)
                {
                    continue;
                }
                else if (frame.unsync_frames[i].frameid >= frame.frameid)
                {
                    break;
                }
                if(self.SingleGameModeState == false)
                {
                    self.OnHandlerLogicGameStateEvent(frame);
                    break;
                }
                self.OnHandlerLogicEvent(frame.unsync_frames[i]);
            }
            num.Set(NumericType.Frameid, frame.frameid);//同步到当前帧Id
            self.Frameid = frame.frameid;
            /*if (frame.unsync_frames.Count > 0)
            {
                self.LastFrameOpt = frame.unsync_frames[frame.unsync_frames.Count - 1];
                self.OnHandlerLogicEvent(self.LastFrameOpt);
            }
            else
            {
                self.LastFrameOpt = null;
            }*/
            await ETTask.CompletedTask;
        }
        public static void OnHandlerLogicGameStateEvent(this GameComponent self, LogicFrame frame)
        {
            for (int i = 0; i < frame.unsync_frames.Count; i++)
            {
                FrameOpts frameopt = frame.unsync_frames[i];
                for(int j=0;j<frameopt.opts.Count;j++)
                {
                    OptionEvent optevent = frameopt.opts[j];
                    if (optevent.optType == (int)OptType.ContinueSingleGameMode)
                    {
                        self.SingleGameModeState = true;
                    }
                }
            }
        }
        public static void OnLogicMonsterFactory(this GameComponent self,int dt)
        {
            self.ZoneScene().CurrentScene().GetComponent<MonsterFactoryComponent>().OnLogic(dt);
        }
        public static void OnLogicTowerFactory(this GameComponent self, int dt)
        {
            self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().OnLogic(dt);
        }
        public static void OnHandlerLogicEvent(this GameComponent self,FrameOpts frameopt)
        {
            if (self.GameEnding == false) return;
            //更新波次信息
            self.OnLogicUpdateWaveInfoToView(self.FrameDt);
            //子弹走路和伤害
            self.OnLogicBullet(self.FrameDt);
            //怪走路和buff
            self.OnLogicMonster(self.FrameDt);
            //怪物生成工厂
            self.OnLogicMonsterFactory(self.FrameDt);
            //塔生成工厂
            self.OnLogicTowerFactory(self.FrameDt);
            //塔发射子弹和充能
            self.OnLogicTower(self.FrameDt);
            //玩家技能发动和时间迭代
            self.OnLogicPlayerSkill(self.FrameDt);
            //玩家操作
            for(int i = 0; i < frameopt.opts.Count;i++)
            {
                self.OnHandlerPlayerControl(frameopt.opts[i]);
            }
            //怪生成
            self.OnLogicCreateMonster(self.FrameDt);
            //处理金币
            self.OnLogicMoney(self.FrameDt);
            //判断是否上传frameid
            self.OnLogicUpLoadFrameId();
        }
        public static void OnLogicPlayerSkill(this GameComponent self,int dt)
        {
            self.GetComponent<PlayerSkillComponent>().OnLogic(dt);
        }
        public static async void OnLogicMonster(this GameComponent self,int dt)
        {
            List<Monster> monsters = self.AllEnemy;
            for (int i = 0; i < monsters.Count; i++)
            {
                Monster monster = monsters[i];
                monster.OnLogic(dt);
            }
            await ETTask.CompletedTask;
        }
        public static async void OnLogicUpdateWaveInfoToView(this GameComponent self, int dt)//更新波次信息
        {
            self.WaveInfoTimer = self.WaveInfoTimer + dt;
            if (self.CurrentWaveNumber < self.WaveNumber.Count)
            {
                if (self.WaveInfoTimer >= self.WaveNumber[self.CurrentWaveNumber] - self.MonsterWaveInterval[self.CurrentWaveNumber] && self.WaveInfoTimer < self.WaveNumber[self.CurrentWaveNumber])//TimeLeft信息
                {
                    int Time = self.WaveNumber[self.CurrentWaveNumber] - self.WaveInfoTimer;
                    Game.EventSystem.PublishAsync(new EventType.GameUpdateTimeLeftInfo() { zonescene = self.ZoneScene(), Time = Time }).Coroutine();
                    if(self.IsViewNextWave == false)//上传一次怪物波次信息和显示一次直接下一波的按钮
                    {
                        self.IsViewNextWave = true;
                        (List<int> CurrentWaveAllMonsterConfigId, List<int> CurrentWaveAllMonsterRoadId) = self.GetCurrentWaveAllMonster();//获取当前波次所有怪物
                        Game.EventSystem.PublishAsync(new EventType.GameUpdateWaveInfo() { zonescene = self.ZoneScene(), CurrentWaveNumber = self.CurrentWaveNumber + 1, CurrentWaveAllMonsterConfigId = CurrentWaveAllMonsterConfigId, CurrentWaveAllMonsterRoadId = CurrentWaveAllMonsterRoadId }).Coroutine();
                    }
                }
                if(self.WaveInfoTimer >= self.WaveNumber[self.CurrentWaveNumber])
                {
                    self.CurrentWaveNumber++;
                    Game.EventSystem.PublishAsync(new EventType.GameUpdateTimeLeftInfo() { zonescene = self.ZoneScene(), Time = 0 }).Coroutine();
                    self.IsViewNextWave = false;
                }
            }
            else
            {
                Game.EventSystem.PublishAsync(new EventType.GameUpdateTimeLeftInfo() { zonescene = self.ZoneScene(), Time = 0 }).Coroutine();
            }
            
            await ETTask.CompletedTask;
        }
        public static (List<int>,List<int>) GetCurrentWaveAllMonster(this GameComponent self)//获取当前波次所有怪物
        {
            List<int> MonsterConfigId = new List<int>();
            List<int> MonsterRoadId = new List<int>();
            if(self.CurrentWaveNumber < self.WaveNumber.Count - 1)//前几波
            {
                int FormerTime = self.WaveNumber[self.CurrentWaveNumber];
                int NextTime = self.WaveNumber[self.CurrentWaveNumber + 1];
                for (int i = 0; i < self.MonsterTime.Count; i++)
                {
                    int currentmonstertime = self.MonsterTime[i];
                    if (FormerTime <= currentmonstertime && currentmonstertime < NextTime)
                    {
                        for(int j = 0; j < self.MonsterNavDict[i].Length;j++)
                        {
                            MonsterConfigId.Add(self.MonsterId[i]);
                            MonsterRoadId.Add(self.MonsterNavDict[i][j]);
                        }
                    }
                }
                return (MonsterConfigId, MonsterRoadId);
            }
            if (self.CurrentWaveNumber == self.WaveNumber.Count - 1)//最后一波
            {
                int FormerTime = self.WaveNumber[self.CurrentWaveNumber];
                int NextTime = 10000000;
                for (int i = 0; i < self.MonsterTime.Count; i++)
                {
                    int currentmonstertime = self.MonsterTime[i];
                    if (FormerTime <= currentmonstertime && currentmonstertime < NextTime)
                    {
                        for (int j = 0; j < self.MonsterNavDict[i].Length; j++)
                        {
                            MonsterConfigId.Add(self.MonsterId[i]);
                            MonsterRoadId.Add(self.MonsterNavDict[i][j]);
                        }
                    }
                }
                return (MonsterConfigId, MonsterRoadId);
            }
            return (null,null);
        }
        public static async void OnHandlerPlayerControl(this GameComponent self,OptionEvent option)
        {
            int opttype = option.optType;
            NumericComponent num = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>();
            int position = num.GetAsInt(NumericType.Position);
            int gamemoney = num.GetAsInt(NumericType.GameMoney);
            if(opttype == (int)OptType.PauseSingleGameMode)
            {
                self.SingleGameModeState = false;
            }
            if(opttype == (int)OptType.ContinueSingleGameMode)
            {
                self.SingleGameModeState = true;
            }
            if(opttype == (int)OptType.NextWave)
            {
                self.WaveInfoTimer = self.WaveNumber[self.CurrentWaveNumber];
                self.MonsterTimer = self.MonsterTime[self.CurrentMonsterIndex];
            }
            if(opttype == (int)OptType.CreateTower)//造塔
            {        
                if (option.position == position)//是自己买的
                {
                    int NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), option.TowerConfigId);
                    num.Set(NumericType.GameMoney, gamemoney - NeedMoney);
                }
                TowerFactory towerfactory = self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().AddChildWithId<TowerFactory>(IdGenerater.Instance.GenerateId());
                towerfactory.Init(option.TowerId, option.TowerConfigId, 1, 0, option.position, option.TowerX, option.TowerY, option.TalentIds,option.OptId,opttype = option.optType);
                self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().AddTowerFactory(towerfactory);
            }

            if (opttype == (int)OptType.UpTower)//升级塔
            {
                //TowerId optId  opttype
                if (option.position == position)//是自己买的
                {
                    Tower tower = self.ZoneScene().CurrentScene().GetComponent<TowerComponent>().GetChild<Tower>(option.TowerId);
                    int NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), tower.ConfigId + 1);
                    num.Set(NumericType.GameMoney, gamemoney - NeedMoney);
                }
                TowerFactory towerfactory = self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().AddChildWithId<TowerFactory>(IdGenerater.Instance.GenerateId());
                towerfactory.Init(option.TowerId, 0, 1, 132, option.position, 0,0, option.TalentIds, option.OptId,option.optType);
                self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().AddTowerFactory(towerfactory);
            }
            if (opttype == (int)OptType.DeleteTower)//卖塔
            {
                if (option.position == position)//是自己买的
                {
                    Log.Debug("123");
                    Tower tower = self.ZoneScene().CurrentScene().GetComponent<TowerComponent>().Get(option.TowerId);
                    int TowerConfigId = tower.ConfigId;
                    int level = (TowerConfigId - 1) % 3 + 1;
                    int allreturnmoney = 0;
                    int loss = 70;
                    if(tower.GetComponent<EcoMaterialSkill>() != null)
                    {
                        loss = 100 - tower.GetComponent<EcoMaterialSkill>().getsaleloss();
                    }
                    for(int i= TowerConfigId - level + 1;i<= TowerConfigId; i++)
                    {
                        int NeedMoney = SkillHelper.GetBuildLossMoney(self.ZoneScene(), i);
                        allreturnmoney = allreturnmoney + NeedMoney * loss /100;
                    }
                    num.Set(NumericType.GameMoney, gamemoney + allreturnmoney);
                }
                TowerFactory towerfactory = self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().AddChildWithId<TowerFactory>(IdGenerater.Instance.GenerateId());
                towerfactory.Init(option.TowerId, 0, 1, 132, option.position, 0, 0, option.TalentIds, option.OptId, option.optType);
                self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().AddTowerFactory(towerfactory);
            }
            if (opttype == (int)OptType.CreateMonster)//买怪
            {
                MonsterConfig monsterconfig = MonsterConfigCategory.Instance.Get(option.MonsterConfigId);
                if (option.position == position)//是自己买的
                {
                    int needmoney = monsterconfig.NeedMoney;
                    num.Set(NumericType.GameMoney, gamemoney - needmoney);
                }
                MonsterFactory monsterfactory = self.ZoneScene().CurrentScene().GetComponent<MonsterFactoryComponent>().AddChildWithId<MonsterFactory>(IdGenerater.Instance.GenerateId());
                FightItemConfig fightitemconfig = FightItemConfigCategory.Instance.Get(monsterconfig.MonsterConfigId);
                int number = fightitemconfig.PetNumber;
                int interval = fightitemconfig.PetInterval;
                monsterfactory.Init(option.MonsterConfigId, number, interval, option.MonsterRoadId - 1, 3 - option.position);
                self.ZoneScene().CurrentScene().GetComponent<MonsterFactoryComponent>().AddMonsterFactory(monsterfactory);
            }
            if (opttype == (int)OptType.ReleasePlayerSkill)
            {
                SkillHelper.ReleasePlayerSkill(self.ZoneScene().CurrentScene(), option.PlayerSkillId, option.PlayerSkillZone,(float)(option.PlayerSkillPosX/10000.0f), (float)(option.PlayerSkillPosY / 10000.0f), option.UnitIds);
            }
            await ETTask.CompletedTask;
        }
        public static async void OnLogicMoney(this GameComponent self,int dt)
        {
            self.MoneyTimer = self.MoneyTimer + dt;
            if (self.MoneyTimer >= 5000)
            {
                self.MoneyTimer = self.MoneyTimer - 5000;
                Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
                NumericComponent num = unit.GetComponent<NumericComponent>();
                num.Set(NumericType.GameMoney, num.GetAsInt(NumericType.GameMoney) + 1);
            }
            await ETTask.CompletedTask;
        }
        public static async void OnLogicTower(this GameComponent self,int dt)
        {
            List<Tower> towers = self.AllTower;
            for(int i=0;i<towers.Count;i++)
            {
                Tower tower = towers[i];
                tower.OnLogicUpdate(dt);
            }
            await ETTask.CompletedTask;
        }
        public static async void OnLogicBullet(this GameComponent self,int dt)
        {
            List<Bullet> bullets = self.AllBullet;
            for(int i=0;i<bullets.Count;i++)
            {
                Bullet bullet = bullets[i];
                bullet.OnLogic(dt);
            }
            await ETTask.CompletedTask;
        }
        public static async void OnLogicUpLoadFrameId(this GameComponent self)
        {
            if(self.Frameid % 2 == 0 )//10帧上传一次FrameId
            {
                UpLoadFrameId ulfid = new UpLoadFrameId() { frameid = self.Frameid };
                self.ZoneScene().GetComponent<SessionComponent>().Session.Send(ulfid);
            }
            await ETTask.CompletedTask;
        }
        public static void RestartSingleGame(this GameComponent self)
        {
            GameHelper.ContinueGame(self.ZoneScene(), self.LevelId, self.MatchMode).Coroutine();
            //gamecomponent重新生成
        }
        public static void NextSingleGame(this GameComponent self)
        {
            GameHelper.ContinueGame(self.ZoneScene(),self.LevelId + 1,self.MatchMode).Coroutine();
            //gamecomponent重新生成
        }
        public static void DisposeGame(this GameComponent self)
        {
            /*foreach (Tower tower in self.AllTower)
            {
                tower?.Dispose();
            }
            self.AllTower.Clear();
            foreach (Monster monster in self.AllEnemy)
            {
                monster?.Dispose();
            }
            self.AllEnemy.Clear();
            foreach (Bullet bullet in self.AllBullet)
            {
                bullet?.Dispose();
            }
            self.AllBullet.Clear();
            foreach (Base baseitem in self.AllBase)
            {
                baseitem?.Dispose();
            }
            self.AllBase.Clear();*/
            self.ZoneScene().CurrentScene().GetComponent<TroopComponent>().Dispose();
            self.ZoneScene().CurrentScene().GetComponent<MonsterComponent>().Dispose();
            self.ZoneScene().CurrentScene().GetComponent<TowerComponent>().Dispose();
            self.ZoneScene().CurrentScene().GetComponent<BulletComponent>().Dispose();
            self.ZoneScene().CurrentScene().GetComponent<BaseComponent>().Dispose();
            self.ZoneScene().CurrentScene().GetComponent<MonsterFactoryComponent>().Dispose();
            self.ZoneScene().CurrentScene().GetComponent<TowerFactoryComponent>().Dispose();
            self.ZoneScene().CurrentScene().GetComponent<NavVectorComponent>().Dispose();
        }
    }
}