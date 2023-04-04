﻿using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class FightItem : Entity, IAwake<int>, IDestroy, ISerializeToEntity
    {
        public int ConfigId = 0;

        public List<int> AddedTalent = new List<int>();

        public int Upgrading = 0;
        [BsonIgnore]
        public FightItemConfig Config => FightItemConfigCategory.Instance.Get(ConfigId);
    }
}
