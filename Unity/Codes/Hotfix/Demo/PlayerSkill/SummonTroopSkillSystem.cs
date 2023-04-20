using System.Collections.Generic;

namespace ET
{
    public class SummonTroopSkillComponentAwakeSystem : AwakeSystem<SummonTroopSkill>
    {
        public override void Awake(SummonTroopSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(6002).Params);
            self.Time = self.param["time"];
            self.Timer = 0;
            self.PrefabName = "PlayerTroop";
        }
    }
    [FriendClass(typeof(GameComponent))]
    public class SummonTroopSkillComponentDestroySystem : DestroySystem<SummonTroopSkill>
    {
        public override void Destroy(SummonTroopSkill self)
        {
            ForeachHelper.Foreach(self.TroopDict, (long id, Troop troop) =>
            {
                if(self.ZoneScene().CurrentScene().GetComponent<GameComponent>().AllTroop.Contains(troop))
                {
                    self.ZoneScene().CurrentScene().GetComponent<GameComponent>().AllTroop.Remove(troop);
                }
                troop?.Dispose();
            });
            self.TroopDict.Clear();
        }
    }

    [FriendClass(typeof(SummonTroopSkill))]
    [FriendClass(typeof(Troop))]
    public static class SummonTroopSkillSystem
    {
        public static async void InitUnits(this SummonTroopSkill self,List<long> TroopIds)
        {
            for(int i=0;i<TroopIds.Count;i++)
            {
                long TroopId = TroopIds[i];
                Troop Troop = await UnitFactory.CreateAssembleTroop(self.ZoneScene().CurrentScene(), self.param["hp"], self.param["attackdamage"], self.param["attackinterval"], self.param["attackrange"], self.param["speed"],TroopId, self.PosX, self.PosY, self.PrefabName,self.Zone);
                self.TroopDict.Add(TroopId, Troop);
            }
        }
        public static void InitPos(this SummonTroopSkill self,List<float> posXY)
        {
            self.PosX = posXY[0];
            self.PosY = posXY[1];
        }
        public static void InitZone(this SummonTroopSkill self,int Zone)
        {
            self.Zone = Zone;
        }
        public static void OnLogic(this SummonTroopSkill self,int dt)
        {
            self.Timer = self.Timer + dt;
            if(self.Timer >= self.Time)
            {
                self?.Dispose();
            }
            foreach(Troop troop in self.TroopDict.Values)
            {
                if(troop != null)
                {
                    troop.OnLogic(dt);
                }
            }
        }

    }
}
