using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class G2M_GetRoomIndexHandler : AMActorRpcHandler<Scene, G2M_GetRoomIndex, M2G_GetRoomIndex>
    {
        protected override async ETTask Run(Scene scene, G2M_GetRoomIndex request, M2G_GetRoomIndex response, Action reply)
        {
            if(scene.SceneType != SceneType.Map)
            {
                response.Error = ErrorCode.ERR_RequestSceneTypeError;
                reply();
                return;
            }
            response.RoomIndex = scene.GetComponent<MatchComponent>().NextIndex();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
