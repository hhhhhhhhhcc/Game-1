
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class ESButton_CreateTower : Entity,ET.IAwake<UnityEngine.Transform>,IUpdate,IDestroy 
	{
		public UnityEngine.UI.Button EButton_CreateTowerBaseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateTowerBaseButton == null )
     			{
		    		this.m_EButton_CreateTowerBaseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_CreateTowerBase");
     			}
     			return this.m_EButton_CreateTowerBaseButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_CreateTowerBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateTowerBaseImage == null )
     			{
		    		this.m_EButton_CreateTowerBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_CreateTowerBase");
     			}
     			return this.m_EButton_CreateTowerBaseImage;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger EButton_CreateTowerBaseEventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateTowerBaseEventTrigger == null )
     			{
		    		this.m_EButton_CreateTowerBaseEventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EButton_CreateTowerBase");
     			}
     			return this.m_EButton_CreateTowerBaseEventTrigger;
     		}
     	}

		public UnityEngine.UI.Button EButton_CreateTowerButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateTowerButton == null )
     			{
		    		this.m_EButton_CreateTowerButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_CreateTower");
     			}
     			return this.m_EButton_CreateTowerButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_CreateTowerImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateTowerImage == null )
     			{
		    		this.m_EButton_CreateTowerImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_CreateTower");
     			}
     			return this.m_EButton_CreateTowerImage;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger EButton_CreateTowerEventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateTowerEventTrigger == null )
     			{
		    		this.m_EButton_CreateTowerEventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EButton_CreateTower");
     			}
     			return this.m_EButton_CreateTowerEventTrigger;
     		}
     	}

		public UnityEngine.UI.Image E_TowerRangeImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TowerRangeImage == null )
     			{
		    		this.m_E_TowerRangeImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerRange");
     			}
     			return this.m_E_TowerRangeImage;
     		}
     	}

		public UnityEngine.UI.Image EListImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EListImage == null )
     			{
		    		this.m_EListImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList");
     			}
     			return this.m_EListImage;
     		}
     	}

		public UnityEngine.UI.Image Ecreatebt1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatebt1Image == null )
     			{
		    		this.m_Ecreatebt1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt1");
     			}
     			return this.m_Ecreatebt1Image;
     		}
     	}

		public UnityEngine.UI.Button Espritetower1Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower1Button == null )
     			{
		    		this.m_Espritetower1Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EList/Ecreatebt1/Espritetower1");
     			}
     			return this.m_Espritetower1Button;
     		}
     	}

		public UnityEngine.UI.Image Espritetower1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower1Image == null )
     			{
		    		this.m_Espritetower1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt1/Espritetower1");
     			}
     			return this.m_Espritetower1Image;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger Espritetower1EventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower1EventTrigger == null )
     			{
		    		this.m_Espritetower1EventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EList/Ecreatebt1/Espritetower1");
     			}
     			return this.m_Espritetower1EventTrigger;
     		}
     	}

		public UnityEngine.UI.Image Ecreatemoneybase1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneybase1Image == null )
     			{
		    		this.m_Ecreatemoneybase1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt1/Ecreatemoneybase1");
     			}
     			return this.m_Ecreatemoneybase1Image;
     		}
     	}

		public UnityEngine.UI.Text Ecreatemoneytext1Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneytext1Text == null )
     			{
		    		this.m_Ecreatemoneytext1Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EList/Ecreatebt1/Ecreatemoneytext1");
     			}
     			return this.m_Ecreatemoneytext1Text;
     		}
     	}

		public UnityEngine.UI.Image Ecreatebt2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatebt2Image == null )
     			{
		    		this.m_Ecreatebt2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt2");
     			}
     			return this.m_Ecreatebt2Image;
     		}
     	}

		public UnityEngine.UI.Button Espritetower2Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower2Button == null )
     			{
		    		this.m_Espritetower2Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EList/Ecreatebt2/Espritetower2");
     			}
     			return this.m_Espritetower2Button;
     		}
     	}

		public UnityEngine.UI.Image Espritetower2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower2Image == null )
     			{
		    		this.m_Espritetower2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt2/Espritetower2");
     			}
     			return this.m_Espritetower2Image;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger Espritetower2EventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower2EventTrigger == null )
     			{
		    		this.m_Espritetower2EventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EList/Ecreatebt2/Espritetower2");
     			}
     			return this.m_Espritetower2EventTrigger;
     		}
     	}

		public UnityEngine.UI.Image Ecreatemoneybase2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneybase2Image == null )
     			{
		    		this.m_Ecreatemoneybase2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt2/Ecreatemoneybase2");
     			}
     			return this.m_Ecreatemoneybase2Image;
     		}
     	}

		public UnityEngine.UI.Text Ecreatemoneytext2Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneytext2Text == null )
     			{
		    		this.m_Ecreatemoneytext2Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EList/Ecreatebt2/Ecreatemoneytext2");
     			}
     			return this.m_Ecreatemoneytext2Text;
     		}
     	}

		public UnityEngine.UI.Image Ecreatebt3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatebt3Image == null )
     			{
		    		this.m_Ecreatebt3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt3");
     			}
     			return this.m_Ecreatebt3Image;
     		}
     	}

		public UnityEngine.UI.Button Espritetower3Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower3Button == null )
     			{
		    		this.m_Espritetower3Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EList/Ecreatebt3/Espritetower3");
     			}
     			return this.m_Espritetower3Button;
     		}
     	}

		public UnityEngine.UI.Image Espritetower3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower3Image == null )
     			{
		    		this.m_Espritetower3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt3/Espritetower3");
     			}
     			return this.m_Espritetower3Image;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger Espritetower3EventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower3EventTrigger == null )
     			{
		    		this.m_Espritetower3EventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EList/Ecreatebt3/Espritetower3");
     			}
     			return this.m_Espritetower3EventTrigger;
     		}
     	}

		public UnityEngine.UI.Image Ecreatemoneybase3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneybase3Image == null )
     			{
		    		this.m_Ecreatemoneybase3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt3/Ecreatemoneybase3");
     			}
     			return this.m_Ecreatemoneybase3Image;
     		}
     	}

		public UnityEngine.UI.Text Ecreatemoneytext3Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneytext3Text == null )
     			{
		    		this.m_Ecreatemoneytext3Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EList/Ecreatebt3/Ecreatemoneytext3");
     			}
     			return this.m_Ecreatemoneytext3Text;
     		}
     	}

		public UnityEngine.UI.Image Ecreatebt4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatebt4Image == null )
     			{
		    		this.m_Ecreatebt4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt4");
     			}
     			return this.m_Ecreatebt4Image;
     		}
     	}

		public UnityEngine.UI.Button Espritetower4Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower4Button == null )
     			{
		    		this.m_Espritetower4Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EList/Ecreatebt4/Espritetower4");
     			}
     			return this.m_Espritetower4Button;
     		}
     	}

		public UnityEngine.UI.Image Espritetower4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower4Image == null )
     			{
		    		this.m_Espritetower4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt4/Espritetower4");
     			}
     			return this.m_Espritetower4Image;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger Espritetower4EventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Espritetower4EventTrigger == null )
     			{
		    		this.m_Espritetower4EventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EList/Ecreatebt4/Espritetower4");
     			}
     			return this.m_Espritetower4EventTrigger;
     		}
     	}

		public UnityEngine.UI.Image Ecreatemoneybase4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneybase4Image == null )
     			{
		    		this.m_Ecreatemoneybase4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EList/Ecreatebt4/Ecreatemoneybase4");
     			}
     			return this.m_Ecreatemoneybase4Image;
     		}
     	}

		public UnityEngine.UI.Text Ecreatemoneytext4Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_Ecreatemoneytext4Text == null )
     			{
		    		this.m_Ecreatemoneytext4Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EList/Ecreatebt4/Ecreatemoneytext4");
     			}
     			return this.m_Ecreatemoneytext4Text;
     		}
     	}

		public UnityEngine.UI.Image EUpListImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EUpListImage == null )
     			{
		    		this.m_EUpListImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EUpList");
     			}
     			return this.m_EUpListImage;
     		}
     	}

		public UnityEngine.UI.Button EUpButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EUpButton == null )
     			{
		    		this.m_EUpButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EUpList/EUp");
     			}
     			return this.m_EUpButton;
     		}
     	}

		public UnityEngine.UI.Image EUpImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EUpImage == null )
     			{
		    		this.m_EUpImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EUpList/EUp");
     			}
     			return this.m_EUpImage;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger EUpEventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EUpEventTrigger == null )
     			{
		    		this.m_EUpEventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EUpList/EUp");
     			}
     			return this.m_EUpEventTrigger;
     		}
     	}

		public UnityEngine.UI.Image EUpArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EUpArrowImage == null )
     			{
		    		this.m_EUpArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EUpList/EUp/EUpArrow");
     			}
     			return this.m_EUpArrowImage;
     		}
     	}

		public UnityEngine.UI.Image EUpMoneyImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EUpMoneyImage == null )
     			{
		    		this.m_EUpMoneyImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EUpList/EUp/EUpMoney");
     			}
     			return this.m_EUpMoneyImage;
     		}
     	}

		public UnityEngine.UI.Text EUPMoneyTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EUPMoneyTextText == null )
     			{
		    		this.m_EUPMoneyTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EUpList/EUp/EUPMoneyText");
     			}
     			return this.m_EUPMoneyTextText;
     		}
     	}

		public UnityEngine.UI.Button EDeleteUpButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeleteUpButton == null )
     			{
		    		this.m_EDeleteUpButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EUpList/EDeleteUp");
     			}
     			return this.m_EDeleteUpButton;
     		}
     	}

		public UnityEngine.UI.Image EDeleteUpImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeleteUpImage == null )
     			{
		    		this.m_EDeleteUpImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EUpList/EDeleteUp");
     			}
     			return this.m_EDeleteUpImage;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger EDeleteUpEventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeleteUpEventTrigger == null )
     			{
		    		this.m_EDeleteUpEventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"EUpList/EDeleteUp");
     			}
     			return this.m_EDeleteUpEventTrigger;
     		}
     	}

		public UnityEngine.UI.Image EDeleteSaleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeleteSaleImage == null )
     			{
		    		this.m_EDeleteSaleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EUpList/EDeleteUp/EDeleteSale");
     			}
     			return this.m_EDeleteSaleImage;
     		}
     	}

		public UnityEngine.UI.Image EDeleteMoneyImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeleteMoneyImage == null )
     			{
		    		this.m_EDeleteMoneyImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EUpList/EDeleteUp/EDeleteMoney");
     			}
     			return this.m_EDeleteMoneyImage;
     		}
     	}

		public UnityEngine.UI.Text EDeleteMoneyTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeleteMoneyTextText == null )
     			{
		    		this.m_EDeleteMoneyTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EUpList/EDeleteUp/EDeleteMoneyText");
     			}
     			return this.m_EDeleteMoneyTextText;
     		}
     	}

		public UnityEngine.UI.Button ETowerInfoButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoButton == null )
     			{
		    		this.m_ETowerInfoButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"ETowerInfo");
     			}
     			return this.m_ETowerInfoButton;
     		}
     	}

		public UnityEngine.UI.Image ETowerInfoImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoImage == null )
     			{
		    		this.m_ETowerInfoImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"ETowerInfo");
     			}
     			return this.m_ETowerInfoImage;
     		}
     	}

		public UnityEngine.UI.Image ETowerInfoNameBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoNameBaseImage == null )
     			{
		    		this.m_ETowerInfoNameBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoNameBase");
     			}
     			return this.m_ETowerInfoNameBaseImage;
     		}
     	}

		public UnityEngine.UI.Text ETowerInfoNameTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoNameTextText == null )
     			{
		    		this.m_ETowerInfoNameTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoNameBase/ETowerInfoNameText");
     			}
     			return this.m_ETowerInfoNameTextText;
     		}
     	}

		public UnityEngine.UI.Text ETowerInfoDescriptionText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoDescriptionText == null )
     			{
		    		this.m_ETowerInfoDescriptionText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoDescription");
     			}
     			return this.m_ETowerInfoDescriptionText;
     		}
     	}

		public UnityEngine.UI.Image ETowerInfoAttackBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoAttackBaseImage == null )
     			{
		    		this.m_ETowerInfoAttackBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoAttackBase");
     			}
     			return this.m_ETowerInfoAttackBaseImage;
     		}
     	}

		public UnityEngine.UI.Text ETowerInfoAttackValueText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoAttackValueText == null )
     			{
		    		this.m_ETowerInfoAttackValueText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoAttackBase/ETowerInfoAttackValue");
     			}
     			return this.m_ETowerInfoAttackValueText;
     		}
     	}

		public UnityEngine.UI.Image ETowerInfoAttackIntervalBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoAttackIntervalBaseImage == null )
     			{
		    		this.m_ETowerInfoAttackIntervalBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoAttackIntervalBase");
     			}
     			return this.m_ETowerInfoAttackIntervalBaseImage;
     		}
     	}

		public UnityEngine.UI.Text ETowerInfoAttackIntervalValueText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoAttackIntervalValueText == null )
     			{
		    		this.m_ETowerInfoAttackIntervalValueText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoAttackIntervalBase/ETowerInfoAttackIntervalValue");
     			}
     			return this.m_ETowerInfoAttackIntervalValueText;
     		}
     	}

		public UnityEngine.UI.Image ETowerInfoAttackTypeBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoAttackTypeBaseImage == null )
     			{
		    		this.m_ETowerInfoAttackTypeBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoAttackTypeBase");
     			}
     			return this.m_ETowerInfoAttackTypeBaseImage;
     		}
     	}

		public UnityEngine.UI.Text ETowerInfoAttackTypeValueText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ETowerInfoAttackTypeValueText == null )
     			{
		    		this.m_ETowerInfoAttackTypeValueText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ETowerInfo/ETowerInfoAttackTypeBase/ETowerInfoAttackTypeValue");
     			}
     			return this.m_ETowerInfoAttackTypeValueText;
     		}
     	}

		public UnityEngine.UI.Button E_PlayerSkillButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PlayerSkillButtonButton == null )
     			{
		    		this.m_E_PlayerSkillButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_PlayerSkillButton");
     			}
     			return this.m_E_PlayerSkillButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_PlayerSkillButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PlayerSkillButtonImage == null )
     			{
		    		this.m_E_PlayerSkillButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PlayerSkillButton");
     			}
     			return this.m_E_PlayerSkillButtonImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_EButton_CreateTowerBaseButton = null;
			this.m_EButton_CreateTowerBaseImage = null;
			this.m_EButton_CreateTowerBaseEventTrigger = null;
			this.m_EButton_CreateTowerButton = null;
			this.m_EButton_CreateTowerImage = null;
			this.m_EButton_CreateTowerEventTrigger = null;
			this.m_E_TowerRangeImage = null;
			this.m_EListImage = null;
			this.m_Ecreatebt1Image = null;
			this.m_Espritetower1Button = null;
			this.m_Espritetower1Image = null;
			this.m_Espritetower1EventTrigger = null;
			this.m_Ecreatemoneybase1Image = null;
			this.m_Ecreatemoneytext1Text = null;
			this.m_Ecreatebt2Image = null;
			this.m_Espritetower2Button = null;
			this.m_Espritetower2Image = null;
			this.m_Espritetower2EventTrigger = null;
			this.m_Ecreatemoneybase2Image = null;
			this.m_Ecreatemoneytext2Text = null;
			this.m_Ecreatebt3Image = null;
			this.m_Espritetower3Button = null;
			this.m_Espritetower3Image = null;
			this.m_Espritetower3EventTrigger = null;
			this.m_Ecreatemoneybase3Image = null;
			this.m_Ecreatemoneytext3Text = null;
			this.m_Ecreatebt4Image = null;
			this.m_Espritetower4Button = null;
			this.m_Espritetower4Image = null;
			this.m_Espritetower4EventTrigger = null;
			this.m_Ecreatemoneybase4Image = null;
			this.m_Ecreatemoneytext4Text = null;
			this.m_EUpListImage = null;
			this.m_EUpButton = null;
			this.m_EUpImage = null;
			this.m_EUpEventTrigger = null;
			this.m_EUpArrowImage = null;
			this.m_EUpMoneyImage = null;
			this.m_EUPMoneyTextText = null;
			this.m_EDeleteUpButton = null;
			this.m_EDeleteUpImage = null;
			this.m_EDeleteUpEventTrigger = null;
			this.m_EDeleteSaleImage = null;
			this.m_EDeleteMoneyImage = null;
			this.m_EDeleteMoneyTextText = null;
			this.m_ETowerInfoButton = null;
			this.m_ETowerInfoImage = null;
			this.m_ETowerInfoNameBaseImage = null;
			this.m_ETowerInfoNameTextText = null;
			this.m_ETowerInfoDescriptionText = null;
			this.m_ETowerInfoAttackBaseImage = null;
			this.m_ETowerInfoAttackValueText = null;
			this.m_ETowerInfoAttackIntervalBaseImage = null;
			this.m_ETowerInfoAttackIntervalValueText = null;
			this.m_ETowerInfoAttackTypeBaseImage = null;
			this.m_ETowerInfoAttackTypeValueText = null;
			this.m_E_PlayerSkillButtonButton = null;
			this.m_E_PlayerSkillButtonImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_EButton_CreateTowerBaseButton = null;
		private UnityEngine.UI.Image m_EButton_CreateTowerBaseImage = null;
		private UnityEngine.EventSystems.EventTrigger m_EButton_CreateTowerBaseEventTrigger = null;
		private UnityEngine.UI.Button m_EButton_CreateTowerButton = null;
		private UnityEngine.UI.Image m_EButton_CreateTowerImage = null;
		private UnityEngine.EventSystems.EventTrigger m_EButton_CreateTowerEventTrigger = null;
		private UnityEngine.UI.Image m_E_TowerRangeImage = null;
		private UnityEngine.UI.Image m_EListImage = null;
		private UnityEngine.UI.Image m_Ecreatebt1Image = null;
		private UnityEngine.UI.Button m_Espritetower1Button = null;
		private UnityEngine.UI.Image m_Espritetower1Image = null;
		private UnityEngine.EventSystems.EventTrigger m_Espritetower1EventTrigger = null;
		private UnityEngine.UI.Image m_Ecreatemoneybase1Image = null;
		private UnityEngine.UI.Text m_Ecreatemoneytext1Text = null;
		private UnityEngine.UI.Image m_Ecreatebt2Image = null;
		private UnityEngine.UI.Button m_Espritetower2Button = null;
		private UnityEngine.UI.Image m_Espritetower2Image = null;
		private UnityEngine.EventSystems.EventTrigger m_Espritetower2EventTrigger = null;
		private UnityEngine.UI.Image m_Ecreatemoneybase2Image = null;
		private UnityEngine.UI.Text m_Ecreatemoneytext2Text = null;
		private UnityEngine.UI.Image m_Ecreatebt3Image = null;
		private UnityEngine.UI.Button m_Espritetower3Button = null;
		private UnityEngine.UI.Image m_Espritetower3Image = null;
		private UnityEngine.EventSystems.EventTrigger m_Espritetower3EventTrigger = null;
		private UnityEngine.UI.Image m_Ecreatemoneybase3Image = null;
		private UnityEngine.UI.Text m_Ecreatemoneytext3Text = null;
		private UnityEngine.UI.Image m_Ecreatebt4Image = null;
		private UnityEngine.UI.Button m_Espritetower4Button = null;
		private UnityEngine.UI.Image m_Espritetower4Image = null;
		private UnityEngine.EventSystems.EventTrigger m_Espritetower4EventTrigger = null;
		private UnityEngine.UI.Image m_Ecreatemoneybase4Image = null;
		private UnityEngine.UI.Text m_Ecreatemoneytext4Text = null;
		private UnityEngine.UI.Image m_EUpListImage = null;
		private UnityEngine.UI.Button m_EUpButton = null;
		private UnityEngine.UI.Image m_EUpImage = null;
		private UnityEngine.EventSystems.EventTrigger m_EUpEventTrigger = null;
		private UnityEngine.UI.Image m_EUpArrowImage = null;
		private UnityEngine.UI.Image m_EUpMoneyImage = null;
		private UnityEngine.UI.Text m_EUPMoneyTextText = null;
		private UnityEngine.UI.Button m_EDeleteUpButton = null;
		private UnityEngine.UI.Image m_EDeleteUpImage = null;
		private UnityEngine.EventSystems.EventTrigger m_EDeleteUpEventTrigger = null;
		private UnityEngine.UI.Image m_EDeleteSaleImage = null;
		private UnityEngine.UI.Image m_EDeleteMoneyImage = null;
		private UnityEngine.UI.Text m_EDeleteMoneyTextText = null;
		private UnityEngine.UI.Button m_ETowerInfoButton = null;
		private UnityEngine.UI.Image m_ETowerInfoImage = null;
		private UnityEngine.UI.Image m_ETowerInfoNameBaseImage = null;
		private UnityEngine.UI.Text m_ETowerInfoNameTextText = null;
		private UnityEngine.UI.Text m_ETowerInfoDescriptionText = null;
		private UnityEngine.UI.Image m_ETowerInfoAttackBaseImage = null;
		private UnityEngine.UI.Text m_ETowerInfoAttackValueText = null;
		private UnityEngine.UI.Image m_ETowerInfoAttackIntervalBaseImage = null;
		private UnityEngine.UI.Text m_ETowerInfoAttackIntervalValueText = null;
		private UnityEngine.UI.Image m_ETowerInfoAttackTypeBaseImage = null;
		private UnityEngine.UI.Text m_ETowerInfoAttackTypeValueText = null;
		private UnityEngine.UI.Button m_E_PlayerSkillButtonButton = null;
		private UnityEngine.UI.Image m_E_PlayerSkillButtonImage = null;
		public Transform uiTransform = null;
        public int BeforeTowerConfigId1;
        public int BeforeTowerConfigId2;
        public int BeforeTowerConfigId3;
        public int BeforeTowerConfigId4;
        public int TowerConfigId;
        public long TowerId;
        public int TowerLevel;
        public int Position;
        public Tower tower;
        public EventTrigger ShowTowerInfo;
        public GameObject TowerInfoObj;
        public bool UpInfoTrigger;
        public float UpInfoTimer;
        public bool BeforeBuildTrigger;
        public float BeforeBuildTimer;
        public bool SaleTirgger;
        public float SaleTimer;
        public bool IsSale;
        public int beforebuildconfigId;
        public int optId;
    }
}
