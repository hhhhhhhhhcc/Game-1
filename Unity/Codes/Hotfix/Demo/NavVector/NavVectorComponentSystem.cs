using System;
using System.Collections.Generic;
using UnityEngine;
namespace ET
{
    public class NavVectorAwakeSystem : AwakeSystem<NavVectorComponent>
    {
        public override void Awake(NavVectorComponent self)
        {
            self.NavDictionary.Add("Map0",
                new List<Vector3[]>
                {
                    new Vector3[]{
                        new Vector3(11.15f,2.7f,0),
                        new Vector3(8.6f,2.6f,0),
                        new Vector3(7.5f,1.88f,0),
                        new Vector3(2.75f,1.7f,0),
                        new Vector3(0,1.55f,0),
                        new Vector3(-2.5f,1.5f,0),
                        new Vector3(-3.85f,0.8f,0),
                        new Vector3(-4.5f,-1.5f,0),
                        new Vector3(-7.0f,-2.0f,0),
                        new Vector3(-7.6f,-3.25f,0),
                        new Vector3(-7.7f,-5.2f,0),
                        new Vector3(4.55f,2.1f,0),
                    }
            });
            self.NavDictionary.Add("Map1",
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
            self.NavDictionary.Add("Map1001",
                new List<Vector3[]>
                {
                    new Vector3[] {//1
                        new Vector3(-6.25f,5.22f,0),
                        new Vector3(-6.24f,0.75f,0),
                        new Vector3(-2.93f,0.75f,0),
                        new Vector3(-2.13f,-0.57f,0),
                        new Vector3(-2.96f,-3.35f,0),
                        new Vector3(-2.72f,-5.77f,0),
                    },
                    new Vector3[] {//2
                        new Vector3(-13f,0.75f,0),
                        new Vector3(-6.24f,0.75f,0),
                        new Vector3(-2.93f,0.75f,0),
                        new Vector3(-2.13f,-0.57f,0),
                        new Vector3(-2.96f,-3.35f,0),
                        new Vector3(-2.72f,-5.77f,0),
                    },
                    new Vector3[] {//3
                        new Vector3(13f,0.75f,0),
                        new Vector3(6.24f,0.75f,0),
                        new Vector3(2.93f,0.75f,0),
                        new Vector3(2.13f,-0.57f,0),
                        new Vector3(2.96f,-3.35f,0),
                        new Vector3(2.72f,-5.77f,0),
                    },
                    new Vector3[] {//4
                        new Vector3(6.25f,5.22f,0),
                        new Vector3(6.24f,0.75f,0),
                        new Vector3(2.93f,0.75f,0),
                        new Vector3(2.13f,-0.57f,0),
                        new Vector3(2.96f,-3.35f,0),
                        new Vector3(2.72f,-5.77f,0),
                    },
                    new Vector3[] {//5
                        new Vector3(-1.43f,2.81f,0),
                        new Vector3(-3.07f,2.42f,0),
                        new Vector3(-3.47f,1.57f,0),
                        new Vector3(-2.93f,0.75f,0),
                        new Vector3(-2.13f,-0.57f,0),
                        new Vector3(-2.96f,-3.35f,0),
                        new Vector3(-2.72f,-5.77f,0),
                    },
                    new Vector3[] {//6
                        new Vector3(1.43f,2.81f,0),
                        new Vector3(3.07f,2.42f,0),
                        new Vector3(3.47f,1.57f,0),
                        new Vector3(2.93f,0.75f,0),
                        new Vector3(2.13f,-0.57f,0),
                        new Vector3(2.96f,-3.35f,0),
                        new Vector3(2.72f,-5.77f,0),
                    },
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
