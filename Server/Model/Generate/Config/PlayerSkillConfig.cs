using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PlayerSkillConfigCategory : ProtoObject, IMerge
    {
        public static PlayerSkillConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PlayerSkillConfig> dict = new Dictionary<int, PlayerSkillConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PlayerSkillConfig> list = new List<PlayerSkillConfig>();
		
        public PlayerSkillConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PlayerSkillConfigCategory s = o as PlayerSkillConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PlayerSkillConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PlayerSkillConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PlayerSkillConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PlayerSkillConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PlayerSkillConfig> GetAll()
        {
            return this.dict;
        }

        public PlayerSkillConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PlayerSkillConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>对应技能表的ConfigId</summary>
		[ProtoMember(2)]
		public int SkillConfigId { get; set; }
		/// <summary>释放类型(程序用,1直接释放,2位置,3范围和位置,4选择我方塔,5选择敌方塔)显示UI用</summary>
		[ProtoMember(3)]
		public int ReleaseType { get; set; }

	}
}
