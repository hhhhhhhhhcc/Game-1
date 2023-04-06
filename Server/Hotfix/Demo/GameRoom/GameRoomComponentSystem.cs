using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace ET
{
    public class GameRoomComponentAwakeSystem : AwakeSystem<GameRoomComponent>
    {
        public override void Awake(GameRoomComponent self)
        {
        }
    }
    public class GameRoomComponentDestroySystem : DestroySystem<GameRoomComponent>
    {
        public override void Destroy(GameRoomComponent self)
        {
        }
    }
    [FriendClass(typeof(GameRoomComponent))]
    public static class GameRoomComponentSystem
    {
        public static void Add(this GameRoomComponent self,int roomIndex,Unit unit)
        {
            if(!self.rooms.ContainsKey(roomIndex))//不包含 创建一个List
            {
                List<Unit> units = new List<Unit>();
                units.Add(unit);
                self.rooms.Add(roomIndex, units);   
            }
            else
            {
                List<Unit> units = self.rooms[roomIndex];
                units.Add(unit);
                self.rooms[roomIndex] = units;
            }
        }
        public static void RemoveUnit(this GameRoomComponent self,int RoomIndex,Unit unit)
        {
            if(self.rooms.ContainsKey(RoomIndex))
            {
                if (self.rooms[RoomIndex].Contains(unit))
                {
                    self.rooms[RoomIndex].Remove(unit);
                }
            }
        }
        public static void ClearRoomUnit(this GameRoomComponent self,int RoomIndex)//清空房间玩家
        {
            if (self.rooms.ContainsKey(RoomIndex))
            {
                self.rooms.Remove(RoomIndex);
            }
        }
        public static void ClearRoomState(this GameRoomComponent self, int RoomIndex)
        {
            if(self.roomstate.ContainsKey(RoomIndex))
            {
                self.roomstate.Remove(RoomIndex);
            }
        }
        public static int GetRoomState(this GameRoomComponent self, int RoomIndex)
        {
            return self.roomstate[RoomIndex];
        }
        public static int SetRoomState(this GameRoomComponent self, int RoomIndex,int State)
        {
            return self.roomstate[RoomIndex] = State;
        }
        public static List<Unit> Get(this GameRoomComponent self,int RoomIndex)
        {
            if(self.rooms.TryGetValue(RoomIndex,out List<Unit> value))
            {
                return value;
            }
            return null;
        }
        public static void StartGame(this GameRoomComponent self,int RoomIndex)
        {
            long id = IdGenerater.Instance.GenerateId();
            LogicComponent logic = self.AddChildWithId<LogicComponent,int>(id,RoomIndex);
            self.logics[RoomIndex] = id;
        }
        public static List<int> NewChance(this GameRoomComponent self,int number)
        {
            List<int> chance = new List<int>();
            for (int i = 0; i < number; i++) 
            {
                Random rd = new Random();
                int c = rd.Next(1, 101);
                chance.Add(c);
            }
            return chance;
        }
        public static List<int> GetChance(this GameRoomComponent self,int roomindex)
        {
            return self.chance[roomindex];
        }
        public static void ClearLogicComponent(this GameRoomComponent self,int roomindex)//清空帧同步组件
        {
            long logicid = self.logics[roomindex];
            LogicComponent logiccomponent = self.GetChild<LogicComponent>(logicid);
            logiccomponent.Dispose();
        }
    }
}
