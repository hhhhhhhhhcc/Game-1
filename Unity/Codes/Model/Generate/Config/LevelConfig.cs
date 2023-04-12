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
		/// <summary>关卡配置(对应monsterwaveconfig的code)</summary>
		[ProtoMember(3)]
		public string MonsterWaveCode { get; set; }
		/// <summary>每波次的时间间隔</summary>
		[ProtoMember(4)]
		public int[] MonsterWaveInterval { get; set; }
		/// <summary>初始金币</summary>
		[ProtoMember(5)]
		public int InitGold { get; set; }
		/// <summary>获胜奖励</summary>
		[ProtoMember(6)]
		public string Reward { get; set; }
		/// <summary>比例系数(双人专用，赢输)(100的倍数)</summary>
		[ProtoMember(7)]
		public int[] Percent { get; set; }
		/// <summary>关卡描述</summary>
		[ProtoMember(8)]
		public string LevelDis { get; set; }
		/// <summary>关卡名称</summary>
		[ProtoMember(9)]
		public string LevelName { get; set; }
		/// <summary>怪种类Id</summary>
		[ProtoMember(10)]
		public int[] MonstersId { get; set; }

	}
}
