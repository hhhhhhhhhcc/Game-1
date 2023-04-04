using ProtoBuf;
namespace ET
{
    public partial class TalentConfigCategory : ProtoObject, IMerge
    {
        public int GetTalentId(string code,int level,int sn)
        {
            foreach(TalentConfig config in list)
            {
                if(config.Code == code && config.Level == level && config.Sn == sn)
                {
                    return config.Id;
                }
            }
            return 0;
        }
    }
}
