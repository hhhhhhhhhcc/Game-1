using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class HallComponent : Entity,IAwake,IDestroy
    {
        public long Timer;
        public long HallLogicTimer;
    }
}
