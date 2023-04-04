using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TalentCostConfigCategory : ProtoObject, IMerge
    {
        public static TalentCostConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TalentCostConfig> dict = new Dictionary<int, TalentCostConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TalentCostConfig> list = new List<TalentCostConfig>();
		
        public TalentCostConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TalentCostConfigCategory s = o as TalentCostConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TalentCostConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TalentCostConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TalentCostConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TalentCostConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TalentCostConfig> GetAll()
        {
            return this.dict;
        }

        public TalentCostConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TalentCostConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>对应战斗单元表的天赋code</summary>
		[ProtoMember(2)]
		public string Code { get; set; }
		/// <summary>天赋层级</summary>
		[ProtoMember(3)]
		public int Level { get; set; }
		/// <summary>花费</summary>
		[ProtoMember(4)]
		public int Cost { get; set; }

	}
}
