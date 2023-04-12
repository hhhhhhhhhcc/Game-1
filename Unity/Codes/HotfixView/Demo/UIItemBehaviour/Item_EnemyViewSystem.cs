
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_EnemyDestroySystem : DestroySystem<Scroll_Item_Enemy> 
	{
		public override void Destroy( Scroll_Item_Enemy self )
		{
			self.DestroyWidget();
		}
	}
}
