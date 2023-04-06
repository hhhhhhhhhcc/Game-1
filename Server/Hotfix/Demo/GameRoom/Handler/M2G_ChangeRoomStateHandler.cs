using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(GameRoomComponent))]
    public class M2G_ChangeRoomStateHandler : AMActorRpcHandler<Scene, M2G_ChangeRoomState, G2M_ChangeRoomState>
    {
        protected override async ETTask Run(Scene scene, M2G_ChangeRoomState request, G2M_ChangeRoomState response, Action reply)
        {
            GameRoomComponent gameroomcomponent = scene.GetComponent<GameRoomComponent>();
            gameroomcomponent.roomstate.Add(request.RoomIndex, 1);
            List<int> chance = gameroomcomponent.NewChance(10000);
            gameroomcomponent.chance[request.RoomIndex] = chance;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
