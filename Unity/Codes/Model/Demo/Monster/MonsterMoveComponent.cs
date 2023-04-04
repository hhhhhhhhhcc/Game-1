using UnityEngine;

namespace ET
{
    [ComponentOf(typeof(Monster))]
    public class MonsterMoveComponent : Entity,IAwake<int>,IUpdate,IDestroy
    {
        public Vector3[] NavPos = new Vector3[] { };
        public Vector3 LogicPos;
        public float AllDistance;
        public float AllReadyRun;
        public int CurrentPos;
    }
}
