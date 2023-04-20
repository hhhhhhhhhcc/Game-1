using System.Collections.Generic;

namespace ET
{
    public class TowerFactory : Entity, IAwake, IDestroy
    {
        public long TowerId;
        public int ConfigId;
        public int Number;
        public int Zone;
        public int Timer;
        public int Interval;
        public float TowerPx;
        public float TowerPy;
        public List<int> Talents = new List<int>();
        public int optId;
        public int opttype;
    }
}
