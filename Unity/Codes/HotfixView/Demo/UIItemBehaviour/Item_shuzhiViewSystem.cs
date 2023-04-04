﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_shuzhiDestroySystem : DestroySystem<Scroll_Item_shuzhi> 
	{
		public override void Destroy( Scroll_Item_shuzhi self )
		{
			self.DestroyWidget();
		}
	}
}
