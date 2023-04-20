using System.Collections.Generic;

namespace ET
{
    public class InterferenceTowerSkill : Entity,IAwake,IDestroy, LogicSkill
    {
        public List<Tower> Towers = new List<Tower>();
        public int Timer;
        public int Time;
        public Dictionary<string,int> param = new Dictionary<string,int>();
        public int Zone;
    }
}
