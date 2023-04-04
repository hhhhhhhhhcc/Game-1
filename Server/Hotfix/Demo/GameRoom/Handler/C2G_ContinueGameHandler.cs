using System;
using System.Collections.Generic;
using System.Numerics;

namespace ET
{
    [FriendClass(typeof(GameRoomComponent))]
    public class C2G_ContinueGameHandler : AMActorLocationRpcHandler<Unit, C2G_ContinueGame, G2C_ContinueGame>
    {
        protected override async ETTask Run(Unit Unit, C2G_ContinueGame request, G2C_ContinueGame response, Action reply)
        {
            StartSceneConfig sceneconfig = StartSceneConfigCategory.Instance.GetBySceneName(Unit.DomainZone(), "Map1");
            M2G_GetRoomIndex M2G_GetRoomIndex = (M2G_GetRoomIndex)await MessageHelper.CallActor(sceneconfig.InstanceId, new G2M_GetRoomIndex() { });
            int roomindex = M2G_GetRoomIndex.RoomIndex;
            Unit.GetComponent<NumericComponent>().Set(NumericType.RoomIndex, roomindex);
            Unit.GetComponent<NumericComponent>().Set(NumericType.LevelId, request.LevelId);
            Unit.GetComponent<NumericComponent>().Set(NumericType.MatchMode, request.MatchMode);
            Unit.GetComponent<NumericComponent>().Set(NumericType.Frameid, 0);
            Unit.GetComponent<NumericComponent>().Set(NumericType.IsInMatch, 0);
            Unit.GetComponent<NumericComponent>().Set(NumericType.Position, 1);
            Scene scene = Unit.DomainScene();
            GameRoomComponent gameroomcomponent = scene.GetComponent<GameRoomComponent>();
            gameroomcomponent.roomstate[roomindex] = 1;
            List<int> chance = gameroomcomponent.NewChance(10000);
            gameroomcomponent.chance[roomindex] = chance;
            List<Unit> units = gameroomcomponent.Get(roomindex);
            units.Add(Unit);
            gameroomcomponent.Add(roomindex, units);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
