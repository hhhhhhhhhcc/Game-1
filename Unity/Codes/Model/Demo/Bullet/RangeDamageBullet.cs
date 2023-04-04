﻿using UnityEngine;

namespace ET
{
    [ComponentOf(typeof(Bullet))]
    public class RangeDamageBullet : Entity,IAwake,IUpdate,IDestroy,LogicBullet
    {
        public float Speed;
        public float DamageRange;
        public int PhysicsDamage;
        public int MagicDamage;
        public Vector3 DirPos;
        public int IsAP;
        public int Multiplier;
        public bool IsReadyDamage;
        public int ExtraCoin;
    }
}
