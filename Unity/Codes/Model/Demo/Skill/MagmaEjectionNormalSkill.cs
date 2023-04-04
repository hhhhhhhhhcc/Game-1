﻿using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class MagmaEjectionNormalSkill : Entity,IAwake,IDestroy,LogicSkill
    {
        public int AttackIntervalTimer;
        public string PrefabName;
        public int FlySpeed;
        public int RemainAttackNumber;
        public int RemainAttackLogic;
        public Dictionary<string, int> param;
    }
}
