using System;
using System.Collections.Generic;
using System.Numerics;

namespace ET
{
    [FriendClass(typeof(GameRoomComponent))]
    public class C2G_ContinueGameHandler : AMActorLocationRpcHandler<Unit, C2G_ContinueGame, G2C_ContinueGame>
    {
        protected override async ETTask Run(Unit unit, C2G_ContinueGame request, G2C_ContinueGame response, Action reply)
        {
            StartSceneConfig sceneconfig = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), "Map1");
            M2G_GetRoomIndex M2G_GetRoomIndex = (M2G_GetRoomIndex)await MessageHelper.CallActor(sceneconfig.InstanceId, new G2M_GetRoomIndex() { });
            int roomindex = M2G_GetRoomIndex.RoomIndex;
            unit.GetComponent<NumericComponent>().Set(NumericType.RoomIndex, roomindex);
            unit.GetComponent<NumericComponent>().Set(NumericType.LevelId, request.LevelId);
            unit.GetComponent<NumericComponent>().Set(NumericType.MatchMode, request.MatchMode);
            unit.GetComponent<NumericComponent>().Set(NumericType.Frameid, 0);
            unit.GetComponent<NumericComponent>().Set(NumericType.IsInMatch, 0);
            unit.GetComponent<NumericComponent>().Set(NumericType.Position, 1);
            Scene scene = unit.DomainScene();
            GameRoomComponent gameroomcomponent = scene.GetComponent<GameRoomComponent>();
            gameroomcomponent.roomstate[roomindex] = 1;
            List<int> chance = gameroomcomponent.NewChance(10000);
            gameroomcomponent.chance[roomindex] = chance;
            gameroomcomponent.Add(roomindex, unit);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
