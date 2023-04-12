
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgFormViewComponent : Entity,IAwake,IDestroy 
	{
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
		    		this.m_E_IndexImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_Index");
     			}
     			return this.m_E_IndexImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerChooseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerChooseButton == null )
     			{
		    		this.m_E_TowerChooseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_Index/E_TowerChoose");
     			}
     			return this.m_E_TowerChooseButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerChooseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerChooseImage == null )
     			{
		    		this.m_E_TowerChooseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_Index/E_TowerChoose");
     			}
     			return this.m_E_TowerChooseImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerChooseNameImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerChooseNameImage == null )
     			{
		    		this.m_E_TowerChooseNameImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_Index/E_TowerChoose/E_TowerChooseName");
     			}
     			return this.m_E_TowerChooseNameImage;
     		}
     	}

		public UnityEngine.UI.Button E_PetChooseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetChooseButton == null )
     			{
		    		this.m_E_PetChooseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_Index/E_PetChoose");
     			}
     			return this.m_E_PetChooseButton;
     		}
     	}

		public UnityEngine.UI.Image E_PetChooseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetChooseImage == null )
     			{
		    		this.m_E_PetChooseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_Index/E_PetChoose");
     			}
     			return this.m_E_PetChooseImage;
     		}
     	}

		public UnityEngine.UI.Image E_PetChooseNameImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetChooseNameImage == null )
     			{
		    		this.m_E_PetChooseNameImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_Index/E_PetChoose/E_PetChooseName");
     			}
     			return this.m_E_PetChooseNameImage;
     		}
     	}

		public UnityEngine.UI.Image E_PetBgImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetBgImage == null )
     			{
		    		this.m_E_PetBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg");
     			}
     			return this.m_E_PetBgImage;
     		}
     	}

		public UnityEngine.UI.Button E_PetLeftPageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetLeftPageButton == null )
     			{
		    		this.m_E_PetLeftPageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg/E_PetLeftPage");
     			}
     			return this.m_E_PetLeftPageButton;
     		}
     	}

		public UnityEngine.UI.Image E_PetLeftPageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetLeftPageImage == null )
     			{
		    		this.m_E_PetLeftPageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg/E_PetLeftPage");
     			}
     			return this.m_E_PetLeftPageImage;
     		}
     	}

		public UnityEngine.UI.Button E_PetRightPageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetRightPageButton == null )
     			{
		    		this.m_E_PetRightPageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg/E_PetRightPage");
     			}
     			return this.m_E_PetRightPageButton;
     		}
     	}

		public UnityEngine.UI.Image E_PetRightPageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetRightPageImage == null )
     			{
		    		this.m_E_PetRightPageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg/E_PetRightPage");
     			}
     			return this.m_E_PetRightPageImage;
     		}
     	}

		public UnityEngine.UI.Image E_PetIndexPageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetIndexPageImage == null )
     			{
		    		this.m_E_PetIndexPageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg/E_PetIndexPage");
     			}
     			return this.m_E_PetIndexPageImage;
     		}
     	}

		public UnityEngine.UI.Text E_PetIndexTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetIndexTextText == null )
     			{
		    		this.m_E_PetIndexTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg/E_PetIndexPage/E_PetIndexText");
     			}
     			return this.m_E_PetIndexTextText;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect E_PetsLoopScrollListLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetsLoopScrollListLoopVerticalScrollRect == null )
     			{
		    		this.m_E_PetsLoopScrollListLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"Bg/FormAdjust/E_PetBg/E_PetsLoopScrollList");
     			}
     			return this.m_E_PetsLoopScrollListLoopVerticalScrollRect;
     		}
     	}

		public UnityEngine.UI.Image E_NowFormBgImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NowFormBgImage == null )
     			{
		    		this.m_E_NowFormBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg");
     			}
     			return this.m_E_NowFormBgImage;
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
		    		this.m_E_TowerBgImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg");
     			}
     			return this.m_E_TowerBgImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerLeftPageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLeftPageButton == null )
     			{
		    		this.m_E_TowerLeftPageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg/E_TowerLeftPage");
     			}
     			return this.m_E_TowerLeftPageButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerLeftPageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLeftPageImage == null )
     			{
		    		this.m_E_TowerLeftPageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg/E_TowerLeftPage");
     			}
     			return this.m_E_TowerLeftPageImage;
     		}
     	}

		public UnityEngine.UI.Button E_TowerRightPageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerRightPageButton == null )
     			{
		    		this.m_E_TowerRightPageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg/E_TowerRightPage");
     			}
     			return this.m_E_TowerRightPageButton;
     		}
     	}

		public UnityEngine.UI.Image E_TowerRightPageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerRightPageImage == null )
     			{
		    		this.m_E_TowerRightPageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg/E_TowerRightPage");
     			}
     			return this.m_E_TowerRightPageImage;
     		}
     	}

		public UnityEngine.UI.Image E_TowerIndexPageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerIndexPageImage == null )
     			{
		    		this.m_E_TowerIndexPageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg/E_TowerIndexPage");
     			}
     			return this.m_E_TowerIndexPageImage;
     		}
     	}

		public UnityEngine.UI.Text E_TowerIndexTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerIndexTextText == null )
     			{
		    		this.m_E_TowerIndexTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg/E_TowerIndexPage/E_TowerIndexText");
     			}
     			return this.m_E_TowerIndexTextText;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect E_TowerLoopScrollListLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerLoopScrollListLoopVerticalScrollRect == null )
     			{
		    		this.m_E_TowerLoopScrollListLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"Bg/FormAdjust/E_TowerBg/E_TowerLoopScrollList");
     			}
     			return this.m_E_TowerLoopScrollListLoopVerticalScrollRect;
     		}
     	}

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
		    		this.m_E_BackBaseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/E_BackBase");
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
		    		this.m_E_BackBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/E_BackBase");
     			}
     			return this.m_E_BackBaseImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_IndexImage = null;
			this.m_E_TowerChooseButton = null;
			this.m_E_TowerChooseImage = null;
			this.m_E_TowerChooseNameImage = null;
			this.m_E_PetChooseButton = null;
			this.m_E_PetChooseImage = null;
			this.m_E_PetChooseNameImage = null;
			this.m_E_PetBgImage = null;
			this.m_E_PetLeftPageButton = null;
			this.m_E_PetLeftPageImage = null;
			this.m_E_PetRightPageButton = null;
			this.m_E_PetRightPageImage = null;
			this.m_E_PetIndexPageImage = null;
			this.m_E_PetIndexTextText = null;
			this.m_E_PetsLoopScrollListLoopVerticalScrollRect = null;
			this.m_E_NowFormBgImage = null;
			this.m_E_TowerBgImage = null;
			this.m_E_TowerLeftPageButton = null;
			this.m_E_TowerLeftPageImage = null;
			this.m_E_TowerRightPageButton = null;
			this.m_E_TowerRightPageImage = null;
			this.m_E_TowerIndexPageImage = null;
			this.m_E_TowerIndexTextText = null;
			this.m_E_TowerLoopScrollListLoopVerticalScrollRect = null;
			this.m_E_BackBaseButton = null;
			this.m_E_BackBaseImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Image m_E_IndexImage = null;
		private UnityEngine.UI.Button m_E_TowerChooseButton = null;
		private UnityEngine.UI.Image m_E_TowerChooseImage = null;
		private UnityEngine.UI.Image m_E_TowerChooseNameImage = null;
		private UnityEngine.UI.Button m_E_PetChooseButton = null;
		private UnityEngine.UI.Image m_E_PetChooseImage = null;
		private UnityEngine.UI.Image m_E_PetChooseNameImage = null;
		private UnityEngine.UI.Image m_E_PetBgImage = null;
		private UnityEngine.UI.Button m_E_PetLeftPageButton = null;
		private UnityEngine.UI.Image m_E_PetLeftPageImage = null;
		private UnityEngine.UI.Button m_E_PetRightPageButton = null;
		private UnityEngine.UI.Image m_E_PetRightPageImage = null;
		private UnityEngine.UI.Image m_E_PetIndexPageImage = null;
		private UnityEngine.UI.Text m_E_PetIndexTextText = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_E_PetsLoopScrollListLoopVerticalScrollRect = null;
		private UnityEngine.UI.Image m_E_NowFormBgImage = null;
		private UnityEngine.UI.Image m_E_TowerBgImage = null;
		private UnityEngine.UI.Button m_E_TowerLeftPageButton = null;
		private UnityEngine.UI.Image m_E_TowerLeftPageImage = null;
		private UnityEngine.UI.Button m_E_TowerRightPageButton = null;
		private UnityEngine.UI.Image m_E_TowerRightPageImage = null;
		private UnityEngine.UI.Image m_E_TowerIndexPageImage = null;
		private UnityEngine.UI.Text m_E_TowerIndexTextText = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_E_TowerLoopScrollListLoopVerticalScrollRect = null;
		private UnityEngine.UI.Button m_E_BackBaseButton = null;
		private UnityEngine.UI.Image m_E_BackBaseImage = null;
		public Transform uiTransform = null;
	}
}
