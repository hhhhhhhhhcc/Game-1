using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class LevelConfigCategory : ProtoObject, IMerge
    {
        public static LevelConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, LevelConfig> dict = new Dictionary<int, LevelConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<LevelConfig> list = new List<LevelConfig>();
		
        public LevelConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            LevelConfigCategory s = o as LevelConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (LevelConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public LevelConfig Get(int id)
        {
            this.dict.TryGetValue(id, out LevelConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (LevelConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, LevelConfig> GetAll()
        {
            return this.dict;
        }

        public LevelConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class LevelConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>地图编号</summary>
		[ProtoMember(2)]
		public int MapId { get; set; }
		/// <summary>关卡配置</summary>
		[ProtoMember(3)]
		public string WaveCode { get; set; }
		/// <summary>每波次的时间间隔</summary>
		[ProtoMember(4)]
		public int[] MonsterWaveInterval { get; set; }

	}
}
