using System.Collections.Generic;

namespace ET
{
    public class DecelerateBuffComponentAwakeSystem : AwakeSystem<DecelerateBuffComponent>
    {
        public override void Awake(DecelerateBuffComponent self)
        {

        }
    }
    [FriendClass(typeof(Monster))]
    public class DecelerateBuffComponentDestroySystem : DestroySystem<DecelerateBuffComponent>
    {
        public override void Destroy(DecelerateBuffComponent self)
        {
            self.GetParent<Monster>().Speed = self.GetParent<Monster>().Speed * 100 / (float)(100 - self.effect);//1.25
        }
    }
    [FriendClass(typeof(DecelerateBuffComponent))]
    [FriendClass(typeof(Monster))]
    public static class DecelerateBuffComponentSystem
    {
        public static void Init(this DecelerateBuffComponent self,string Params)
        {
            self.param = SkillHelper.GetSkillString(Params);
            self.lasttime = self.param["bufftime"];
            self.timer = 0;
            self.effect = self.param["buffeffect"];
            self.GetParent<Monster>().Speed = self.GetParent<Monster>().Speed * (float)(100 - self.effect) / 100.0f; //*0.8
        }
        public static void OnLogic(this DecelerateBuffComponent self, int dt)
        {
            self.timer = self.timer + dt;
            if (self.timer >= self.lasttime)
            {
                self.Dispose();
            }
        }
    }
}
