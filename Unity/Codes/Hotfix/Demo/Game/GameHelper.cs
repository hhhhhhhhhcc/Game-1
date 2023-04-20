﻿using ProtoBuf;
using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Tower))]
    public static class GameHelper
    {
        public static async void AddRoomIndex(Scene zonescene)
        {
            await zonescene.GetComponent<SessionComponent>().Session.Call(new C2G_AddGameRoom() { });
        }
        public static async ETTask<int> GetReadyGame(Scene zonescene)
        {
            G2C_GetReadyGame g2C_GetReadyGame = null;
            try
            {
                g2C_GetReadyGame = (G2C_GetReadyGame)await zonescene.GetComponent<SessionComponent>().Session.Call(new C2G_GetReadyGame() { });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }

            if (g2C_GetReadyGame.Error != ErrorCode.ERR_Success)
            {
                Log.Error(g2C_GetReadyGame.Error.ToString());
                return g2C_GetReadyGame.Error;
            }
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> CancelReadyGame(Scene zonescene)
        {
            G2C_CancelReadyGame g2C_CancelReadyGame = null;
            try
            {
                g2C_CancelReadyGame = (G2C_CancelReadyGame)await zonescene.GetComponent<SessionComponent>().Session.Call(new C2G_CancelReadyGame() { });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }

            if (g2C_CancelReadyGame.Error != ErrorCode.ERR_Success)
            {
                Log.Error(g2C_CancelReadyGame.Error.ToString());
                return g2C_CancelReadyGame.Error;
            }
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> CreateTower(Scene zonescene, int TowerConfigId, float PX, float PY,int optId)
        {
            FightItemComponent fightitemcomponent = zonescene.GetComponent<FightItemComponent>();
            List<int> TalentIds = fightitemcomponent.GetTowerTalentIdByConfigId(TowerConfigId);
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            NumericComponent num = UnitHelper.GetMyUnitFromCurrentScene(zonescene.CurrentScene()).GetComponent<NumericComponent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { position = num.GetAsInt(NumericType.Position), optType = (int)(OptType.CreateTower), TowerConfigId = TowerConfigId, TowerX = PX, TowerY = PY, TalentIds = TalentIds,OptId = optId };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> UpTower(Scene zonescene, long TowerId,int optId)
        {
            Tower tower = zonescene.CurrentScene().GetComponent<TowerComponent>().GetChild<Tower>(TowerId);
            FightItemComponent fightitemcomponent = zonescene.GetComponent<FightItemComponent>();
            List<int> TalentIds = fightitemcomponent.GetTowerTalentIdByConfigId(tower.ConfigId);
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            NumericComponent num = UnitHelper.GetMyUnitFromCurrentScene(zonescene.CurrentScene()).GetComponent<NumericComponent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { position = num.GetAsInt(NumericType.Position), optType = (int)(OptType.UpTower), TowerId = TowerId, TalentIds = TalentIds, OptId = optId };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> PauseSingleGameMode(Scene zonescene)
        {
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { optType = (int)(OptType.PauseSingleGameMode) };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> ContinueSingleGameMode(Scene zonescene)
        {
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { optType = (int)(OptType.ContinueSingleGameMode) };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> NextWaveSingleGameMode(Scene zonescene)
        {
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { optType = (int)(OptType.NextWave) };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> DeleteTower(Scene zonescene, long TowerId,int optId)
        {
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            NumericComponent num = UnitHelper.GetMyUnitFromCurrentScene(zonescene.CurrentScene()).GetComponent<NumericComponent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { position = num.GetAsInt(NumericType.Position), optType = (int)(OptType.DeleteTower), TowerId = TowerId,OptId = optId };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> CreateMonster(Scene zonescene, int MonsterConfigId,int MonsterRoadId)
        {
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            NumericComponent num = UnitHelper.GetMyUnitFromCurrentScene(zonescene.CurrentScene()).GetComponent<NumericComponent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { position = num.GetAsInt(NumericType.Position), optType = (int)(OptType.CreateMonster), MonsterConfigId = MonsterConfigId,MonsterRoadId = MonsterRoadId };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> ReleasePlayerSkill(Scene zonescene,int PlayerSkillId,int SkillZone,int PosX,int PosY,List<long> UnitIds)
        {
            NextFrameOpts nextframeopts = new NextFrameOpts();
            List<OptionEvent> opts = new List<OptionEvent>();
            NumericComponent num = UnitHelper.GetMyUnitFromCurrentScene(zonescene.CurrentScene()).GetComponent<NumericComponent>();
            int gameroomframeid = zonescene.CurrentScene().GetComponent<GameComponent>().Frameid;
            nextframeopts.frameid = gameroomframeid;
            OptionEvent opt = new OptionEvent() { position = num.GetAsInt(NumericType.Position), optType = (int)(OptType.ReleasePlayerSkill),PlayerSkillId = PlayerSkillId,PlayerSkillZone = SkillZone,PlayerSkillPosX = PosX,PlayerSkillPosY = PosY,UnitIds = UnitIds };
            opts.Add(opt);
            nextframeopts.opts = opts;
            zonescene.GetComponent<SessionComponent>().Session.Send(nextframeopts);
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> RequestWin(Scene zonescene,int position,int basehp)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(zonescene.CurrentScene());
            NumericComponent numeric = unit.GetComponent<NumericComponent>();
            int roomIndex = numeric.GetAsInt(NumericType.RoomIndex);
            Log.Debug(roomIndex.ToString());
            G2C_WinGame g2C_WinGame = null;
            try
            {
                g2C_WinGame = (G2C_WinGame)await zonescene.GetComponent<SessionComponent>().Session.Call(new C2G_WinGame()
                {
                    RoomIndex = roomIndex,
                    Position = position,
                    BaseHp = basehp
                });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }
            if (g2C_WinGame.Error != ErrorCode.ERR_Success)
            {
                Log.Error(g2C_WinGame.Error.ToString());
                return g2C_WinGame.Error;
            }
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> ExitGameAndEnterMainHome(Scene zonescene)
        {
            G2C_ExitGameAndEnterMainHome g2C_ExitGameAndEnterMainHome;
            try
            {
                g2C_ExitGameAndEnterMainHome = (G2C_ExitGameAndEnterMainHome)await zonescene.GetComponent<SessionComponent>().Session.Call(new C2G_ExitGameAndEnterMainHome(){});
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }
            if (g2C_ExitGameAndEnterMainHome.Error != ErrorCode.ERR_Success)
            {
                Log.Error(g2C_ExitGameAndEnterMainHome.Error.ToString());
                return g2C_ExitGameAndEnterMainHome.Error;
            }
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static async ETTask<int> ContinueGame(Scene zonescene,int LevelId,int MatchMode)//重新这一关或者下一关都调用这个接口
        {
            G2C_ContinueGame g2C_ContinueGame;
            try
            {
                g2C_ContinueGame = (G2C_ContinueGame)await zonescene.GetComponent<SessionComponent>().Session.Call(new C2G_ContinueGame() { LevelId = LevelId , MatchMode = MatchMode });
            }
            catch(Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }
            if (g2C_ContinueGame.Error != ErrorCode.ERR_Success)
            {
                Log.Error(g2C_ContinueGame.Error.ToString());
                return g2C_ContinueGame.Error;
            }
            zonescene.CurrentScene().GetComponent<GameComponent>().Dispose();
            await Game.EventSystem.PublishAsync(new EventType.HideMapUI() { currentscene = zonescene.CurrentScene() });
            InitGameComponent(zonescene.CurrentScene());
            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }
        public static void InitGameComponent(Scene currentScene)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(currentScene);
            currentScene.AddComponent<TroopComponent>();
            currentScene.AddComponent<MonsterComponent>();
            currentScene.AddComponent<TowerComponent>();
            currentScene.AddComponent<BaseComponent>();
            currentScene.AddComponent<BulletComponent>();
            currentScene.AddComponent<MonsterFactoryComponent>();
            currentScene.AddComponent<TowerFactoryComponent>();
            currentScene.AddComponent<NavVectorComponent>();
            NumericComponent UnitNumeric = unit.GetComponent<NumericComponent>();
            int LevelId = UnitNumeric.GetAsInt(NumericType.LevelId);
            int MatchMode = UnitNumeric.GetAsInt(NumericType.MatchMode);
            GameComponent gamecomponent = currentScene.AddComponent<GameComponent>();
            gamecomponent.InitLevel(LevelId, MatchMode).Coroutine();
        }
        public static void InitMainHomeComponent(Scene currentscene)
        {
            currentscene.AddComponent<NavVectorComponent>();
            currentscene.AddComponent<TowerComponent>();
            currentscene.AddComponent<MonsterComponent>();
            currentscene.AddComponent<BulletComponent>();
            currentscene.AddComponent<GameComponent>();
            currentscene.AddComponent<HallComponent>();
            UnitFactory.CreateTower(currentscene, 3001, 62400, 30000, 1, IdGenerater.Instance.GenerateId(), new List<int>()).Coroutine();
            UnitFactory.CreateTower(currentscene, 3004, 12700, 29000, 1, IdGenerater.Instance.GenerateId(), new List<int>()).Coroutine();
            UnitFactory.CreateTower(currentscene, 3007, 42700, 9300, 1, IdGenerater.Instance.GenerateId(), new List<int>()).Coroutine();
        }
    }
}
