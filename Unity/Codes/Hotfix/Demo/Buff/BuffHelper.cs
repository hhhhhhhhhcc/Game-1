using System.Collections.Generic;
namespace ET
{

    [FriendClass(typeof(Monster))]
    public static class BuffHelper
    {
        public static async ETTask MonsterAddBuff(Monster monster,string ExtraParam)
        {
            Dictionary<string, int> buffparam = SkillHelper.GetSkillString(ExtraParam);
            int BuffId = 0;
            if(buffparam.ContainsKey("buff"))
            {
                BuffId = buffparam["buff"];
            }
            if (BuffId == 0) return;
            if (monster == null) return;
            switch (BuffId)
            {
                case 1://眩晕
                    if (monster.GetComponent<VertigoBuffComponent>() == null)
                    {
                        monster.AddComponent<VertigoBuffComponent>();
                    }
                    monster.GetComponent<VertigoBuffComponent>().Init(ExtraParam);
                    break;
                case 2://减速
                    if (monster.GetComponent<DecelerateBuffComponent>() != null)
                    {
                        monster.RemoveComponent<DecelerateBuffComponent>();
                    }
                    monster.AddComponent<DecelerateBuffComponent>();
                    monster.GetComponent<DecelerateBuffComponent>().Init(ExtraParam);
                    break;
                case 3://灼伤
                    if (monster.GetComponent<BurningBuffComponent>() == null)
                    {
                        monster.AddComponent<BurningBuffComponent>();
                    }
                    monster.GetComponent<BurningBuffComponent>().Init(ExtraParam);
                    break;
                case 4://共振
                    if(monster.GetComponent<ResonanceBuffComponent>() == null)
                    {
                        monster.AddComponent<ResonanceBuffComponent>();
                    }
                    monster.GetComponent<ResonanceBuffComponent>().Init(ExtraParam);
                    break;
                case 5://易伤
                    break;
                case 6://点燃
                    if(monster.GetComponent<IgniteBuffComponent>() == null)
                    {
                        monster.AddComponent<IgniteBuffComponent>();
                    }
                    monster.GetComponent<IgniteBuffComponent>().Init(ExtraParam);
                    break;
                case 7://破甲
                    if(monster.GetComponent<BrokenArmorBuffComponent>() == null)
                    {
                        monster.AddComponent<BrokenArmorBuffComponent>();
                    }
                    monster.GetComponent<BrokenArmorBuffComponent>().Init(ExtraParam);
                    break;
                case 8://锁定延迟眩晕
                    if(monster.GetComponent<LockVertigoBuffComponent>() == null)
                    {
                        monster.AddComponent<LockVertigoBuffComponent>();
                    }
                    monster.GetComponent<LockVertigoBuffComponent>().Init(ExtraParam);
                    break;
            }
            await ETTask.CompletedTask;
        }
        public static async ETTask MonsterRemoveBuff(Monster monster,string buffparam)
        {
            Dictionary<string, int> buffparams = SkillHelper.GetSkillString(buffparam);
            int BuffId = buffparams["buff"];
            if (monster == null) return;
            if (BuffId == 0) return;
            int bufftype = (BuffId - 1) % 3 + 1;
            switch(bufftype)
            {
                case 4://共振
                    if(monster.GetComponent<ResonanceBuffComponent>() != null)
                    {
                        monster.RemoveComponent<ResonanceBuffComponent>();
                    }
                    break;
                case 8://锁定延迟眩晕
                    if(monster.GetComponent<LockVertigoBuffComponent>() != null)
                    {
                        monster.RemoveComponent<LockVertigoBuffComponent>();
                    }
                    break;
            }
            await ETTask.CompletedTask;
        }
    }
}
