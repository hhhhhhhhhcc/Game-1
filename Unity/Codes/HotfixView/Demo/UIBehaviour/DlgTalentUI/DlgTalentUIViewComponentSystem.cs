
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgTalentUIViewComponentAwakeSystem : AwakeSystem<DlgTalentUIViewComponent> 
	{
		public override void Awake(DlgTalentUIViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgTalentUIViewComponentDestroySystem : DestroySystem<DlgTalentUIViewComponent> 
	{
		public override void Destroy(DlgTalentUIViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
