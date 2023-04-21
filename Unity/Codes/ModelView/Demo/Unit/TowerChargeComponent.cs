﻿using UnityEngine;

namespace ET
{
    [ComponentOf(typeof(Tower))]
    public class TowerChargeComponent : Entity,IAwake,IUpdate,IDestroy
    {
        public GameObject TowerChargeBarGroup;
        public SpriteRenderer ChargeBar;
        public SpriteRenderer SquareDecorate;
        public SpriteRenderer StarSquare;
        public SpriteRenderer Star;
        public Transform AttackPoint;
    }
}
