using UnityEngine;
namespace ET
{
    public class Base : Entity,IAwake,IDestroy
    {
        public int MaxHp;
        public int Hp;
        public int Zone;
        public int PosId;
        private WrapVector3 position = new WrapVector3(); //坐标
        public Vector3 Position
        {
            get => this.position.Value;
            set
            {
                EventType.ChangePosition.Instance.OldPos.Value = this.position.Value;
                this.position.Value = value;

                EventType.ChangePosition.Instance.Base = this;
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
                EventType.ChangeRotation.Instance.Base = this;
                Game.EventSystem.PublishClass(EventType.ChangeRotation.Instance);
            }
        }
    }
}
