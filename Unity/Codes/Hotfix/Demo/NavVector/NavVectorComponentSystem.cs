using System;
using System.Collections.Generic;
using UnityEngine;
namespace ET
{
    public class NavVectorAwakeSystem : AwakeSystem<NavVectorComponent>
    {
        public override void Awake(NavVectorComponent self)
        {
            self.NavDictionary.Add("Map1",
                new List<Vector3[]>
                {
                    new Vector3[] {
                        new Vector3(-4.8f,4.5f,0),
                        new Vector3(-3.8f,2.8f,0),
                        new Vector3(-5.1f,2.5f,0),
                        new Vector3(-8.1f,2.2f,0),
                        new Vector3(-7.5f,0.25f,0),
                        new Vector3(-3.5f,0,0),
                        new Vector3(-2.5f,-0.6f,0),
                        new Vector3(-2.2f,-2.3f,0),
                        new Vector3(-4.5f,-2.8f,0),
                        new Vector3(-4.7f,-3.5f,0),
                    },
                    new Vector3[] {
                        new Vector3(4.8f,4.5f,0),
                        new Vector3(3.8f,2.8f,0),
                        new Vector3(5.1f,2.5f,0),
                        new Vector3(8.1f,2.2f,0),
                        new Vector3(7.5f,0.25f,0),
                        new Vector3(3.5f,0,0),
                        new Vector3(2.5f,-0.6f,0),
                        new Vector3(2.2f,-2.3f,0),
                        new Vector3(4.5f,-2.8f,0),
                        new Vector3(4.7f,-3.5f,0),
            }});
            self.NavDictionary.Add("Map2", 
                new List<Vector3[]>
                {
                    new Vector3[]{
                        new Vector3(-7.7f,-5.2f,0),
                        new Vector3(-7.6f,-3.25f,0),
                        new Vector3(-7.0f,-2.0f,0),
                        new Vector3(-4.5f,-1.5f,0),
                        new Vector3(-3.85f,0.8f,0),
                        new Vector3(-2.5f,1.5f,0),
                        new Vector3(0,1.55f,0),
                        new Vector3(2.75f,1.7f,0),
                        new Vector3(4.55f,2.1f,0),
                        new Vector3(7.5f,1.88f,0),
                        new Vector3(8.6f,2.6f,0),
                        new Vector3(11.15f,2.7f,0),
                },
                    new Vector3[]
                    {
                        new Vector3(1.8f,-5.35f,0),
                        new Vector3(1.5f,-3.5f,0),
                        new Vector3(0.15f,-2.95f,0),
                        new Vector3(-0.3f,-1.8f,0),
                        new Vector3(0,1.55f,0),
                        new Vector3(2.75f,1.7f,0),
                        new Vector3(4.55f,2.1f,0),
                        new Vector3(7.5f,1.88f,0),
                        new Vector3(8.6f,2.6f,0),
                        new Vector3(11.15f,2.7f,0),
                    }
            });
        }
    }
    public class NavVectorComponentDestroySystem : DestroySystem<NavVectorComponent>
    {
        public override void Destroy(NavVectorComponent self)
        {
        
        }
    }
    [FriendClass(typeof(NavVectorComponent))]
    public static class NavVectorComponentSystem
    {
        public static  List<Vector3[]> GetPosByMapName(this NavVectorComponent self, string MapName)
        {
            return self.NavDictionary[MapName];
        }
    }
}
