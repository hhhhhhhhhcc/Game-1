﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgMainHomeViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Text E_TipText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TipText == null )
     			{
		    		this.m_E_TipText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_Tip");
     			}
     			return this.m_E_TipText;
     		}
     	}

		public UnityEngine.UI.Button EButton_UpButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_UpButton == null )
     			{
		    		this.m_EButton_UpButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Up");
     			}
     			return this.m_EButton_UpButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_UpImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_UpImage == null )
     			{
		    		this.m_EButton_UpImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Up");
     			}
     			return this.m_EButton_UpImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_levelText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_levelText == null )
     			{
		    		this.m_ELabel_levelText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_level");
     			}
     			return this.m_ELabel_levelText;
     		}
     	}

		public UnityEngine.UI.Text ELabel_expText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_expText == null )
     			{
		    		this.m_ELabel_expText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_exp");
     			}
     			return this.m_ELabel_expText;
     		}
     	}

		public UnityEngine.UI.Text ELabel_goldText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_goldText == null )
     			{
		    		this.m_ELabel_goldText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_gold");
     			}
     			return this.m_ELabel_goldText;
     		}
     	}

		public UnityEngine.UI.Text ELabel_dsText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_dsText == null )
     			{
		    		this.m_ELabel_dsText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_ds");
     			}
     			return this.m_ELabel_dsText;
     		}
     	}

		public ES_shuzhi ES_shuzhi1
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_shuzhi1 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"ES_shuzhi1");
		    	   this.m_es_shuzhi1 = this.AddChild<ES_shuzhi,Transform>(subTrans);
     			}
     			return this.m_es_shuzhi1;
     		}
     	}

		public ES_shuzhi ES_shuzhi2
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_shuzhi2 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"ES_shuzhi2");
		    	   this.m_es_shuzhi2 = this.AddChild<ES_shuzhi,Transform>(subTrans);
     			}
     			return this.m_es_shuzhi2;
     		}
     	}

		public ES_shuzhi ES_shuzhi3
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_shuzhi3 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"ES_shuzhi3");
		    	   this.m_es_shuzhi3 = this.AddChild<ES_shuzhi,Transform>(subTrans);
     			}
     			return this.m_es_shuzhi3;
     		}
     	}

		public ES_shuzhi ES_shuzhi4
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_shuzhi4 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"ES_shuzhi4");
		    	   this.m_es_shuzhi4 = this.AddChild<ES_shuzhi,Transform>(subTrans);
     			}
     			return this.m_es_shuzhi4;
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
		    		this.m_EButton_matchButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_match");
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
		    		this.m_EButton_matchImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_match");
     			}
     			return this.m_EButton_matchImage;
     		}
     	}

		public UnityEngine.UI.Button EButton_GetItemButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_GetItemButton == null )
     			{
		    		this.m_EButton_GetItemButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_GetItem");
     			}
     			return this.m_EButton_GetItemButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_GetItemImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_GetItemImage == null )
     			{
		    		this.m_EButton_GetItemImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_GetItem");
     			}
     			return this.m_EButton_GetItemImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_GetItemTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_GetItemTextText == null )
     			{
		    		this.m_ELabel_GetItemTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_GetItem/ELabel_GetItemText");
     			}
     			return this.m_ELabel_GetItemTextText;
     		}
     	}

		public UnityEngine.UI.Button EButton_ReduceItemButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_ReduceItemButton == null )
     			{
		    		this.m_EButton_ReduceItemButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_ReduceItem");
     			}
     			return this.m_EButton_ReduceItemButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_ReduceItemImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_ReduceItemImage == null )
     			{
		    		this.m_EButton_ReduceItemImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_ReduceItem");
     			}
     			return this.m_EButton_ReduceItemImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_ReduceItemTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_ReduceItemTextText == null )
     			{
		    		this.m_ELabel_ReduceItemTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_ReduceItem/ELabel_ReduceItemText");
     			}
     			return this.m_ELabel_ReduceItemTextText;
     		}
     	}

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
		    		this.m_EButton_SingeModeButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_SingeMode");
     			}
     			return this.m_EButton_SingeModeButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_SingeModeImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_SingeModeImage == null )
     			{
		    		this.m_EButton_SingeModeImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_SingeMode");
     			}
     			return this.m_EButton_SingeModeImage;
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
		    		this.m_ELabel_SingeModeTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_SingeMode/ELabel_SingeModeText");
     			}
     			return this.m_ELabel_SingeModeTextText;
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
		    		this.m_E_OpenFightItemButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_OpenFightItem");
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
		    		this.m_E_OpenFightItemImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_OpenFightItem");
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
		    		this.m_EOpenFightItemTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_OpenFightItem/EOpenFightItemText");
     			}
     			return this.m_EOpenFightItemTextText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_TipText = null;
			this.m_EButton_UpButton = null;
			this.m_EButton_UpImage = null;
			this.m_ELabel_levelText = null;
			this.m_ELabel_expText = null;
			this.m_ELabel_goldText = null;
			this.m_ELabel_dsText = null;
			this.m_es_shuzhi1?.Dispose();
			this.m_es_shuzhi1 = null;
			this.m_es_shuzhi2?.Dispose();
			this.m_es_shuzhi2 = null;
			this.m_es_shuzhi3?.Dispose();
			this.m_es_shuzhi3 = null;
			this.m_es_shuzhi4?.Dispose();
			this.m_es_shuzhi4 = null;
			this.m_EButton_matchButton = null;
			this.m_EButton_matchImage = null;
			this.m_EButton_GetItemButton = null;
			this.m_EButton_GetItemImage = null;
			this.m_ELabel_GetItemTextText = null;
			this.m_EButton_ReduceItemButton = null;
			this.m_EButton_ReduceItemImage = null;
			this.m_ELabel_ReduceItemTextText = null;
			this.m_EButton_SingeModeButton = null;
			this.m_EButton_SingeModeImage = null;
			this.m_ELabel_SingeModeTextText = null;
			this.m_E_OpenFightItemButton = null;
			this.m_E_OpenFightItemImage = null;
			this.m_EOpenFightItemTextText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Text m_E_TipText = null;
		private UnityEngine.UI.Button m_EButton_UpButton = null;
		private UnityEngine.UI.Image m_EButton_UpImage = null;
		private UnityEngine.UI.Text m_ELabel_levelText = null;
		private UnityEngine.UI.Text m_ELabel_expText = null;
		private UnityEngine.UI.Text m_ELabel_goldText = null;
		private UnityEngine.UI.Text m_ELabel_dsText = null;
		private ES_shuzhi m_es_shuzhi1 = null;
		private ES_shuzhi m_es_shuzhi2 = null;
		private ES_shuzhi m_es_shuzhi3 = null;
		private ES_shuzhi m_es_shuzhi4 = null;
		private UnityEngine.UI.Button m_EButton_matchButton = null;
		private UnityEngine.UI.Image m_EButton_matchImage = null;
		private UnityEngine.UI.Button m_EButton_GetItemButton = null;
		private UnityEngine.UI.Image m_EButton_GetItemImage = null;
		private UnityEngine.UI.Text m_ELabel_GetItemTextText = null;
		private UnityEngine.UI.Button m_EButton_ReduceItemButton = null;
		private UnityEngine.UI.Image m_EButton_ReduceItemImage = null;
		private UnityEngine.UI.Text m_ELabel_ReduceItemTextText = null;
		private UnityEngine.UI.Button m_EButton_SingeModeButton = null;
		private UnityEngine.UI.Image m_EButton_SingeModeImage = null;
		private UnityEngine.UI.Text m_ELabel_SingeModeTextText = null;
		private UnityEngine.UI.Button m_E_OpenFightItemButton = null;
		private UnityEngine.UI.Image m_E_OpenFightItemImage = null;
		private UnityEngine.UI.Text m_EOpenFightItemTextText = null;
		public Transform uiTransform = null;
	}
}
