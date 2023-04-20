using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using UnityEngine;

namespace ET
{
    public enum TowerState
    {
        NormalAttack = 1,
        SkillAttack = 2,
        Crotrol = 3,
    }
    public class Tower : Entity, IAwake<int>,IDestroy
    {
        public int ConfigId; //配置表id
        public List<Monster> AttackTargetList;
        public float AttackRange;
        public int Zone;
        public TowerState state;
        public int AttackNumber;
        public int ExtraCoin;
        public int AttackInterval;
        public int PhysicsAttack;
        public int MagicAttack;
        public int Type;
        public int UpFrame;
        public TowerConfig Config;

        private WrapVector3 position = new WrapVector3(); //坐标

        public Vector3 Position
        {
            get => this.position.Value;
            set
            {
                EventType.ChangePosition.Instance.OldPos.Value = this.position.Value;
                this.position.Value = value;

                EventType.ChangePosition.Instance.Tower = this;
                Game.EventSystem.PublishClass(EventType.ChangePosition.Instance);
            }
        }
        public Vector3 Forward
        {
            get => this.Rotation * Vector3.forward;
            set => this.Rotation = Quaternion.LookRotation(value, Vector3.up);
        }

        private WrapQuaternion rotation = new WrapQuaternion();
        public Quaternion Rotation
        {
            get => this.rotation.Value;
            set
            {
                this.rotation.Value = value;
                EventType.ChangeRotation.Instance.Tower = this;
                Game.EventSystem.PublishClass(EventType.ChangeRotation.Instance);
            }
        }
    }
}