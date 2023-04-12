using System.Collections.Generic;

namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgForm :Entity,IAwake,IUILogic
	{

		public DlgFormViewComponent View { get => this.Parent.GetComponent<DlgFormViewComponent>();}

        public Dictionary<int, Scroll_Item_Pet> PetItems = new Dictionary<int, Scroll_Item_Pet>();
        public Dictionary<int, Scroll_Item_Tower> TowerItems = new Dictionary<int, Scroll_Item_Tower>();

        public List<FightItem> petItem = new List<FightItem>();
        public List<FightItem> towerfightitem = new List<FightItem>();

        public FightItemType type;

        public int CurrentPetPage;
        public int CurrentTowerPage;
        public int PetCount;
        public int TowerCount;
        public long currentId;

    }
}
