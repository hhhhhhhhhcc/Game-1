
using System.Collections.Generic;

namespace ET
{
    public class ResonanceFrequencySkillAwakeSystem : AwakeSystem<ResonanceFrequencySkill>
    {
        public override void Awake(ResonanceFrequencySkill self)
        {
            self.param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(1014).Params);
        }
    }
    [FriendClass(typeof(Tower))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(ResonanceBuffComponent))]
    public static class ResonanceFrequencySkillSystem
    {
        public static void OnAddBuff(this ResonanceFrequencySkill self)
        {
            List<Monster> AddBuffMonster = self.GetParent<Tower>().AttackTargetList;
            List<Monster> AllMonster = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().AllEnemy;
            for (int i = 0; i < AllMonster.Count; i++)
            {
                Monster monster = AllMonster[i];
                if (!AddBuffMonster.Contains(monster))//去除buff
                {
                    BuffHelper.MonsterAddBuff(monster, SkillConfigCategory.Instance.Get(1014).Params).Coroutine();
                }
                else//添加buff
                {
                    BuffHelper.MonsterRemoveBuff(monster, SkillConfigCategory.Instance.Get(1014).Params).Coroutine();
                }
            }
        }
    }
}
