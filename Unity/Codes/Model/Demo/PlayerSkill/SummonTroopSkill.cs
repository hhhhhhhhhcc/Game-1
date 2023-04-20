using System.Collections.Generic;

namespace ET
{
    public class SummonTroopSkill : Entity,IAwake,IDestroy, LogicSkill
    {
        public Dictionary<string, int> param = new Dictionary<string, int>();
        public int Time;
        public int Timer;
        public int Zone;
        public float PosX;
        public float PosY;
        public Dictionary<long, Troop> TroopDict = new Dictionary<long, Troop>();
        public string PrefabName;
    }
}
