using UnityEngine;

namespace ET
{
    [ComponentOf(typeof(Bullet))]
    public class SingleDamageBullet : Entity,IAwake,IUpdate,IDestroy,LogicBullet
    {
        public float Speed;
        public int PhysicsDamage;
        public int MagicDamage;
        public Monster Monster;
        public int IsAP;
        public int Multiplier;
    }
}
