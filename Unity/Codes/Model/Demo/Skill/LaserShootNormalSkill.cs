﻿using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class LaserShootNormalSkill : Entity,IAwake,IUpdate,IDestroy,LogicSkill
    {
        public int AttackInterval;
        public int AttackIntervalTimer;
        public string LaserMat;
        public Dictionary<string, int> param;
        public int buffid;
    }
}
