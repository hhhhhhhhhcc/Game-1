using System.Collections.Generic;

namespace ET
{
    public class TowerAddPropertiesSkillAwakeSystem : AwakeSystem<TowerAddPropertiesSkill>
    {
        public override void Awake(TowerAddPropertiesSkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(6003).Params);
            self.Time = self.param["time"];
            self.Timer = 0; 
        }
    }
    [FriendClass(typeof(Tower))]
    public class TowerAddPropertiesSkillDestroySystem : DestroySystem<TowerAddPropertiesSkill>
    {
        public override void Destroy(TowerAddPropertiesSkill self)
        {
            for(int i=0;i<self.Towers.Count;i++)
            {
                Tower tower = self.Towers[i];
                if(tower != null)
                {
                    //销毁删属性
                    tower.AttackInterval = tower.AttackInterval * 100 / (100 + self.param["attackspeedadd"]);
                    tower.PhysicsAttack = self.originphysicsdamage[tower];
                    tower.MagicAttack = self.originmagicdamage[tower];
                }
            }
        }
    }
    [FriendClass(typeof(TowerAddPropertiesSkill))]
    [FriendClass(typeof(Tower))]
    public static class TowerAddPropertiesSkillSystem
    {
        public static void InitUnits(this TowerAddPropertiesSkill self, List<long> TowerIdS)//towerid  位置X,Y
        {
            for(int i = 0;i<TowerIdS.Count;i++)
            {
                long towerId = TowerIdS[i];
                Tower tower = self.ZoneScene().CurrentScene().GetComponent<TowerComponent>().GetChild<Tower>(towerId);
                self.Towers.Add(tower) ;

            }
            //属性添加放在出了数据之后
            for(int i=0;i<self.Towers.Count;i++)
            {
                Tower tower = self.Towers[i];
                if(tower != null)
                {
                    tower.AttackInterval = tower.AttackInterval * (100 + self.param["attackspeedadd"]) / 100;
                    int physicsattack = tower.PhysicsAttack;
                    int magicattack = tower.MagicAttack;
                    self.originphysicsdamage.Add(tower, physicsattack);
                    self.originmagicdamage.Add(tower, magicattack);
                    tower.PhysicsAttack = tower.PhysicsAttack * (100 + self.param["attackdamageadd"]) / 100;
                    tower.MagicAttack = tower.MagicAttack * (100 + self.param["attackdamageadd"]) / 100;
                }
            }
        }
        public static void InitZone(this TowerAddPropertiesSkill self,int Zone)
        {
            self.Zone = Zone;
        }
        public static void OnLogic(this TowerAddPropertiesSkill self,int dt)
        {
            self.Timer = self.Timer + dt;
            if(self.Timer >= self.Time)
            {
                self?.Dispose();
            }
        }
    }
}
