
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_PetDestroySystem : DestroySystem<Scroll_Item_Pet> 
	{
		public override void Destroy( Scroll_Item_Pet self )
		{
			self.DestroyWidget();
		}
	}
}
