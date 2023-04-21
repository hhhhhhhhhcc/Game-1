
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
	[FriendClass(typeof(DlgTalentUI))]
	[FriendClass(typeof(DlgTalentUIViewComponent))]
	[ObjectSystem]
    public class DlgTalentUIViewComponentUpdateSystem : UpdateSystem<DlgTalentUIViewComponent>
    {
        public override void Update(DlgTalentUIViewComponent self)
        {
			bool trigger = self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgTalentUI>().TowerTalentDescriptionTrigger;
			if (trigger)
			{
				self.TowerTalentDescriptionTimer = self.TowerTalentDescriptionTimer + Time.deltaTime;
				if(self.TowerTalentDescriptionTimer >= 0.2f)
				{
					int TowerTalentDescriptionId = self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgTalentUI>().TowerTalentDescriptionId;
                    self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgTalentUI>().ShowTowerTalentDescriptionByPos(TowerTalentDescriptionId);
                }
			}
			else
			{
				self.TowerTalentDescriptionTimer = 0;
				self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgTalentUI>().HideAllTowerTalentDescription();
            }
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
