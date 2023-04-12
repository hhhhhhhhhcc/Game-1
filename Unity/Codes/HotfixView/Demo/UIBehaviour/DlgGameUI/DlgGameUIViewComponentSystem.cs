
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgGameUIViewComponentAwakeSystem : AwakeSystem<DlgGameUIViewComponent> 
	{
		public override void Awake(DlgGameUIViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}
    [ObjectSystem]
    public class DlgGameUIViewComponenUpdateSystem : UpdateSystem<DlgGameUIViewComponent>
    {
        public override void Update(DlgGameUIViewComponent self)
        {
            self.E_RangeSkillImage.transform.localPosition = (Input.mousePosition - new Vector3(Screen.width / 2, Screen.height / 2, 0)) * Screen.currentResolution.width / Screen.width;
        }
    }
   

    [ObjectSystem]
	public class DlgGameUIViewComponentDestroySystem : DestroySystem<DlgGameUIViewComponent> 
	{
		public override void Destroy(DlgGameUIViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
