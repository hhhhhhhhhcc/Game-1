using System.Collections.Generic;

namespace ET
{
    public class ResonanceBuffComponentAwakeSystem : AwakeSystem<ResonanceBuffComponent>
    {
        public override void Awake(ResonanceBuffComponent self)
        {
            
        }
    }
    [FriendClass(typeof(ResonanceBuffComponent))]
    public static class ResonanceBuffComponentSystem 
    {
        public static void Init(this ResonanceBuffComponent self,string param)
        {
            self.param = SkillHelper.GetSkillString(param);
        }
        public static int GetExtraDamage(this ResonanceBuffComponent self)
        {
            return self.param["buffeffect"];
        }
    }
}
