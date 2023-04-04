
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgTalentUIViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_BackBaseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BackBaseButton == null )
     			{
		    		this.m_E_BackBaseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BackBase");
     			}
     			return this.m_E_BackBaseButton;
     		}
     	}

		public UnityEngine.UI.Image E_BackBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BackBaseImage == null )
     			{
		    		this.m_E_BackBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BackBase");
     			}
     			return this.m_E_BackBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_Back1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Back1Image == null )
     			{
		    		this.m_E_Back1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BackBase/E_Back1");
     			}
     			return this.m_E_Back1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Back2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Back2Image == null )
     			{
		    		this.m_E_Back2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BackBase/E_Back2");
     			}
     			return this.m_E_Back2Image;
     		}
     	}

		public UnityEngine.UI.Image E_BookBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BookBaseImage == null )
     			{
		    		this.m_E_BookBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase");
     			}
     			return this.m_E_BookBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_IndexImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_IndexImage == null )
     			{
		    		this.m_E_IndexImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_Index");
     			}
     			return this.m_E_IndexImage;
     		}
     	}

		public UnityEngine.UI.Button E_LabelTowerButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LabelTowerButton == null )
     			{
		    		this.m_E_LabelTowerButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelTower");
     			}
     			return this.m_E_LabelTowerButton;
     		}
     	}

		public UnityEngine.UI.Image E_LabelTowerImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LabelTowerImage == null )
     			{
		    		this.m_E_LabelTowerImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelTower");
     			}
     			return this.m_E_LabelTowerImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerStateImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerStateImage == null )
     			{
		    		this.m_E_TowerStateImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelTower/E_TowerState");
     			}
     			return this.m_E_TowerStateImage;
     		}
     	}

		public UnityEngine.UI.Button E_LabelMonsterButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LabelMonsterButton == null )
     			{
		    		this.m_E_LabelMonsterButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelMonster");
     			}
     			return this.m_E_LabelMonsterButton;
     		}
     	}

		public UnityEngine.UI.Image E_LabelMonsterImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LabelMonsterImage == null )
     			{
		    		this.m_E_LabelMonsterImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelMonster");
     			}
     			return this.m_E_LabelMonsterImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterStateImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterStateImage == null )
     			{
		    		this.m_E_MonsterStateImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelMonster/E_MonsterState");
     			}
     			return this.m_E_MonsterStateImage;
     		}
     	}

		public UnityEngine.UI.Button E_LabelPetButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LabelPetButton == null )
     			{
		    		this.m_E_LabelPetButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelPet");
     			}
     			return this.m_E_LabelPetButton;
     		}
     	}

		public UnityEngine.UI.Image E_LabelPetImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LabelPetImage == null )
     			{
		    		this.m_E_LabelPetImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelPet");
     			}
     			return this.m_E_LabelPetImage;
     		}
     	}

		public UnityEngine.UI.Image E_PetStateImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetStateImage == null )
     			{
		    		this.m_E_PetStateImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_Index/E_LabelPet/E_PetState");
     			}
     			return this.m_E_PetStateImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerPartImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerPartImage == null )
     			{
		    		this.m_E_TowerPartImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart");
     			}
     			return this.m_E_TowerPartImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerBgImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerBgImage == null )
     			{
		    		this.m_E_TowerBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg");
     			}
     			return this.m_E_TowerBgImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTitleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTitleImage == null )
     			{
		    		this.m_E_TowerTitleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerTitle");
     			}
     			return this.m_E_TowerTitleImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerLevel1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLevel1Image == null )
     			{
		    		this.m_E_TowerLevel1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerLevel1");
     			}
     			return this.m_E_TowerLevel1Image;
     		}
     	}

		public UnityEngine.UI.Image E_TowerLevel2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLevel2Image == null )
     			{
		    		this.m_E_TowerLevel2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerLevel2");
     			}
     			return this.m_E_TowerLevel2Image;
     		}
     	}

		public UnityEngine.UI.Image E_TowerLevel3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLevel3Image == null )
     			{
		    		this.m_E_TowerLevel3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerLevel3");
     			}
     			return this.m_E_TowerLevel3Image;
     		}
     	}

		public UnityEngine.UI.Button E_TowerLeftPageBtButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLeftPageBtButton == null )
     			{
		    		this.m_E_TowerLeftPageBtButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerLeftPageBt");
     			}
     			return this.m_E_TowerLeftPageBtButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerLeftPageBtImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLeftPageBtImage == null )
     			{
		    		this.m_E_TowerLeftPageBtImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerLeftPageBt");
     			}
     			return this.m_E_TowerLeftPageBtImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerRightPageBtButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerRightPageBtButton == null )
     			{
		    		this.m_E_TowerRightPageBtButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerRightPageBt");
     			}
     			return this.m_E_TowerRightPageBtButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerRightPageBtImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerRightPageBtImage == null )
     			{
		    		this.m_E_TowerRightPageBtImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerRightPageBt");
     			}
     			return this.m_E_TowerRightPageBtImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerIndexPageBgImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerIndexPageBgImage == null )
     			{
		    		this.m_E_TowerIndexPageBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerIndexPageBg");
     			}
     			return this.m_E_TowerIndexPageBgImage;
     		}
     	}

		public UnityEngine.UI.Text E_TowerIndexPageNumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerIndexPageNumberText == null )
     			{
		    		this.m_E_TowerIndexPageNumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerBg/E_TowerIndexPageBg/E_TowerIndexPageNumber");
     			}
     			return this.m_E_TowerIndexPageNumberText;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect E_TowersLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowersLoopVerticalScrollRect == null )
     			{
		    		this.m_E_TowersLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_Towers");
     			}
     			return this.m_E_TowersLoopVerticalScrollRect;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoTalentBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoTalentBaseImage == null )
     			{
		    		this.m_E_TowerInfoTalentBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase");
     			}
     			return this.m_E_TowerInfoTalentBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoTalentTitleBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoTalentTitleBaseImage == null )
     			{
		    		this.m_E_TowerInfoTalentTitleBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoTalentTitleBase");
     			}
     			return this.m_E_TowerInfoTalentTitleBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoTalentTitleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoTalentTitleImage == null )
     			{
		    		this.m_E_TowerInfoTalentTitleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoTalentTitleBase/E_TowerInfoTalentTitle");
     			}
     			return this.m_E_TowerInfoTalentTitleImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerInfoButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoButton == null )
     			{
		    		this.m_E_TowerInfoButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoTalentTitleBase/E_TowerInfoTalentTitle/E_TowerInfo");
     			}
     			return this.m_E_TowerInfoButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoImage == null )
     			{
		    		this.m_E_TowerInfoImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoTalentTitleBase/E_TowerInfoTalentTitle/E_TowerInfo");
     			}
     			return this.m_E_TowerInfoImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentButton == null )
     			{
		    		this.m_E_TowerTalentButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoTalentTitleBase/E_TowerInfoTalentTitle/E_TowerTalent");
     			}
     			return this.m_E_TowerTalentButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentImage == null )
     			{
		    		this.m_E_TowerTalentImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoTalentTitleBase/E_TowerInfoTalentTitle/E_TowerTalent");
     			}
     			return this.m_E_TowerTalentImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoBaseImage == null )
     			{
		    		this.m_E_TowerInfoBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase");
     			}
     			return this.m_E_TowerInfoBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerNameBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerNameBaseImage == null )
     			{
		    		this.m_E_TowerNameBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerNameBase");
     			}
     			return this.m_E_TowerNameBaseImage;
     		}
     	}

		public UnityEngine.UI.Text E_TowerNameText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerNameText == null )
     			{
		    		this.m_E_TowerNameText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerNameBase/E_TowerName");
     			}
     			return this.m_E_TowerNameText;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoIconBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoIconBaseImage == null )
     			{
		    		this.m_E_TowerInfoIconBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerInfoIconBase");
     			}
     			return this.m_E_TowerInfoIconBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoIconImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoIconImage == null )
     			{
		    		this.m_E_TowerInfoIconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerInfoIconBase/E_TowerInfoIcon");
     			}
     			return this.m_E_TowerInfoIconImage;
     		}
     	}

		public UnityEngine.UI.Image E_Split1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Split1Image == null )
     			{
		    		this.m_E_Split1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_Split1");
     			}
     			return this.m_E_Split1Image;
     		}
     	}

		public UnityEngine.UI.Image E_TowerInfoDescriptionBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoDescriptionBaseImage == null )
     			{
		    		this.m_E_TowerInfoDescriptionBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerInfoDescriptionBase");
     			}
     			return this.m_E_TowerInfoDescriptionBaseImage;
     		}
     	}

		public UnityEngine.UI.Text E_TowerInfoDescriptionText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerInfoDescriptionText == null )
     			{
		    		this.m_E_TowerInfoDescriptionText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerInfoDescriptionBase/E_TowerInfoDescription");
     			}
     			return this.m_E_TowerInfoDescriptionText;
     		}
     	}

		public UnityEngine.UI.Image E_Split2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Split2Image == null )
     			{
		    		this.m_E_Split2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_Split2");
     			}
     			return this.m_E_Split2Image;
     		}
     	}

		public UnityEngine.UI.Image E_TowerPropertiesAllImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerPropertiesAllImage == null )
     			{
		    		this.m_E_TowerPropertiesAllImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll");
     			}
     			return this.m_E_TowerPropertiesAllImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerProperties1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties1Image == null )
     			{
		    		this.m_E_TowerProperties1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties1");
     			}
     			return this.m_E_TowerProperties1Image;
     		}
     	}

		public UnityEngine.UI.Text E_TowerProperties1NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties1NumberText == null )
     			{
		    		this.m_E_TowerProperties1NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties1/E_TowerProperties1Number");
     			}
     			return this.m_E_TowerProperties1NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_TowerProperties2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties2Image == null )
     			{
		    		this.m_E_TowerProperties2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties2");
     			}
     			return this.m_E_TowerProperties2Image;
     		}
     	}

		public UnityEngine.UI.Text E_TowerProperties2NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties2NumberText == null )
     			{
		    		this.m_E_TowerProperties2NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties2/E_TowerProperties2Number");
     			}
     			return this.m_E_TowerProperties2NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_TowerProperties3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties3Image == null )
     			{
		    		this.m_E_TowerProperties3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties3");
     			}
     			return this.m_E_TowerProperties3Image;
     		}
     	}

		public UnityEngine.UI.Text E_TowerProperties3NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties3NumberText == null )
     			{
		    		this.m_E_TowerProperties3NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties3/E_TowerProperties3Number");
     			}
     			return this.m_E_TowerProperties3NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_TowerProperties4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties4Image == null )
     			{
		    		this.m_E_TowerProperties4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties4");
     			}
     			return this.m_E_TowerProperties4Image;
     		}
     	}

		public UnityEngine.UI.Text E_TowerProperties4NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerProperties4NumberText == null )
     			{
		    		this.m_E_TowerProperties4NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerInfoBase/E_TowerPropertiesAll/E_TowerProperties4/E_TowerProperties4Number");
     			}
     			return this.m_E_TowerProperties4NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentBaseImage == null )
     			{
		    		this.m_E_TowerTalentBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase");
     			}
     			return this.m_E_TowerTalentBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalent1BaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalent1BaseImage == null )
     			{
		    		this.m_E_TowerTalent1BaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base");
     			}
     			return this.m_E_TowerTalent1BaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1Image == null )
     			{
		    		this.m_E_TowerTalentLevel1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1");
     			}
     			return this.m_E_TowerTalentLevel1Image;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1LeftArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1LeftArrowImage == null )
     			{
		    		this.m_E_TowerTalentLevel1LeftArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1LeftArrow");
     			}
     			return this.m_E_TowerTalentLevel1LeftArrowImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1LeftBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1LeftBaseImage == null )
     			{
		    		this.m_E_TowerTalentLevel1LeftBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1LeftBase");
     			}
     			return this.m_E_TowerTalentLevel1LeftBaseImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentLevel1LeftButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1LeftButton == null )
     			{
		    		this.m_E_TowerTalentLevel1LeftButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1LeftBase/E_TowerTalentLevel1Left");
     			}
     			return this.m_E_TowerTalentLevel1LeftButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1LeftImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1LeftImage == null )
     			{
		    		this.m_E_TowerTalentLevel1LeftImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1LeftBase/E_TowerTalentLevel1Left");
     			}
     			return this.m_E_TowerTalentLevel1LeftImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1RightArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1RightArrowImage == null )
     			{
		    		this.m_E_TowerTalentLevel1RightArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1RightArrow");
     			}
     			return this.m_E_TowerTalentLevel1RightArrowImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1RightBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1RightBaseImage == null )
     			{
		    		this.m_E_TowerTalentLevel1RightBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1RightBase");
     			}
     			return this.m_E_TowerTalentLevel1RightBaseImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentLevel1RightButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1RightButton == null )
     			{
		    		this.m_E_TowerTalentLevel1RightButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1RightBase/E_TowerTalentLevel1Right");
     			}
     			return this.m_E_TowerTalentLevel1RightButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1RightImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1RightImage == null )
     			{
		    		this.m_E_TowerTalentLevel1RightImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1RightBase/E_TowerTalentLevel1Right");
     			}
     			return this.m_E_TowerTalentLevel1RightImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel1LockImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel1LockImage == null )
     			{
		    		this.m_E_TowerTalentLevel1LockImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent1Base/E_TowerTalentLevel1Lock");
     			}
     			return this.m_E_TowerTalentLevel1LockImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalent2BaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalent2BaseImage == null )
     			{
		    		this.m_E_TowerTalent2BaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base");
     			}
     			return this.m_E_TowerTalent2BaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2Image == null )
     			{
		    		this.m_E_TowerTalentLevel2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2");
     			}
     			return this.m_E_TowerTalentLevel2Image;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2LeftArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2LeftArrowImage == null )
     			{
		    		this.m_E_TowerTalentLevel2LeftArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2LeftArrow");
     			}
     			return this.m_E_TowerTalentLevel2LeftArrowImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2LeftBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2LeftBaseImage == null )
     			{
		    		this.m_E_TowerTalentLevel2LeftBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2LeftBase");
     			}
     			return this.m_E_TowerTalentLevel2LeftBaseImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentLevel2LeftButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2LeftButton == null )
     			{
		    		this.m_E_TowerTalentLevel2LeftButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2LeftBase/E_TowerTalentLevel2Left");
     			}
     			return this.m_E_TowerTalentLevel2LeftButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2LeftImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2LeftImage == null )
     			{
		    		this.m_E_TowerTalentLevel2LeftImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2LeftBase/E_TowerTalentLevel2Left");
     			}
     			return this.m_E_TowerTalentLevel2LeftImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2RightArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2RightArrowImage == null )
     			{
		    		this.m_E_TowerTalentLevel2RightArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2RightArrow");
     			}
     			return this.m_E_TowerTalentLevel2RightArrowImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2RightBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2RightBaseImage == null )
     			{
		    		this.m_E_TowerTalentLevel2RightBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2RightBase");
     			}
     			return this.m_E_TowerTalentLevel2RightBaseImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentLevel2RightButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2RightButton == null )
     			{
		    		this.m_E_TowerTalentLevel2RightButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2RightBase/E_TowerTalentLevel2Right");
     			}
     			return this.m_E_TowerTalentLevel2RightButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2RightImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2RightImage == null )
     			{
		    		this.m_E_TowerTalentLevel2RightImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2RightBase/E_TowerTalentLevel2Right");
     			}
     			return this.m_E_TowerTalentLevel2RightImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel2LockImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel2LockImage == null )
     			{
		    		this.m_E_TowerTalentLevel2LockImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent2Base/E_TowerTalentLevel2Lock");
     			}
     			return this.m_E_TowerTalentLevel2LockImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalent3BaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalent3BaseImage == null )
     			{
		    		this.m_E_TowerTalent3BaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base");
     			}
     			return this.m_E_TowerTalent3BaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3Image == null )
     			{
		    		this.m_E_TowerTalentLevel3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3");
     			}
     			return this.m_E_TowerTalentLevel3Image;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3LeftArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3LeftArrowImage == null )
     			{
		    		this.m_E_TowerTalentLevel3LeftArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3LeftArrow");
     			}
     			return this.m_E_TowerTalentLevel3LeftArrowImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3LeftBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3LeftBaseImage == null )
     			{
		    		this.m_E_TowerTalentLevel3LeftBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3LeftBase");
     			}
     			return this.m_E_TowerTalentLevel3LeftBaseImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentLevel3LeftButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3LeftButton == null )
     			{
		    		this.m_E_TowerTalentLevel3LeftButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3LeftBase/E_TowerTalentLevel3Left");
     			}
     			return this.m_E_TowerTalentLevel3LeftButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3LeftImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3LeftImage == null )
     			{
		    		this.m_E_TowerTalentLevel3LeftImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3LeftBase/E_TowerTalentLevel3Left");
     			}
     			return this.m_E_TowerTalentLevel3LeftImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3RightArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3RightArrowImage == null )
     			{
		    		this.m_E_TowerTalentLevel3RightArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3RightArrow");
     			}
     			return this.m_E_TowerTalentLevel3RightArrowImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3RightBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3RightBaseImage == null )
     			{
		    		this.m_E_TowerTalentLevel3RightBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3RightBase");
     			}
     			return this.m_E_TowerTalentLevel3RightBaseImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentLevel3RightButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3RightButton == null )
     			{
		    		this.m_E_TowerTalentLevel3RightButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3RightBase/E_TowerTalentLevel3Right");
     			}
     			return this.m_E_TowerTalentLevel3RightButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3RightImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3RightImage == null )
     			{
		    		this.m_E_TowerTalentLevel3RightImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3RightBase/E_TowerTalentLevel3Right");
     			}
     			return this.m_E_TowerTalentLevel3RightImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentLevel3LockImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentLevel3LockImage == null )
     			{
		    		this.m_E_TowerTalentLevel3LockImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalent3Base/E_TowerTalentLevel3Lock");
     			}
     			return this.m_E_TowerTalentLevel3LockImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerSpendMoneyBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerSpendMoneyBaseImage == null )
     			{
		    		this.m_E_TowerSpendMoneyBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerSpendMoneyBase");
     			}
     			return this.m_E_TowerSpendMoneyBaseImage;
     		}
     	}

		public UnityEngine.UI.Text E_SpendText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SpendText == null )
     			{
		    		this.m_E_SpendText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerSpendMoneyBase/E_Spend");
     			}
     			return this.m_E_SpendText;
     		}
     	}

		public UnityEngine.UI.Image E_TowerSpendMoneyLeftImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerSpendMoneyLeftImage == null )
     			{
		    		this.m_E_TowerSpendMoneyLeftImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerSpendMoneyBase/E_TowerSpendMoneyLeft");
     			}
     			return this.m_E_TowerSpendMoneyLeftImage;
     		}
     	}

		public UnityEngine.UI.Text E_TowerSpendMoneyNumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerSpendMoneyNumberText == null )
     			{
		    		this.m_E_TowerSpendMoneyNumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerSpendMoneyBase/E_TowerSpendMoneyNumber");
     			}
     			return this.m_E_TowerSpendMoneyNumberText;
     		}
     	}

		public UnityEngine.UI.Image E_SplitImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SplitImage == null )
     			{
		    		this.m_E_SplitImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_Split");
     			}
     			return this.m_E_SplitImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentResetBaseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentResetBaseButton == null )
     			{
		    		this.m_E_TowerTalentResetBaseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentResetBase");
     			}
     			return this.m_E_TowerTalentResetBaseButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentResetBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentResetBaseImage == null )
     			{
		    		this.m_E_TowerTalentResetBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentResetBase");
     			}
     			return this.m_E_TowerTalentResetBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentResetImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentResetImage == null )
     			{
		    		this.m_E_TowerTalentResetImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentResetBase/E_TowerTalentReset");
     			}
     			return this.m_E_TowerTalentResetImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerTalentUpgradeBaseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentUpgradeBaseButton == null )
     			{
		    		this.m_E_TowerTalentUpgradeBaseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentUpgradeBase");
     			}
     			return this.m_E_TowerTalentUpgradeBaseButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentUpgradeBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentUpgradeBaseImage == null )
     			{
		    		this.m_E_TowerTalentUpgradeBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentUpgradeBase");
     			}
     			return this.m_E_TowerTalentUpgradeBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentUpgradeImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentUpgradeImage == null )
     			{
		    		this.m_E_TowerTalentUpgradeImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentUpgradeBase/E_TowerTalentUpgrade");
     			}
     			return this.m_E_TowerTalentUpgradeImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentMaxBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentMaxBaseImage == null )
     			{
		    		this.m_E_TowerTalentMaxBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentMaxBase");
     			}
     			return this.m_E_TowerTalentMaxBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerTalentMaxImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerTalentMaxImage == null )
     			{
		    		this.m_E_TowerTalentMaxImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_TowerPart/E_TowerInfoTalentBase/E_TowerTalentBase/E_TowerTalentMaxBase/E_TowerTalentMax");
     			}
     			return this.m_E_TowerTalentMaxImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterPartImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterPartImage == null )
     			{
		    		this.m_E_MonsterPartImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart");
     			}
     			return this.m_E_MonsterPartImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterBgImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterBgImage == null )
     			{
		    		this.m_E_MonsterBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterBg");
     			}
     			return this.m_E_MonsterBgImage;
     		}
     	}

		public UnityEngine.UI.Button E_MonsterLeftPageBtButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterLeftPageBtButton == null )
     			{
		    		this.m_E_MonsterLeftPageBtButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterBg/E_MonsterLeftPageBt");
     			}
     			return this.m_E_MonsterLeftPageBtButton;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterLeftPageBtImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterLeftPageBtImage == null )
     			{
		    		this.m_E_MonsterLeftPageBtImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterBg/E_MonsterLeftPageBt");
     			}
     			return this.m_E_MonsterLeftPageBtImage;
     		}
     	}

		public UnityEngine.UI.Button E_MonsterRightPageBtButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterRightPageBtButton == null )
     			{
		    		this.m_E_MonsterRightPageBtButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterBg/E_MonsterRightPageBt");
     			}
     			return this.m_E_MonsterRightPageBtButton;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterRightPageBtImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterRightPageBtImage == null )
     			{
		    		this.m_E_MonsterRightPageBtImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterBg/E_MonsterRightPageBt");
     			}
     			return this.m_E_MonsterRightPageBtImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterIndexPageBgImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterIndexPageBgImage == null )
     			{
		    		this.m_E_MonsterIndexPageBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterBg/E_MonsterIndexPageBg");
     			}
     			return this.m_E_MonsterIndexPageBgImage;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterIndexPageNumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterIndexPageNumberText == null )
     			{
		    		this.m_E_MonsterIndexPageNumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterBg/E_MonsterIndexPageBg/E_MonsterIndexPageNumber");
     			}
     			return this.m_E_MonsterIndexPageNumberText;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect E_MonstersLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonstersLoopVerticalScrollRect == null )
     			{
		    		this.m_E_MonstersLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_Monsters");
     			}
     			return this.m_E_MonstersLoopVerticalScrollRect;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterInfoBgImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterInfoBgImage == null )
     			{
		    		this.m_E_MonsterInfoBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg");
     			}
     			return this.m_E_MonsterInfoBgImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterChooseIconBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterChooseIconBaseImage == null )
     			{
		    		this.m_E_MonsterChooseIconBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterChooseIconBase");
     			}
     			return this.m_E_MonsterChooseIconBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterChooseIconImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterChooseIconImage == null )
     			{
		    		this.m_E_MonsterChooseIconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterChooseIconBase/E_MonsterChooseIcon");
     			}
     			return this.m_E_MonsterChooseIconImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterNameBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterNameBaseImage == null )
     			{
		    		this.m_E_MonsterNameBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterNameBase");
     			}
     			return this.m_E_MonsterNameBaseImage;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterNameText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterNameText == null )
     			{
		    		this.m_E_MonsterNameText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterNameBase/E_MonsterName");
     			}
     			return this.m_E_MonsterNameText;
     		}
     	}

		public UnityEngine.UI.Image E_Split3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Split3Image == null )
     			{
		    		this.m_E_Split3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_Split3");
     			}
     			return this.m_E_Split3Image;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterDescriptionBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterDescriptionBaseImage == null )
     			{
		    		this.m_E_MonsterDescriptionBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterDescriptionBase");
     			}
     			return this.m_E_MonsterDescriptionBaseImage;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterDescriptionText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterDescriptionText == null )
     			{
		    		this.m_E_MonsterDescriptionText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterDescriptionBase/E_MonsterDescription");
     			}
     			return this.m_E_MonsterDescriptionText;
     		}
     	}

		public UnityEngine.UI.Image E_Split4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Split4Image == null )
     			{
		    		this.m_E_Split4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_Split4");
     			}
     			return this.m_E_Split4Image;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterPropertiesAllImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterPropertiesAllImage == null )
     			{
		    		this.m_E_MonsterPropertiesAllImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll");
     			}
     			return this.m_E_MonsterPropertiesAllImage;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterProperties1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties1Image == null )
     			{
		    		this.m_E_MonsterProperties1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties1");
     			}
     			return this.m_E_MonsterProperties1Image;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterProperties1NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties1NumberText == null )
     			{
		    		this.m_E_MonsterProperties1NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties1/E_MonsterProperties1Number");
     			}
     			return this.m_E_MonsterProperties1NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterProperties2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties2Image == null )
     			{
		    		this.m_E_MonsterProperties2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties2");
     			}
     			return this.m_E_MonsterProperties2Image;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterProperties2NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties2NumberText == null )
     			{
		    		this.m_E_MonsterProperties2NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties2/E_MonsterProperties2Number");
     			}
     			return this.m_E_MonsterProperties2NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterProperties3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties3Image == null )
     			{
		    		this.m_E_MonsterProperties3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties3");
     			}
     			return this.m_E_MonsterProperties3Image;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterProperties3NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties3NumberText == null )
     			{
		    		this.m_E_MonsterProperties3NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties3/E_MonsterProperties3Number");
     			}
     			return this.m_E_MonsterProperties3NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterProperties4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties4Image == null )
     			{
		    		this.m_E_MonsterProperties4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties4");
     			}
     			return this.m_E_MonsterProperties4Image;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterProperties4NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties4NumberText == null )
     			{
		    		this.m_E_MonsterProperties4NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties4/E_MonsterProperties4Number");
     			}
     			return this.m_E_MonsterProperties4NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterProperties5Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties5Image == null )
     			{
		    		this.m_E_MonsterProperties5Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties5");
     			}
     			return this.m_E_MonsterProperties5Image;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterProperties5NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties5NumberText == null )
     			{
		    		this.m_E_MonsterProperties5NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties5/E_MonsterProperties5Number");
     			}
     			return this.m_E_MonsterProperties5NumberText;
     		}
     	}

		public UnityEngine.UI.Image E_MonsterProperties6Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties6Image == null )
     			{
		    		this.m_E_MonsterProperties6Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties6");
     			}
     			return this.m_E_MonsterProperties6Image;
     		}
     	}

		public UnityEngine.UI.Text E_MonsterProperties6NumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonsterProperties6NumberText == null )
     			{
		    		this.m_E_MonsterProperties6NumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_BookBase/E_MonsterPart/E_MonsterInfoBg/E_MonsterPropertiesAll/E_MonsterProperties6/E_MonsterProperties6Number");
     			}
     			return this.m_E_MonsterProperties6NumberText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_BackBaseButton = null;
			this.m_E_BackBaseImage = null;
			this.m_E_Back1Image = null;
			this.m_E_Back2Image = null;
			this.m_E_BookBaseImage = null;
			this.m_E_IndexImage = null;
			this.m_E_LabelTowerButton = null;
			this.m_E_LabelTowerImage = null;
			this.m_E_TowerStateImage = null;
			this.m_E_LabelMonsterButton = null;
			this.m_E_LabelMonsterImage = null;
			this.m_E_MonsterStateImage = null;
			this.m_E_LabelPetButton = null;
			this.m_E_LabelPetImage = null;
			this.m_E_PetStateImage = null;
			this.m_E_TowerPartImage = null;
			this.m_E_TowerBgImage = null;
			this.m_E_TowerTitleImage = null;
			this.m_E_TowerLevel1Image = null;
			this.m_E_TowerLevel2Image = null;
			this.m_E_TowerLevel3Image = null;
			this.m_E_TowerLeftPageBtButton = null;
			this.m_E_TowerLeftPageBtImage = null;
			this.m_E_TowerRightPageBtButton = null;
			this.m_E_TowerRightPageBtImage = null;
			this.m_E_TowerIndexPageBgImage = null;
			this.m_E_TowerIndexPageNumberText = null;
			this.m_E_TowersLoopVerticalScrollRect = null;
			this.m_E_TowerInfoTalentBaseImage = null;
			this.m_E_TowerInfoTalentTitleBaseImage = null;
			this.m_E_TowerInfoTalentTitleImage = null;
			this.m_E_TowerInfoButton = null;
			this.m_E_TowerInfoImage = null;
			this.m_E_TowerTalentButton = null;
			this.m_E_TowerTalentImage = null;
			this.m_E_TowerInfoBaseImage = null;
			this.m_E_TowerNameBaseImage = null;
			this.m_E_TowerNameText = null;
			this.m_E_TowerInfoIconBaseImage = null;
			this.m_E_TowerInfoIconImage = null;
			this.m_E_Split1Image = null;
			this.m_E_TowerInfoDescriptionBaseImage = null;
			this.m_E_TowerInfoDescriptionText = null;
			this.m_E_Split2Image = null;
			this.m_E_TowerPropertiesAllImage = null;
			this.m_E_TowerProperties1Image = null;
			this.m_E_TowerProperties1NumberText = null;
			this.m_E_TowerProperties2Image = null;
			this.m_E_TowerProperties2NumberText = null;
			this.m_E_TowerProperties3Image = null;
			this.m_E_TowerProperties3NumberText = null;
			this.m_E_TowerProperties4Image = null;
			this.m_E_TowerProperties4NumberText = null;
			this.m_E_TowerTalentBaseImage = null;
			this.m_E_TowerTalent1BaseImage = null;
			this.m_E_TowerTalentLevel1Image = null;
			this.m_E_TowerTalentLevel1LeftArrowImage = null;
			this.m_E_TowerTalentLevel1LeftBaseImage = null;
			this.m_E_TowerTalentLevel1LeftButton = null;
			this.m_E_TowerTalentLevel1LeftImage = null;
			this.m_E_TowerTalentLevel1RightArrowImage = null;
			this.m_E_TowerTalentLevel1RightBaseImage = null;
			this.m_E_TowerTalentLevel1RightButton = null;
			this.m_E_TowerTalentLevel1RightImage = null;
			this.m_E_TowerTalentLevel1LockImage = null;
			this.m_E_TowerTalent2BaseImage = null;
			this.m_E_TowerTalentLevel2Image = null;
			this.m_E_TowerTalentLevel2LeftArrowImage = null;
			this.m_E_TowerTalentLevel2LeftBaseImage = null;
			this.m_E_TowerTalentLevel2LeftButton = null;
			this.m_E_TowerTalentLevel2LeftImage = null;
			this.m_E_TowerTalentLevel2RightArrowImage = null;
			this.m_E_TowerTalentLevel2RightBaseImage = null;
			this.m_E_TowerTalentLevel2RightButton = null;
			this.m_E_TowerTalentLevel2RightImage = null;
			this.m_E_TowerTalentLevel2LockImage = null;
			this.m_E_TowerTalent3BaseImage = null;
			this.m_E_TowerTalentLevel3Image = null;
			this.m_E_TowerTalentLevel3LeftArrowImage = null;
			this.m_E_TowerTalentLevel3LeftBaseImage = null;
			this.m_E_TowerTalentLevel3LeftButton = null;
			this.m_E_TowerTalentLevel3LeftImage = null;
			this.m_E_TowerTalentLevel3RightArrowImage = null;
			this.m_E_TowerTalentLevel3RightBaseImage = null;
			this.m_E_TowerTalentLevel3RightButton = null;
			this.m_E_TowerTalentLevel3RightImage = null;
			this.m_E_TowerTalentLevel3LockImage = null;
			this.m_E_TowerSpendMoneyBaseImage = null;
			this.m_E_SpendText = null;
			this.m_E_TowerSpendMoneyLeftImage = null;
			this.m_E_TowerSpendMoneyNumberText = null;
			this.m_E_SplitImage = null;
			this.m_E_TowerTalentResetBaseButton = null;
			this.m_E_TowerTalentResetBaseImage = null;
			this.m_E_TowerTalentResetImage = null;
			this.m_E_TowerTalentUpgradeBaseButton = null;
			this.m_E_TowerTalentUpgradeBaseImage = null;
			this.m_E_TowerTalentUpgradeImage = null;
			this.m_E_TowerTalentMaxBaseImage = null;
			this.m_E_TowerTalentMaxImage = null;
			this.m_E_MonsterPartImage = null;
			this.m_E_MonsterBgImage = null;
			this.m_E_MonsterLeftPageBtButton = null;
			this.m_E_MonsterLeftPageBtImage = null;
			this.m_E_MonsterRightPageBtButton = null;
			this.m_E_MonsterRightPageBtImage = null;
			this.m_E_MonsterIndexPageBgImage = null;
			this.m_E_MonsterIndexPageNumberText = null;
			this.m_E_MonstersLoopVerticalScrollRect = null;
			this.m_E_MonsterInfoBgImage = null;
			this.m_E_MonsterChooseIconBaseImage = null;
			this.m_E_MonsterChooseIconImage = null;
			this.m_E_MonsterNameBaseImage = null;
			this.m_E_MonsterNameText = null;
			this.m_E_Split3Image = null;
			this.m_E_MonsterDescriptionBaseImage = null;
			this.m_E_MonsterDescriptionText = null;
			this.m_E_Split4Image = null;
			this.m_E_MonsterPropertiesAllImage = null;
			this.m_E_MonsterProperties1Image = null;
			this.m_E_MonsterProperties1NumberText = null;
			this.m_E_MonsterProperties2Image = null;
			this.m_E_MonsterProperties2NumberText = null;
			this.m_E_MonsterProperties3Image = null;
			this.m_E_MonsterProperties3NumberText = null;
			this.m_E_MonsterProperties4Image = null;
			this.m_E_MonsterProperties4NumberText = null;
			this.m_E_MonsterProperties5Image = null;
			this.m_E_MonsterProperties5NumberText = null;
			this.m_E_MonsterProperties6Image = null;
			this.m_E_MonsterProperties6NumberText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_BackBaseButton = null;
		private UnityEngine.UI.Image m_E_BackBaseImage = null;
		private UnityEngine.UI.Image m_E_Back1Image = null;
		private UnityEngine.UI.Image m_E_Back2Image = null;
		private UnityEngine.UI.Image m_E_BookBaseImage = null;
		private UnityEngine.UI.Image m_E_IndexImage = null;
		private UnityEngine.UI.Button m_E_LabelTowerButton = null;
		private UnityEngine.UI.Image m_E_LabelTowerImage = null;
		private UnityEngine.UI.Image m_E_TowerStateImage = null;
		private UnityEngine.UI.Button m_E_LabelMonsterButton = null;
		private UnityEngine.UI.Image m_E_LabelMonsterImage = null;
		private UnityEngine.UI.Image m_E_MonsterStateImage = null;
		private UnityEngine.UI.Button m_E_LabelPetButton = null;
		private UnityEngine.UI.Image m_E_LabelPetImage = null;
		private UnityEngine.UI.Image m_E_PetStateImage = null;
		private UnityEngine.UI.Image m_E_TowerPartImage = null;
		private UnityEngine.UI.Image m_E_TowerBgImage = null;
		private UnityEngine.UI.Image m_E_TowerTitleImage = null;
		private UnityEngine.UI.Image m_E_TowerLevel1Image = null;
		private UnityEngine.UI.Image m_E_TowerLevel2Image = null;
		private UnityEngine.UI.Image m_E_TowerLevel3Image = null;
		private UnityEngine.UI.Button m_E_TowerLeftPageBtButton = null;
		private UnityEngine.UI.Image m_E_TowerLeftPageBtImage = null;
		private UnityEngine.UI.Button m_E_TowerRightPageBtButton = null;
		private UnityEngine.UI.Image m_E_TowerRightPageBtImage = null;
		private UnityEngine.UI.Image m_E_TowerIndexPageBgImage = null;
		private UnityEngine.UI.Text m_E_TowerIndexPageNumberText = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_E_TowersLoopVerticalScrollRect = null;
		private UnityEngine.UI.Image m_E_TowerInfoTalentBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerInfoTalentTitleBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerInfoTalentTitleImage = null;
		private UnityEngine.UI.Button m_E_TowerInfoButton = null;
		private UnityEngine.UI.Image m_E_TowerInfoImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentImage = null;
		private UnityEngine.UI.Image m_E_TowerInfoBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerNameBaseImage = null;
		private UnityEngine.UI.Text m_E_TowerNameText = null;
		private UnityEngine.UI.Image m_E_TowerInfoIconBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerInfoIconImage = null;
		private UnityEngine.UI.Image m_E_Split1Image = null;
		private UnityEngine.UI.Image m_E_TowerInfoDescriptionBaseImage = null;
		private UnityEngine.UI.Text m_E_TowerInfoDescriptionText = null;
		private UnityEngine.UI.Image m_E_Split2Image = null;
		private UnityEngine.UI.Image m_E_TowerPropertiesAllImage = null;
		private UnityEngine.UI.Image m_E_TowerProperties1Image = null;
		private UnityEngine.UI.Text m_E_TowerProperties1NumberText = null;
		private UnityEngine.UI.Image m_E_TowerProperties2Image = null;
		private UnityEngine.UI.Text m_E_TowerProperties2NumberText = null;
		private UnityEngine.UI.Image m_E_TowerProperties3Image = null;
		private UnityEngine.UI.Text m_E_TowerProperties3NumberText = null;
		private UnityEngine.UI.Image m_E_TowerProperties4Image = null;
		private UnityEngine.UI.Text m_E_TowerProperties4NumberText = null;
		private UnityEngine.UI.Image m_E_TowerTalentBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerTalent1BaseImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1Image = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1LeftArrowImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1LeftBaseImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentLevel1LeftButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1LeftImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1RightArrowImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1RightBaseImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentLevel1RightButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1RightImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel1LockImage = null;
		private UnityEngine.UI.Image m_E_TowerTalent2BaseImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2Image = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2LeftArrowImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2LeftBaseImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentLevel2LeftButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2LeftImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2RightArrowImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2RightBaseImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentLevel2RightButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2RightImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel2LockImage = null;
		private UnityEngine.UI.Image m_E_TowerTalent3BaseImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3Image = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3LeftArrowImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3LeftBaseImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentLevel3LeftButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3LeftImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3RightArrowImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3RightBaseImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentLevel3RightButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3RightImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentLevel3LockImage = null;
		private UnityEngine.UI.Image m_E_TowerSpendMoneyBaseImage = null;
		private UnityEngine.UI.Text m_E_SpendText = null;
		private UnityEngine.UI.Image m_E_TowerSpendMoneyLeftImage = null;
		private UnityEngine.UI.Text m_E_TowerSpendMoneyNumberText = null;
		private UnityEngine.UI.Image m_E_SplitImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentResetBaseButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentResetBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentResetImage = null;
		private UnityEngine.UI.Button m_E_TowerTalentUpgradeBaseButton = null;
		private UnityEngine.UI.Image m_E_TowerTalentUpgradeBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentUpgradeImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentMaxBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerTalentMaxImage = null;
		private UnityEngine.UI.Image m_E_MonsterPartImage = null;
		private UnityEngine.UI.Image m_E_MonsterBgImage = null;
		private UnityEngine.UI.Button m_E_MonsterLeftPageBtButton = null;
		private UnityEngine.UI.Image m_E_MonsterLeftPageBtImage = null;
		private UnityEngine.UI.Button m_E_MonsterRightPageBtButton = null;
		private UnityEngine.UI.Image m_E_MonsterRightPageBtImage = null;
		private UnityEngine.UI.Image m_E_MonsterIndexPageBgImage = null;
		private UnityEngine.UI.Text m_E_MonsterIndexPageNumberText = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_E_MonstersLoopVerticalScrollRect = null;
		private UnityEngine.UI.Image m_E_MonsterInfoBgImage = null;
		private UnityEngine.UI.Image m_E_MonsterChooseIconBaseImage = null;
		private UnityEngine.UI.Image m_E_MonsterChooseIconImage = null;
		private UnityEngine.UI.Image m_E_MonsterNameBaseImage = null;
		private UnityEngine.UI.Text m_E_MonsterNameText = null;
		private UnityEngine.UI.Image m_E_Split3Image = null;
		private UnityEngine.UI.Image m_E_MonsterDescriptionBaseImage = null;
		private UnityEngine.UI.Text m_E_MonsterDescriptionText = null;
		private UnityEngine.UI.Image m_E_Split4Image = null;
		private UnityEngine.UI.Image m_E_MonsterPropertiesAllImage = null;
		private UnityEngine.UI.Image m_E_MonsterProperties1Image = null;
		private UnityEngine.UI.Text m_E_MonsterProperties1NumberText = null;
		private UnityEngine.UI.Image m_E_MonsterProperties2Image = null;
		private UnityEngine.UI.Text m_E_MonsterProperties2NumberText = null;
		private UnityEngine.UI.Image m_E_MonsterProperties3Image = null;
		private UnityEngine.UI.Text m_E_MonsterProperties3NumberText = null;
		private UnityEngine.UI.Image m_E_MonsterProperties4Image = null;
		private UnityEngine.UI.Text m_E_MonsterProperties4NumberText = null;
		private UnityEngine.UI.Image m_E_MonsterProperties5Image = null;
		private UnityEngine.UI.Text m_E_MonsterProperties5NumberText = null;
		private UnityEngine.UI.Image m_E_MonsterProperties6Image = null;
		private UnityEngine.UI.Text m_E_MonsterProperties6NumberText = null;
		public Transform uiTransform = null;
	}
}
