using System.Collections.Generic;

namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgSelect :Entity,IAwake,IUILogic
	{

		public DlgSelectViewComponent View { get => this.Parent.GetComponent<DlgSelectViewComponent>();}

        public Dictionary<int, Scroll_Item_Enemy> ScrollItemEnemyItems = new Dictionary<int, Scroll_Item_Enemy>();
	
        public int currentChapterId = 0;
		public int currentChapterCount;
		public int currentLevelId = 1;
		public int currentLevelCount;

    }
}
