
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_TowerDestroySystem : DestroySystem<Scroll_Item_Tower> 
	{
		public override void Destroy( Scroll_Item_Tower self )
		{
			self.DestroyWidget();
		}
	}
}
