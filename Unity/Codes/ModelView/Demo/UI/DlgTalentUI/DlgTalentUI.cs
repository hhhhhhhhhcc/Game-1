using System.Collections.Generic;

namespace ET
{
	public enum TalentTowerState
	{
		Info = 0,
		Talent = 1,
	}

	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgTalentUI :Entity,IAwake,IUILogic
	{
        public DlgTalentUIViewComponent View { get => this.Parent.GetComponent<DlgTalentUIViewComponent>();}

		public Dictionary<int, Scroll_Item_Tower> TowerItems = new Dictionary<int, Scroll_Item_Tower>();

		 public Dictionary<int, Scroll_Item_Monster> MonsterItems = new Dictionary<int, Scroll_Item_Monster>();

		 public FightItemType type;

		 public TalentTowerState TalentTowerState;

		 public long currentId;

		 public List<FightItem> currentfightitems = new List<FightItem>();

	 	 public List<FightItem> towerfightitem = new List<FightItem>();

	  	public List<FightItem> monsterfightitem = new List<FightItem>();

		public int CurrentTowerPage;

		public int CurrentMonsterPage;

		public int TowerConfigLevel;
        public int TowerTalentDescriptionId = 0;
		public bool TowerTalentDescriptionTrigger = false;

    }
}
