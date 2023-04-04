﻿using System.Collections.Generic;
namespace ET
{
    [ComponentOf(typeof(Scene))]
    [ChildType]
    public class RoleInfosComponent : Entity,IAwake,IDestroy
    {
        public List<RoleInfo> RoleInfos = new List<RoleInfo>();
        public int CurrentRoleId = 0;
    }
}
