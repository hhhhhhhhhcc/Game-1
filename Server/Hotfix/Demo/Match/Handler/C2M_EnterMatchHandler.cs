using System;
using System.Collections.Generic;

namespace ET
{
    [FriendClass(typeof(MatchComponent))]
    [FriendClass(typeof(GameRoomComponent))]
    public class C2M_EnterMatchHandler : AMActorLocationRpcHandler<Unit, C2M_EnterMatch, M2C_EnterMatch>
    {
        protected override async ETTask Run(Unit unit, C2M_EnterMatch request, M2C_EnterMatch response, Action reply)
        {
            NumericComponent component = unit.GetComponent<NumericComponent>(); 

            if(component.GetAsInt(NumericType.RoomIndex) != 0)
            {
                response.Error = ErrorCode.ERR_RoomIndexError;
                reply();
                return;
            }

            if(component.GetAsInt(NumericType.IsInMatch) != 0)
            {
                response.Error = ErrorCode.ERR_IsInMatchError;
                reply();
                return;
            }

            Scene scene = unit.DomainScene();
            MatchComponent matchcomponent = scene.GetComponent<MatchComponent>();

            if(request.MatchMode == 1)//Mode=1单机模式
            {
                int roomindex = matchcomponent.NextIndex();//房间号++
                int LevelId = request.LevelId;
                NumericComponent n = unit.GetComponent<NumericComponent>();
                n.Set(NumericType.RoomIndex, roomindex);
                n.Set(NumericType.LevelId, LevelId);
                n.Set(NumericType.IsInMatch, 0);
                n.Set(NumericType.Position, 1);
                n.Set(NumericType.TowerId1, 3001);
                n.Set(NumericType.TowerId2, 3004);
                n.Set(NumericType.TowerId3, 3007);
                n.Set(NumericType.TowerId4, 3010);
                n.Set(NumericType.TowerId5, 3013);
                n.Set(NumericType.TowerId6, 3016);
                n.Set(NumericType.TowerId7, 3019);
                n.Set(NumericType.TowerId8, 3022);
                n.Set(NumericType.Monster1, 9001);
                n.Set(NumericType.Monster2, 9002);
                n.Set(NumericType.Monster3, 9003);
                n.Set(NumericType.Monster4, 9004);
                n.Set(NumericType.Monster5, 9005);
                n.Set(NumericType.Monster6, 9006);
                n.Set(NumericType.Monster7, 9007);
                n.Set(NumericType.Monster8, 9008);
                n.Set(NumericType.Frameid, 0);
                n.Set(NumericType.MatchMode, 1);
                await n.AddOrUpdateUnitCache(UnitHelper.GetUnitServerId(unit));
                M2G_ChangeRoomState m2G_ChangeRoomState = new M2G_ChangeRoomState() { RoomIndex = roomindex };
                StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), "Game");
                await MessageHelper.CallActor(startSceneConfig.InstanceId, m2G_ChangeRoomState);
                await TransferHelper.Transfer(unit, startSceneConfig.InstanceId, startSceneConfig.Name);
            }
            if(request.MatchMode == 2)//Mode=2匹配模式
            {
                component.Set(NumericType.IsInMatch, 1);
                matchcomponent.Add(unit);
                if (matchcomponent.MatchUnits.Count >= 1)//匹配成功  获取Unit
                {
                    int roomindex = matchcomponent.NextIndex();//房间号++
                    //抽取MapId
                    int LevelId = 1001;
                    M2G_ChangeRoomState m2G_ChangeRoomState = new M2G_ChangeRoomState() { RoomIndex = roomindex };
                    StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), "Game");
                    await MessageHelper.CallActor(startSceneConfig.InstanceId, m2G_ChangeRoomState);
                    for (int i = 0; i >= 0; i--)
                    {
                        Unit u = matchcomponent.MatchUnits[i];
                        NumericComponent n = u.GetComponent<NumericComponent>();
                        n.Set(NumericType.RoomIndex, roomindex);
                        n.Set(NumericType.LevelId,LevelId);
                        n.Set(NumericType.IsInMatch, 0);
                        n.Set(NumericType.Position, i + 1);
                        n.Set(NumericType.TowerId1, 3001);
                        n.Set(NumericType.TowerId2, 3004);
                        n.Set(NumericType.TowerId3, 3007);
                        n.Set(NumericType.TowerId4, 3010);
                        n.Set(NumericType.TowerId5, 3013);
                        n.Set(NumericType.TowerId6, 3016);
                        n.Set(NumericType.TowerId7, 3019);
                        n.Set(NumericType.TowerId8, 3022);
                        n.Set(NumericType.Monster1, 9001);
                        n.Set(NumericType.Monster2, 9002);
                        n.Set(NumericType.Monster3, 9003);
                        n.Set(NumericType.Monster4, 9004);
                        n.Set(NumericType.Monster5, 9005);
                        n.Set(NumericType.Monster6, 9006);
                        n.Set(NumericType.Monster7, 9007);
                        n.Set(NumericType.Monster8, 9008);
                        n.Set(NumericType.Frameid, 0);
                        n.Set(NumericType.MatchMode, 2);
                        unit.GetComponent<UnitSaveDBComponent>()?.SaveChange();
                        matchcomponent.Remove(u);
                        await TransferHelper.Transfer(u, startSceneConfig.InstanceId, startSceneConfig.Name);
                    }
                }
            }
            response.MatchMode = request.MatchMode;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
