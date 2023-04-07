
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgMainHomeViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button EButton_SingeModeButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_SingeModeButton == null )
     			{
		    		this.m_EButton_SingeModeButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Operate/EButton_SingeMode");
     			}
     			return this.m_EButton_SingeModeButton;
     		}
     	}

		public TMPro.TextMeshProUGUI EButton_SingeModeTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_SingeModeTextMeshProUGUI == null )
     			{
		    		this.m_EButton_SingeModeTextMeshProUGUI = UIFindHelper.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"Operate/EButton_SingeMode");
     			}
     			return this.m_EButton_SingeModeTextMeshProUGUI;
     		}
     	}

		public UnityEngine.UI.Text ELabel_SingeModeTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_SingeModeTextText == null )
     			{
		    		this.m_ELabel_SingeModeTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Operate/EButton_SingeMode/ELabel_SingeModeText");
     			}
     			return this.m_ELabel_SingeModeTextText;
     		}
     	}

		public UnityEngine.UI.Button EButton_matchButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_matchButton == null )
     			{
		    		this.m_EButton_matchButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Operate/EButton_match");
     			}
     			return this.m_EButton_matchButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_matchImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_matchImage == null )
     			{
		    		this.m_EButton_matchImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Operate/EButton_match");
     			}
     			return this.m_EButton_matchImage;
     		}
     	}

		public UnityEngine.UI.Button E_OpenFightItemButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_OpenFightItemButton == null )
     			{
		    		this.m_E_OpenFightItemButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Operate/E_OpenFightItem");
     			}
     			return this.m_E_OpenFightItemButton;
     		}
     	}

		public UnityEngine.UI.Image E_OpenFightItemImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_OpenFightItemImage == null )
     			{
		    		this.m_E_OpenFightItemImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Operate/E_OpenFightItem");
     			}
     			return this.m_E_OpenFightItemImage;
     		}
     	}

		public UnityEngine.UI.Text EOpenFightItemTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EOpenFightItemTextText == null )
     			{
		    		this.m_EOpenFightItemTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Operate/E_OpenFightItem/EOpenFightItemText");
     			}
     			return this.m_EOpenFightItemTextText;
     		}
     	}

		public UnityEngine.UI.Button EButton_SettingButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_SettingButton == null )
     			{
		    		this.m_EButton_SettingButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Operate/EButton_Setting");
     			}
     			return this.m_EButton_SettingButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_SettingImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_SettingImage == null )
     			{
		    		this.m_EButton_SettingImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Operate/EButton_Setting");
     			}
     			return this.m_EButton_SettingImage;
     		}
     	}

		public UnityEngine.UI.Button EButton_MasteriesButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_MasteriesButton == null )
     			{
		    		this.m_EButton_MasteriesButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Operate/EButton_Masteries");
     			}
     			return this.m_EButton_MasteriesButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_MasteriesImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_MasteriesImage == null )
     			{
		    		this.m_EButton_MasteriesImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Operate/EButton_Masteries");
     			}
     			return this.m_EButton_MasteriesImage;
     		}
     	}

		public UnityEngine.UI.Button EButton_QuitButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_QuitButton == null )
     			{
		    		this.m_EButton_QuitButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Operate/EButton_Quit");
     			}
     			return this.m_EButton_QuitButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_QuitImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_QuitImage == null )
     			{
		    		this.m_EButton_QuitImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Operate/EButton_Quit");
     			}
     			return this.m_EButton_QuitImage;
     		}
     	}

		public UnityEngine.UI.Image ECoinDispalyImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ECoinDispalyImage == null )
     			{
		    		this.m_ECoinDispalyImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"ECoinDispaly");
     			}
     			return this.m_ECoinDispalyImage;
     		}
     	}

		public TMPro.TextMeshProUGUI EText_CoinNumberTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EText_CoinNumberTextMeshProUGUI == null )
     			{
		    		this.m_EText_CoinNumberTextMeshProUGUI = UIFindHelper.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"ECoinDispaly/EText_CoinNumber");
     			}
     			return this.m_EText_CoinNumberTextMeshProUGUI;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_EButton_SingeModeButton = null;
			this.m_EButton_SingeModeTextMeshProUGUI = null;
			this.m_ELabel_SingeModeTextText = null;
			this.m_EButton_matchButton = null;
			this.m_EButton_matchImage = null;
			this.m_E_OpenFightItemButton = null;
			this.m_E_OpenFightItemImage = null;
			this.m_EOpenFightItemTextText = null;
			this.m_EButton_SettingButton = null;
			this.m_EButton_SettingImage = null;
			this.m_EButton_MasteriesButton = null;
			this.m_EButton_MasteriesImage = null;
			this.m_EButton_QuitButton = null;
			this.m_EButton_QuitImage = null;
			this.m_ECoinDispalyImage = null;
			this.m_EText_CoinNumberTextMeshProUGUI = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_EButton_SingeModeButton = null;
		private TMPro.TextMeshProUGUI m_EButton_SingeModeTextMeshProUGUI = null;
		private UnityEngine.UI.Text m_ELabel_SingeModeTextText = null;
		private UnityEngine.UI.Button m_EButton_matchButton = null;
		private UnityEngine.UI.Image m_EButton_matchImage = null;
		private UnityEngine.UI.Button m_E_OpenFightItemButton = null;
		private UnityEngine.UI.Image m_E_OpenFightItemImage = null;
		private UnityEngine.UI.Text m_EOpenFightItemTextText = null;
		private UnityEngine.UI.Button m_EButton_SettingButton = null;
		private UnityEngine.UI.Image m_EButton_SettingImage = null;
		private UnityEngine.UI.Button m_EButton_MasteriesButton = null;
		private UnityEngine.UI.Image m_EButton_MasteriesImage = null;
		private UnityEngine.UI.Button m_EButton_QuitButton = null;
		private UnityEngine.UI.Image m_EButton_QuitImage = null;
		private UnityEngine.UI.Image m_ECoinDispalyImage = null;
		private TMPro.TextMeshProUGUI m_EText_CoinNumberTextMeshProUGUI = null;
		public Transform uiTransform = null;
	}
}
