namespace ET
{
    [FriendClass(typeof(Monster))]
    public class VertigoBuffComponentAwakeSystem : AwakeSystem<VertigoBuffComponent>
    {
        public override void Awake(VertigoBuffComponent self)
        {
            self.GetParent<Monster>().State = MonsterState.Control;
        }
    }
    [FriendClass(typeof(Monster))]
    public class VertigoBuffComponentDestroySystem : DestroySystem<VertigoBuffComponent>
    {
        public override void Destroy(VertigoBuffComponent self)
        {
            self.GetParent<Monster>().State = MonsterState.Run;
        }
    }
    [FriendClass(typeof(VertigoBuffComponent))]
    public static class VertigoBuffComponentSystem
    {
        public static void Init(this VertigoBuffComponent self,string param)
        {
            self.param = SkillHelper.GetSkillString(param);
            self.lasttime = self.param["bufftime"];
            self.timer = 0;
        }
        public static void OnLogic(this VertigoBuffComponent self,int dt) 
        {
            self.timer = self.timer + dt;
            if(self.timer >= self.lasttime)
            {
                self.Dispose();
            }
        }
    }
}
