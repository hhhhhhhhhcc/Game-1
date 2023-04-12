
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_TowerFormDestroySystem : DestroySystem<Scroll_Item_TowerForm> 
	{
		public override void Destroy( Scroll_Item_TowerForm self )
		{
			self.DestroyWidget();
		}
	}
}
