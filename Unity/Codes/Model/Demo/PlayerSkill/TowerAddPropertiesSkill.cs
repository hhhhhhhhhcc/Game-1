using System.Collections.Generic;

namespace ET
{
    public class TowerAddPropertiesSkill : Entity,IAwake,IDestroy, LogicSkill
    {
        public Dictionary<string,int> param = new Dictionary<string,int>();
        public List<Tower> Towers = new List<Tower>();
        public int Timer;
        public int Time;
        public int Zone;
        public Dictionary<Tower, int> originphysicsdamage = new Dictionary<Tower, int>();
        public Dictionary<Tower, int> originmagicdamage = new Dictionary<Tower, int>();
    }
}
