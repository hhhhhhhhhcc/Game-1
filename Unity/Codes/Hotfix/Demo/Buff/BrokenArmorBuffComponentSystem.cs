using JetBrains.Annotations;
using System.Collections.Generic;

namespace ET
{
    public class BrokenArmorBuffComponentAwakeSystem : AwakeSystem<BrokenArmorBuffComponent>
    {
        public override void Awake(BrokenArmorBuffComponent self)
        {
            self.IsTrigger = false;
        }
    }
    [FriendClass(typeof(Monster))]
    public class BrokenArmorBuffComponentDestroySystem : DestroySystem<BrokenArmorBuffComponent>
    {
        public override void Destroy(BrokenArmorBuffComponent self)
        {
            self.GetParent<Monster>().PhysicsDefense = (int)(self.TheoryPhysicsDefense / (100.0f - (float)self.param["buffeffect"]) * 100.0f);//加防御
            self.GetParent<Monster>().MagicDefense = (int)(self.TheoryMagicDefense / (100.0f - (float)self.param["buffeffect"]) * 100.0f);//加魔抗
        }
    }
    [FriendClass(typeof(BrokenArmorBuffComponent))]
    [FriendClass(typeof(Monster))]
    public static class BrokenArmorBuffComponentSystem 
    {
         public static void Init(this BrokenArmorBuffComponent self,string param)
         {
            if(!self.IsTrigger)//未触发
            {
                self.param = SkillHelper.GetSkillString(param);
                self.GetParent<Monster>().PhysicsDefense = self.GetParent<Monster>().PhysicsDefense * (100 - self.param["buffeffect"]) / 100;//减防御
                self.GetParent<Monster>().MagicDefense = self.GetParent<Monster>().MagicDefense * (100 - self.param["buffeffect"]) / 100;//减魔抗
                self.TheoryPhysicsDefense = (float)self.GetParent<Monster>().PhysicsDefense * (100.0f - (float)self.param["buffeffect"]) / 100.0f;//理论防御
                self.TheoryMagicDefense = (float)self.GetParent<Monster>().MagicDefense * (100.0f - (float)self.param["buffeffect"]) / 100.0f;//理论魔抗
            }
            else//已经触发
            {
                self.GetParent<Monster>().PhysicsDefense = (int)(self.TheoryPhysicsDefense / (100.0f - (float)self.param["buffeffect"]) * 100.0f);//加防御
                self.GetParent<Monster>().MagicDefense = (int)(self.TheoryMagicDefense / (100.0f - (float)self.param["buffeffect"]) * 100.0f);//加魔抗
                self.param = SkillHelper.GetSkillString(param);//新数值
                self.GetParent<Monster>().PhysicsDefense = self.GetParent<Monster>().PhysicsDefense * (100 - self.param["buffeffect"]) / 100;//减防御
                self.GetParent<Monster>().MagicDefense = self.GetParent<Monster>().MagicDefense * (100 - self.param["buffeffect"]) / 100;//减魔抗
                self.TheoryPhysicsDefense = (float)self.GetParent<Monster>().PhysicsDefense * (100.0f - (float)self.param["buffeffect"]) / 100.0f;//理论防御
                self.TheoryMagicDefense = (float)self.GetParent<Monster>().MagicDefense * (100.0f - (float)self.param["buffeffect"]) / 100.0f;//理论魔抗
            }
            self.BuffTimer = 0;
            self.BuffTime = self.param["bufftime"];
        }
         public static void OnLogic(this BrokenArmorBuffComponent self,int dt)
         {
            self.BuffTimer = self.BuffTimer + dt;
            if (self.BuffTimer >= self.BuffTime)
            {
                self.Dispose();
            }
         }
    }
}
