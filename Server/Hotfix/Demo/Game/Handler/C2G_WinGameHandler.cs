using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(LevelComponent))]
    [FriendClass(typeof(GameRoomComponent))]
    public class C2G_WinGameHandler : AMActorLocationRpcHandler<Unit, C2G_WinGame, G2C_WinGame>
    {
        protected override async ETTask Run(Unit unit, C2G_WinGame request, G2C_WinGame response, Action reply)
        {
            int basehp = request.BaseHp;
            int roomIndex = request.RoomIndex;
            int winposition = request.Position;
            Scene scene = unit.DomainScene();
            if (scene.GetComponent<GameRoomComponent>().roomstate.ContainsKey(roomIndex))
            {
                List<Unit> units = scene.GetComponent<GameRoomComponent>().Get(roomIndex);
                //奖励
                for (int i = 0; i < units.Count; i++)//输赢都清空了所有的数据
                {
                    G2C_ReturnWinGame g2C_ReturnWinGame = new G2C_ReturnWinGame();
                    Unit currentunit = units[i];
                    NumericComponent num = currentunit.GetComponent<NumericComponent>();
                    int LevelId = num.GetAsInt(NumericType.LevelId);
                    int unitposition = num.GetAsInt(NumericType.Position);
                    bool IsWin = false;
                    if (winposition == unitposition) IsWin = true;
                    //下发奖励
                    if (LevelId <= 1000)//单人模式
                    {
                        if(IsWin)//获胜
                        {
                            g2C_ReturnWinGame.IsWin = 1;//表示获胜
                            LevelComponent levelcomponent = currentunit.GetComponent<LevelComponent>();
                            int NewLevelData = 0;//根据基地血量获取星际
                            if (basehp >= 80) NewLevelData = 3;
                            else if (basehp >= 40) NewLevelData = 2;
                            else if (basehp > 0) NewLevelData = 1;
                            else if (basehp == 0) NewLevelData = 0;
                            if (LevelId <= levelcomponent.LevelData.Count)//当前大的关卡比总数少或者等于 说明是已经打过的关卡 levelid = 3 count = 4 老关卡
                            {
                                int LevelData = levelcomponent.LevelData[LevelId - 1];
                                if (NewLevelData >= LevelData)//新的大于老的替换星级
                                {
                                    levelcomponent.LevelData[LevelId - 1] = NewLevelData;
                                }
                            }
                            else//打的是最新的关卡  添加星级并且获取奖励
                            {
                                levelcomponent.LevelData.Add(NewLevelData);//添加星级
                                //根据当前关卡配置分发奖励
                                Dictionary<int,int> Rewards = RewardHelper.GetRewardByLevelId(LevelId);
                                foreach(int id in Rewards.Keys)
                                {
                                    int number = Rewards[id];
                                    g2C_ReturnWinGame.WinItemId.Add(id);
                                    g2C_ReturnWinGame.WinItemNumber.Add(number);
                                }
                                RewardHelper.AddReward(unit, g2C_ReturnWinGame.WinItemId, g2C_ReturnWinGame.WinItemNumber);
                            }
                            LevelHelper.AsycnLevelData(unit);//更新了星级
                        }
                        else//失败了没奖励但是要下发是否获胜
                        {
                            g2C_ReturnWinGame.IsWin = 2;
                        }
                    }
                    else if (LevelId >= 1001 && LevelId <= 2000)//双人对战
                    {
                        if (IsWin)
                        {
                            g2C_ReturnWinGame.IsWin = 1;//表示获胜
                        }
                        else
                        {
                            g2C_ReturnWinGame.IsWin = 2;//失败
                        }
                    }
                    num.Set(NumericType.RoomIndex, 0);
                    num.Set(NumericType.IsReadyGame, 0);
                    num.Set(NumericType.IsStartGame, 0);
                    num.Set(NumericType.IsInMatch, 0);
                    num.Set(NumericType.Position, 0);
                    num.Set(NumericType.GameMoney, 0);
                    num.Set(NumericType.LevelId, 0);
                    num.Set(NumericType.MatchMode, 0);
                    MessageHelper.SendToClient(currentunit, g2C_ReturnWinGame);
                    await num.AddOrUpdateUnitCache(UnitHelper.GetUnitServerId(currentunit));
                }
                scene.GetComponent<GameRoomComponent>().ClearRoomState(roomIndex);
                scene.GetComponent<GameRoomComponent>().ClearRoomUnit(roomIndex);
                scene.GetComponent<GameRoomComponent>().ClearLogicComponent(roomIndex);
                reply();
                return;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
