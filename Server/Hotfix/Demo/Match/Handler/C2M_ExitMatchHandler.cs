using System;

namespace ET
{
    public class C2M_ExitMatchHandler : AMActorLocationRpcHandler<Unit, C2M_ExitMatch, M2C_ExitMatch>
    {
        protected override async ETTask Run(Unit unit, C2M_ExitMatch request, M2C_ExitMatch response, Action reply)
        {
            Scene scene = unit.DomainScene();
            if(scene.SceneType != SceneType.Map)
            {
                response.Error = ErrorCode.ERR_RequestSceneTypeError;
                reply();
                return;
            }
            NumericComponent numeric = unit.GetComponent<NumericComponent>();
            if(numeric.GetAsInt(NumericType.IsInMatch) != 1)
            {
                response.Error = ErrorCode.ERR_IsInMatchError;
                reply();
                return;
            }
            MatchComponent matchcomponent = scene.GetComponent<MatchComponent>();
            if(matchcomponent.Contain(unit))
            {
                numeric.Set(NumericType.IsInMatch, 0);
                matchcomponent.Remove(unit);
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
