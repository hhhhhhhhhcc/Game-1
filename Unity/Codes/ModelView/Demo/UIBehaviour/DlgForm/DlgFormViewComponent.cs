
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

		public UnityEngine.UI.Image E_TowerFormsImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerFormsImage == null )
     			{
		    		this.m_E_TowerFormsImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms");
     			}
     			return this.m_E_TowerFormsImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower1_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1_ImageButton == null )
     			{
		    		this.m_E_Tower1_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower1/E_Tower1_Image");
     			}
     			return this.m_E_Tower1_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower1_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1_ImageImage == null )
     			{
		    		this.m_E_Tower1_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower1/E_Tower1_Image");
     			}
     			return this.m_E_Tower1_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower1CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1CancleButton == null )
     			{
		    		this.m_E_Tower1CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower1/E_Tower1Cancle");
     			}
     			return this.m_E_Tower1CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower1CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1CancleImage == null )
     			{
		    		this.m_E_Tower1CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower1/E_Tower1Cancle");
     			}
     			return this.m_E_Tower1CancleImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower2_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower2_ImageButton == null )
     			{
		    		this.m_E_Tower2_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower2/E_Tower2_Image");
     			}
     			return this.m_E_Tower2_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower2_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower2_ImageImage == null )
     			{
		    		this.m_E_Tower2_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower2/E_Tower2_Image");
     			}
     			return this.m_E_Tower2_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower2CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower2CancleButton == null )
     			{
		    		this.m_E_Tower2CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower2/E_Tower2Cancle");
     			}
     			return this.m_E_Tower2CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower2CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower2CancleImage == null )
     			{
		    		this.m_E_Tower2CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower2/E_Tower2Cancle");
     			}
     			return this.m_E_Tower2CancleImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower3_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower3_ImageButton == null )
     			{
		    		this.m_E_Tower3_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower3/E_Tower3_Image");
     			}
     			return this.m_E_Tower3_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower3_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower3_ImageImage == null )
     			{
		    		this.m_E_Tower3_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower3/E_Tower3_Image");
     			}
     			return this.m_E_Tower3_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower3CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower3CancleButton == null )
     			{
		    		this.m_E_Tower3CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower3/E_Tower3Cancle");
     			}
     			return this.m_E_Tower3CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower3CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower3CancleImage == null )
     			{
		    		this.m_E_Tower3CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower3/E_Tower3Cancle");
     			}
     			return this.m_E_Tower3CancleImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower4_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower4_ImageButton == null )
     			{
		    		this.m_E_Tower4_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower4/E_Tower4_Image");
     			}
     			return this.m_E_Tower4_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower4_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower4_ImageImage == null )
     			{
		    		this.m_E_Tower4_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower4/E_Tower4_Image");
     			}
     			return this.m_E_Tower4_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Tower4CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower4CancleButton == null )
     			{
		    		this.m_E_Tower4CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower4/E_Tower4Cancle");
     			}
     			return this.m_E_Tower4CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Tower4CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower4CancleImage == null )
     			{
		    		this.m_E_Tower4CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_TowerForms/Tower4/E_Tower4Cancle");
     			}
     			return this.m_E_Tower4CancleImage;
     		}
     	}

		public UnityEngine.UI.Image E_PetFormsImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PetFormsImage == null )
     			{
		    		this.m_E_PetFormsImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms");
     			}
     			return this.m_E_PetFormsImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet1_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet1_ImageButton == null )
     			{
		    		this.m_E_Pet1_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet1/E_Pet1_Image");
     			}
     			return this.m_E_Pet1_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet1_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet1_ImageImage == null )
     			{
		    		this.m_E_Pet1_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet1/E_Pet1_Image");
     			}
     			return this.m_E_Pet1_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet1CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet1CancleButton == null )
     			{
		    		this.m_E_Pet1CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet1/E_Pet1Cancle");
     			}
     			return this.m_E_Pet1CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet1CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet1CancleImage == null )
     			{
		    		this.m_E_Pet1CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet1/E_Pet1Cancle");
     			}
     			return this.m_E_Pet1CancleImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet2_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet2_ImageButton == null )
     			{
		    		this.m_E_Pet2_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet2/E_Pet2_Image");
     			}
     			return this.m_E_Pet2_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet2_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet2_ImageImage == null )
     			{
		    		this.m_E_Pet2_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet2/E_Pet2_Image");
     			}
     			return this.m_E_Pet2_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet2CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet2CancleButton == null )
     			{
		    		this.m_E_Pet2CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet2/E_Pet2Cancle");
     			}
     			return this.m_E_Pet2CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet2CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet2CancleImage == null )
     			{
		    		this.m_E_Pet2CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet2/E_Pet2Cancle");
     			}
     			return this.m_E_Pet2CancleImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet3_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet3_ImageButton == null )
     			{
		    		this.m_E_Pet3_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet3/E_Pet3_Image");
     			}
     			return this.m_E_Pet3_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet3_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet3_ImageImage == null )
     			{
		    		this.m_E_Pet3_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet3/E_Pet3_Image");
     			}
     			return this.m_E_Pet3_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet3CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet3CancleButton == null )
     			{
		    		this.m_E_Pet3CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet3/E_Pet3Cancle");
     			}
     			return this.m_E_Pet3CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet3CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet3CancleImage == null )
     			{
		    		this.m_E_Pet3CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet3/E_Pet3Cancle");
     			}
     			return this.m_E_Pet3CancleImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet4_ImageButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet4_ImageButton == null )
     			{
		    		this.m_E_Pet4_ImageButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet4/E_Pet4_Image");
     			}
     			return this.m_E_Pet4_ImageButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet4_ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet4_ImageImage == null )
     			{
		    		this.m_E_Pet4_ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet4/E_Pet4_Image");
     			}
     			return this.m_E_Pet4_ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_Pet4CancleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet4CancleButton == null )
     			{
		    		this.m_E_Pet4CancleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet4/E_Pet4Cancle");
     			}
     			return this.m_E_Pet4CancleButton;
     		}
     	}

		public UnityEngine.UI.Image E_Pet4CancleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Pet4CancleImage == null )
     			{
		    		this.m_E_Pet4CancleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_PetForms/Pet4/E_Pet4Cancle");
     			}
     			return this.m_E_Pet4CancleImage;
     		}
     	}

		public UnityEngine.UI.Button E_ConfirmButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ConfirmButton == null )
     			{
		    		this.m_E_ConfirmButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_Confirm");
     			}
     			return this.m_E_ConfirmButton;
     		}
     	}

		public UnityEngine.UI.Image E_ConfirmImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ConfirmImage == null )
     			{
		    		this.m_E_ConfirmImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Bg/FormAdjust/E_NowFormBg/E_Confirm");
     			}
     			return this.m_E_ConfirmImage;
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
			this.m_E_TowerFormsImage = null;
			this.m_E_Tower1_ImageButton = null;
			this.m_E_Tower1_ImageImage = null;
			this.m_E_Tower1CancleButton = null;
			this.m_E_Tower1CancleImage = null;
			this.m_E_Tower2_ImageButton = null;
			this.m_E_Tower2_ImageImage = null;
			this.m_E_Tower2CancleButton = null;
			this.m_E_Tower2CancleImage = null;
			this.m_E_Tower3_ImageButton = null;
			this.m_E_Tower3_ImageImage = null;
			this.m_E_Tower3CancleButton = null;
			this.m_E_Tower3CancleImage = null;
			this.m_E_Tower4_ImageButton = null;
			this.m_E_Tower4_ImageImage = null;
			this.m_E_Tower4CancleButton = null;
			this.m_E_Tower4CancleImage = null;
			this.m_E_PetFormsImage = null;
			this.m_E_Pet1_ImageButton = null;
			this.m_E_Pet1_ImageImage = null;
			this.m_E_Pet1CancleButton = null;
			this.m_E_Pet1CancleImage = null;
			this.m_E_Pet2_ImageButton = null;
			this.m_E_Pet2_ImageImage = null;
			this.m_E_Pet2CancleButton = null;
			this.m_E_Pet2CancleImage = null;
			this.m_E_Pet3_ImageButton = null;
			this.m_E_Pet3_ImageImage = null;
			this.m_E_Pet3CancleButton = null;
			this.m_E_Pet3CancleImage = null;
			this.m_E_Pet4_ImageButton = null;
			this.m_E_Pet4_ImageImage = null;
			this.m_E_Pet4CancleButton = null;
			this.m_E_Pet4CancleImage = null;
			this.m_E_ConfirmButton = null;
			this.m_E_ConfirmImage = null;
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
		private UnityEngine.UI.Image m_E_TowerFormsImage = null;
		private UnityEngine.UI.Button m_E_Tower1_ImageButton = null;
		private UnityEngine.UI.Image m_E_Tower1_ImageImage = null;
		private UnityEngine.UI.Button m_E_Tower1CancleButton = null;
		private UnityEngine.UI.Image m_E_Tower1CancleImage = null;
		private UnityEngine.UI.Button m_E_Tower2_ImageButton = null;
		private UnityEngine.UI.Image m_E_Tower2_ImageImage = null;
		private UnityEngine.UI.Button m_E_Tower2CancleButton = null;
		private UnityEngine.UI.Image m_E_Tower2CancleImage = null;
		private UnityEngine.UI.Button m_E_Tower3_ImageButton = null;
		private UnityEngine.UI.Image m_E_Tower3_ImageImage = null;
		private UnityEngine.UI.Button m_E_Tower3CancleButton = null;
		private UnityEngine.UI.Image m_E_Tower3CancleImage = null;
		private UnityEngine.UI.Button m_E_Tower4_ImageButton = null;
		private UnityEngine.UI.Image m_E_Tower4_ImageImage = null;
		private UnityEngine.UI.Button m_E_Tower4CancleButton = null;
		private UnityEngine.UI.Image m_E_Tower4CancleImage = null;
		private UnityEngine.UI.Image m_E_PetFormsImage = null;
		private UnityEngine.UI.Button m_E_Pet1_ImageButton = null;
		private UnityEngine.UI.Image m_E_Pet1_ImageImage = null;
		private UnityEngine.UI.Button m_E_Pet1CancleButton = null;
		private UnityEngine.UI.Image m_E_Pet1CancleImage = null;
		private UnityEngine.UI.Button m_E_Pet2_ImageButton = null;
		private UnityEngine.UI.Image m_E_Pet2_ImageImage = null;
		private UnityEngine.UI.Button m_E_Pet2CancleButton = null;
		private UnityEngine.UI.Image m_E_Pet2CancleImage = null;
		private UnityEngine.UI.Button m_E_Pet3_ImageButton = null;
		private UnityEngine.UI.Image m_E_Pet3_ImageImage = null;
		private UnityEngine.UI.Button m_E_Pet3CancleButton = null;
		private UnityEngine.UI.Image m_E_Pet3CancleImage = null;
		private UnityEngine.UI.Button m_E_Pet4_ImageButton = null;
		private UnityEngine.UI.Image m_E_Pet4_ImageImage = null;
		private UnityEngine.UI.Button m_E_Pet4CancleButton = null;
		private UnityEngine.UI.Image m_E_Pet4CancleImage = null;
		private UnityEngine.UI.Button m_E_ConfirmButton = null;
		private UnityEngine.UI.Image m_E_ConfirmImage = null;
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
