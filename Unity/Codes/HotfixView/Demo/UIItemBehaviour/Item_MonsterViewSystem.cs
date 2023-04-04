
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_MonsterDestroySystem : DestroySystem<Scroll_Item_Monster> 
	{
		public override void Destroy( Scroll_Item_Monster self )
		{
			self.DestroyWidget();
		}
	}
}
