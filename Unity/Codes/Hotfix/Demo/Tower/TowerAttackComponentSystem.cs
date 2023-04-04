using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class TowerAttackComponentAwakeSystem : AwakeSystem<TowerAttackComponent>
    {
        public override void Awake(TowerAttackComponent self)
        {
            
        }
    }
    public class TowerAttackComponentDestroyComponent : DestroySystem<TowerAttackComponent>
    {
        public override void Destroy(TowerAttackComponent self)
        {
            
        }
    }

    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(TowerAttackComponent))]
    [FriendClass(typeof(Monster))]
    public static class TowerAttackComponentSystem
    {
        
    }
}
