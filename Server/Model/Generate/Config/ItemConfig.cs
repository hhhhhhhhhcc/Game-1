using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ItemConfigCategory : ProtoObject, IMerge
    {
        public static ItemConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ItemConfig> dict = new Dictionary<int, ItemConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ItemConfig> list = new List<ItemConfig>();
		
        public ItemConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ItemConfigCategory s = o as ItemConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ItemConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ItemConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ItemConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ItemConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ItemConfig> GetAll()
        {
            return this.dict;
        }

        public ItemConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ItemConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>物品描述</summary>
		[ProtoMember(2)]
		public string ItemDes { get; set; }
		/// <summary>物品美术资源</summary>
		[ProtoMember(3)]
		public string ItemName { get; set; }
		/// <summary>物品类型</summary>
		[ProtoMember(4)]
		public int ItemType { get; set; }

	}
}
