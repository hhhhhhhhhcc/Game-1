using System.Collections.Generic;

namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgForm :Entity,IAwake,IUILogic
	{

		public DlgFormViewComponent View { get => this.Parent.GetComponent<DlgFormViewComponent>();}

        public Dictionary<int, Scroll_Item_Pet> PetItems = new Dictionary<int, Scroll_Item_Pet>();
        public Dictionary<int, Scroll_Item_TowerForm> TowerItems = new Dictionary<int, Scroll_Item_TowerForm>();


        public List<FightItem> petItem = new List<FightItem>();
        public List<FightItem> towerfightitem = new List<FightItem>();

        public FightItemType type;

        public int CurrentPetPage;
        public int CurrentTowerPage;
        public int PetCount;
        public int TowerCount;
        public long currentId;

        public int[] pet = new int[4];
        public int[] tower = new int[4];

        public int pet1;
        public int pet2;
        public int pet3;
        public int pet4;
        public int tower1;
        public int tower2;
        public int tower3;
        public int tower4;

        public int mode = 0;

    }
}
