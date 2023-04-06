using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(GameRoomComponent))]
    [ActorMessageHandler]
    public class C2G_AddGameRoomHandler : AMActorLocationHandler<Unit, C2G_AddGameRoom>
    {
        protected override async ETTask Run(Unit unit, C2G_AddGameRoom request)
        {
            NumericComponent component = unit.GetComponent<NumericComponent>();
            int roomIndex = component.GetAsInt(NumericType.RoomIndex);

            Scene scene = unit.DomainScene();
            GameRoomComponent gameroomcomponent = scene.GetComponent<GameRoomComponent>();
            if(!gameroomcomponent.roomstate.ContainsKey(roomIndex))//没有这个房间 游戏结束
            {
                NumericComponent numeric = unit.GetComponent<NumericComponent>();
                numeric.Set(NumericType.RoomIndex, 0);
                numeric.Set(NumericType.IsReadyGame, 0);
                numeric.Set(NumericType.IsStartGame, 0);
                numeric.Set(NumericType.IsInMatch, 0);
                numeric.Set(NumericType.Position, 0);
                numeric.Set(NumericType.GameMoney, 0);
                numeric.Set(NumericType.LevelId, 0);
                numeric.Set(NumericType.MatchMode, 0);
                await numeric.AddOrUpdateUnitCache(UnitHelper.GetUnitServerId(unit));
                StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), "Map1");
                await TransferHelper.Transfer(unit, startSceneConfig.InstanceId, startSceneConfig.Name);
            }
            else//存在房间
            {
                if (gameroomcomponent.roomstate[roomIndex] == 1)//房间存在还未开始
                {
                    gameroomcomponent.Add(roomIndex, unit);
                }
                else if (gameroomcomponent.roomstate[roomIndex] == 2)//房间存在已经开始
                {
                    gameroomcomponent.Add(roomIndex, unit);
                    NumericComponent num = unit.GetComponent<NumericComponent>();
                    num.Set(NumericType.GameMoney, 1000);
                    num.Set(NumericType.IsStartGame, 1);
                    num.Set(NumericType.Frameid, 0);
                    G2C_StartGame g2C_StartGame = new G2C_StartGame() { chance = gameroomcomponent.GetChance(roomIndex) };
                    MessageHelper.SendToClient(unit, g2C_StartGame);
                }
            }
        }
    }
}
