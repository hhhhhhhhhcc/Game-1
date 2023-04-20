using System.Collections.Generic;

namespace ET
{
    public class MeteoriteSkill : Entity,IAwake,IDestroy, LogicSkill
    {
        public Dictionary<string, int> param = new Dictionary<string, int>();
        public int Time;
        public int Timer;
        public int IntervalTime;
        public int IntervalTimer;
        public float PosX;
        public float PosY;
        public int Zone;
    }
}
