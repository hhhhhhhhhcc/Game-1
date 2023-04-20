using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class TowerAwakeSystem : AwakeSystem<Tower, int>
    {
        public override void Awake(Tower self, int configId)
        {
            self.ConfigId = configId;
            self.Config = TowerConfigCategory.Instance.Get(configId);
            self.AttackTargetList = new List<Monster>();
            self.state = TowerState.NormalAttack;
            self.UpFrame = 23;
            self.AttackNumber = 1;
            self.ExtraCoin = 0;
        }
    }
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Tower))]
    [FriendClass(typeof(Monster))]
    [FriendClass(typeof(MonsterMoveComponent))]
    public static class TowerSystem
    {
        public static async void OnLogicUpdate(this Tower self, int dt)
        {
            if(self.UpFrame != 0)
            {
                self.UpFrame--;
                return;
            }
            if (self.state == TowerState.Crotrol) return;
            self.AttackTargetList.Clear();//重置怪物列表
            self.OnLogicGetAttackMonsterList();//获取所有攻击怪物列表
            self.OnLogic(dt);
            await ETTask.CompletedTask;
        }
        public static void OnLogic(this Tower self, int dt)
        {
            foreach (Type type in self.Components.Keys)
            {
                if (typeof(LogicSkill).IsAssignableFrom(type))
                {
                    var component = self.Components[type];
                    object[] param = new object[] { component, dt };
                    Type system = Type.GetType(type.FullName + "System");
                    system.GetMethod("OnLogic").Invoke(component, param);
                }
            }
        }
        public static async void OnLogicGetAttackMonsterList(this Tower self)
        {
            List<Monster> list = self?.ZoneScene()?.CurrentScene()?.GetComponent<GameComponent>()?.AllEnemy;
            if(list != null)
            {
                foreach (Monster monster in list)
                {
                    float MonsterPx = monster.Position.x;
                    float MonsterPy = monster.Position.y;
                    int MonsterZone = monster.Zone;

                    float TowerPx = self.Position.x;
                    float TowerPy = self.Position.y;
                    float TowerRange = self.AttackRange;
                    float TowerZone = self.Zone;
                    if (TowerZone != MonsterZone) continue;
                    float dis = Vector2.Distance(new Vector2(MonsterPx, MonsterPy), new Vector2(TowerPx, TowerPy));
                    if (dis <= TowerRange)
                    {
                        if(self.Type >= monster.Type)
                        {
                            self.AddMonster(monster);
                            monster.DeathEvent = monster.DeathEvent + self.RemoveMonster;
                        }
                    }
                    else
                    {
                        self.RemoveMonster(monster);
                    }
                }
                self.AttackTargetList.Sort(SortMethod);
            }
            await ETTask.CompletedTask;
        }
        public static Vector3 GetDir(this Tower self)
        {
            return self.AttackTargetList[0].Position - self.Position;
        }
        public static string getanimatorname(this Tower self)
        {
            Vector3 dir = self.GetDir();
            int LevelId = (self.ConfigId - 1) % 3 + 1;
            if (dir.x >= 0 && dir.y > 0)//第一象限 +  45  -135
            {
                return "RUGJ" + LevelId.ToString();
            }
            if (dir.x < 0 && dir.y >= 0)//第二象限 -  135   -45
            {
                return "LUGJ" + LevelId.ToString();
            }
            if (dir.x <= 0 && dir.y < 0)//第三象限 + -135  45
            {
                return "LDGJ" + LevelId.ToString();
            }
            if (dir.x > 0 && dir.y <= 0)//第四象限 -  -45  135
            {
                return "RDGJ" + LevelId.ToString();
            }
            return "";
        }
        public static int SortMethod(Monster a,Monster b)
        {
            if ((a.GetComponent<MonsterMoveComponent>().AllDistance - a.GetComponent<MonsterMoveComponent>().AllReadyRun) > (b.GetComponent<MonsterMoveComponent>().AllDistance - b.GetComponent<MonsterMoveComponent>().AllReadyRun)) return 1;
            else return -1;
        }
        public static void AddMonster(this Tower self, Monster monster)
        {
            if (self.AttackTargetList.Contains(monster))
            {
                return;
            }
            self.AttackTargetList.Add(monster);
        }
        public static void RemoveMonster(this Tower self, Monster monster)
        {
            if (self.AttackTargetList.Contains(monster))
            {
                self.AttackTargetList.Remove(monster);
            }
        }
        public static void SetTowerState(this Tower self, TowerState state)
        {
            self.state = state;
        }
        public static TowerState GetTowerState(this Tower self)
        {
            return self.state;
        }
    }
}
