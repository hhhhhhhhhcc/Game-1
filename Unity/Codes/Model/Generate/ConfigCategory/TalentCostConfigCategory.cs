using ProtoBuf;
namespace ET
{
    public partial class TalentCostConfigCategory : ProtoObject, IMerge
    {
        public int GetCostByCodeAndLevel(string code,int level)
        {
            foreach(TalentCostConfig config in list)
            {
                if(config.Code == code && config.Level == level)
                {
                    return config.Cost;
                }
            }
            return 0;
        }
    }
}
