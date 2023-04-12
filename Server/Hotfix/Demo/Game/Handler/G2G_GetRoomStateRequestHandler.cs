using System;

namespace ET
{
    [FriendClass(typeof(GameRoomComponent))]
    public class G2G_GetRoomStateRequestHandler : AMActorRpcHandler<Scene, G2G_GetRoomStateRequest, G2G_GetRoomStateResponse>
    {
        protected override async ETTask Run(Scene scene, G2G_GetRoomStateRequest request, G2G_GetRoomStateResponse response, Action reply)
        {
            int roomIndex = request.RoomIndex;
            if(scene.GetComponent<GameRoomComponent>().roomstate.ContainsKey(roomIndex))
            {
                response.RoomState = 1;
            }
            else
            {
                response.RoomState = 0;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
