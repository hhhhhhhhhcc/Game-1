using System.Collections.Generic;
using UnityEngine;
namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class NavVectorComponent : Entity,IAwake,IDestroy
    {
        public Dictionary<string, List<Vector3[]>> NavDictionary = new Dictionary<string, List<Vector3[]>>();
    }
}
