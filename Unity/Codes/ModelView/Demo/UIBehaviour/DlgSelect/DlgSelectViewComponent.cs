
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgSelectViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Image E_ChaptersImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ChaptersImage == null )
     			{
		    		this.m_E_ChaptersImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters");
     			}
     			return this.m_E_ChaptersImage;
     		}
     	}

		public UnityEngine.UI.ToggleGroup E_Chapter1ToggleGroup
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Chapter1ToggleGroup == null )
     			{
		    		this.m_E_Chapter1ToggleGroup = UIFindHelper.FindDeepChild<UnityEngine.UI.ToggleGroup>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1");
     			}
     			return this.m_E_Chapter1ToggleGroup;
     		}
     	}

		public UnityEngine.UI.Image E_Chapter1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Chapter1Image == null )
     			{
		    		this.m_E_Chapter1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1");
     			}
     			return this.m_E_Chapter1Image;
     		}
     	}

		public UnityEngine.UI.Button E_Level11Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Button == null )
     			{
		    		this.m_E_Level11Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11");
     			}
     			return this.m_E_Level11Button;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Image == null )
     			{
		    		this.m_E_Level11Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11");
     			}
     			return this.m_E_Level11Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Stars1Image == null )
     			{
		    		this.m_E_Level11Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11/E_Level11Stars/E_Level11Stars1");
     			}
     			return this.m_E_Level11Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Stars2Image == null )
     			{
		    		this.m_E_Level11Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11/E_Level11Stars/E_Level11Stars2");
     			}
     			return this.m_E_Level11Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Stars3Image == null )
     			{
		    		this.m_E_Level11Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11/E_Level11Stars/E_Level11Stars3");
     			}
     			return this.m_E_Level11Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Bean1Image == null )
     			{
		    		this.m_E_Level11Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11/E_Level11PathBeans/E_Level11Bean1");
     			}
     			return this.m_E_Level11Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Bean2Image == null )
     			{
		    		this.m_E_Level11Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11/E_Level11PathBeans/E_Level11Bean2");
     			}
     			return this.m_E_Level11Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Bean3Image == null )
     			{
		    		this.m_E_Level11Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11/E_Level11PathBeans/E_Level11Bean3");
     			}
     			return this.m_E_Level11Bean3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level11Bean4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level11Bean4Image == null )
     			{
		    		this.m_E_Level11Bean4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/E_Level11/E_Level11PathBeans/E_Level11Bean4");
     			}
     			return this.m_E_Level11Bean4Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel12Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel12Button == null )
     			{
		    		this.m_ELevel12Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12");
     			}
     			return this.m_ELevel12Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel12Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel12Image == null )
     			{
		    		this.m_ELevel12Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12");
     			}
     			return this.m_ELevel12Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level12Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level12Stars1Image == null )
     			{
		    		this.m_E_Level12Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12/E_Level12Stars/E_Level12Stars1");
     			}
     			return this.m_E_Level12Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level12Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level12Stars2Image == null )
     			{
		    		this.m_E_Level12Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12/E_Level12Stars/E_Level12Stars2");
     			}
     			return this.m_E_Level12Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level12Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level12Stars3Image == null )
     			{
		    		this.m_E_Level12Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12/E_Level12Stars/E_Level12Stars3");
     			}
     			return this.m_E_Level12Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level12Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level12Bean1Image == null )
     			{
		    		this.m_E_Level12Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12/E_Level12PathBeans/E_Level12Bean1");
     			}
     			return this.m_E_Level12Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level12Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level12Bean2Image == null )
     			{
		    		this.m_E_Level12Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12/E_Level12PathBeans/E_Level12Bean2");
     			}
     			return this.m_E_Level12Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level12Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level12Bean3Image == null )
     			{
		    		this.m_E_Level12Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12/E_Level12PathBeans/E_Level12Bean3");
     			}
     			return this.m_E_Level12Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel13Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel13Button == null )
     			{
		    		this.m_ELevel13Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13");
     			}
     			return this.m_ELevel13Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel13Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel13Image == null )
     			{
		    		this.m_ELevel13Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13");
     			}
     			return this.m_ELevel13Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level13Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level13Stars1Image == null )
     			{
		    		this.m_E_Level13Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13/E_Level13Stars/E_Level13Stars1");
     			}
     			return this.m_E_Level13Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level13Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level13Stars2Image == null )
     			{
		    		this.m_E_Level13Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13/E_Level13Stars/E_Level13Stars2");
     			}
     			return this.m_E_Level13Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level13Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level13Stars3Image == null )
     			{
		    		this.m_E_Level13Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13/E_Level13Stars/E_Level13Stars3");
     			}
     			return this.m_E_Level13Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level13Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level13Bean1Image == null )
     			{
		    		this.m_E_Level13Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13/E_Level13PathBeans/E_Level13Bean1");
     			}
     			return this.m_E_Level13Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level13Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level13Bean2Image == null )
     			{
		    		this.m_E_Level13Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13/E_Level13PathBeans/E_Level13Bean2");
     			}
     			return this.m_E_Level13Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level13Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level13Bean3Image == null )
     			{
		    		this.m_E_Level13Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13/E_Level13PathBeans/E_Level13Bean3");
     			}
     			return this.m_E_Level13Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel14Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel14Button == null )
     			{
		    		this.m_ELevel14Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel14");
     			}
     			return this.m_ELevel14Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel14Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel14Image == null )
     			{
		    		this.m_ELevel14Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel14");
     			}
     			return this.m_ELevel14Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level14Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level14Stars1Image == null )
     			{
		    		this.m_E_Level14Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel14/E_Level14Stars/E_Level14Stars1");
     			}
     			return this.m_E_Level14Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level14Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level14Stars2Image == null )
     			{
		    		this.m_E_Level14Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel14/E_Level14Stars/E_Level14Stars2");
     			}
     			return this.m_E_Level14Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level14Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level14Stars3Image == null )
     			{
		    		this.m_E_Level14Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel14/E_Level14Stars/E_Level14Stars3");
     			}
     			return this.m_E_Level14Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level14Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level14Bean1Image == null )
     			{
		    		this.m_E_Level14Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel14/E_Level14PathBeans/E_Level14Bean1");
     			}
     			return this.m_E_Level14Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level14Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level14Bean2Image == null )
     			{
		    		this.m_E_Level14Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel14/E_Level14PathBeans/E_Level14Bean2");
     			}
     			return this.m_E_Level14Bean2Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel15Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel15Button == null )
     			{
		    		this.m_ELevel15Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15");
     			}
     			return this.m_ELevel15Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel15Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel15Image == null )
     			{
		    		this.m_ELevel15Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15");
     			}
     			return this.m_ELevel15Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level15Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level15Stars1Image == null )
     			{
		    		this.m_E_Level15Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15/E_Level15Stars/E_Level15Stars1");
     			}
     			return this.m_E_Level15Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level15Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level15Stars2Image == null )
     			{
		    		this.m_E_Level15Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15/E_Level15Stars/E_Level15Stars2");
     			}
     			return this.m_E_Level15Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level15Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level15Stars3Image == null )
     			{
		    		this.m_E_Level15Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15/E_Level15Stars/E_Level15Stars3");
     			}
     			return this.m_E_Level15Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level15Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level15Bean1Image == null )
     			{
		    		this.m_E_Level15Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15/E_Level15PtahBeans/E_Level15Bean1");
     			}
     			return this.m_E_Level15Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level15Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level15Bean2Image == null )
     			{
		    		this.m_E_Level15Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15/E_Level15PtahBeans/E_Level15Bean2");
     			}
     			return this.m_E_Level15Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level15Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level15Bean3Image == null )
     			{
		    		this.m_E_Level15Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel15/E_Level15PtahBeans/E_Level15Bean3");
     			}
     			return this.m_E_Level15Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel16Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel16Button == null )
     			{
		    		this.m_ELevel16Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16");
     			}
     			return this.m_ELevel16Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel16Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel16Image == null )
     			{
		    		this.m_ELevel16Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16");
     			}
     			return this.m_ELevel16Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level16Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level16Stars1Image == null )
     			{
		    		this.m_E_Level16Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16/E_Level16Stars/E_Level16Stars1");
     			}
     			return this.m_E_Level16Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level16Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level16Stars2Image == null )
     			{
		    		this.m_E_Level16Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16/E_Level16Stars/E_Level16Stars2");
     			}
     			return this.m_E_Level16Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level16Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level16Stars3Image == null )
     			{
		    		this.m_E_Level16Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16/E_Level16Stars/E_Level16Stars3");
     			}
     			return this.m_E_Level16Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level16Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level16Bean1Image == null )
     			{
		    		this.m_E_Level16Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16/E_Level16PathBeans/E_Level16Bean1");
     			}
     			return this.m_E_Level16Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level16Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level16Bean2Image == null )
     			{
		    		this.m_E_Level16Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16/E_Level16PathBeans/E_Level16Bean2");
     			}
     			return this.m_E_Level16Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level16Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level16Bean3Image == null )
     			{
		    		this.m_E_Level16Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel16/E_Level16PathBeans/E_Level16Bean3");
     			}
     			return this.m_E_Level16Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel17Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel17Button == null )
     			{
		    		this.m_ELevel17Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17");
     			}
     			return this.m_ELevel17Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel17Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel17Image == null )
     			{
		    		this.m_ELevel17Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17");
     			}
     			return this.m_ELevel17Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level17Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level17Stars1Image == null )
     			{
		    		this.m_E_Level17Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17/E_Level17Stars/E_Level17Stars1");
     			}
     			return this.m_E_Level17Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level17Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level17Stars2Image == null )
     			{
		    		this.m_E_Level17Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17/E_Level17Stars/E_Level17Stars2");
     			}
     			return this.m_E_Level17Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level17Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level17Stars3Image == null )
     			{
		    		this.m_E_Level17Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17/E_Level17Stars/E_Level17Stars3");
     			}
     			return this.m_E_Level17Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level17Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level17Bean1Image == null )
     			{
		    		this.m_E_Level17Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17/E_Level17PathBeans/E_Level17Bean1");
     			}
     			return this.m_E_Level17Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level17Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level17Bean2Image == null )
     			{
		    		this.m_E_Level17Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17/E_Level17PathBeans/E_Level17Bean2");
     			}
     			return this.m_E_Level17Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level17Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level17Bean3Image == null )
     			{
		    		this.m_E_Level17Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel17/E_Level17PathBeans/E_Level17Bean3");
     			}
     			return this.m_E_Level17Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel18Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel18Button == null )
     			{
		    		this.m_ELevel18Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18");
     			}
     			return this.m_ELevel18Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel18Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel18Image == null )
     			{
		    		this.m_ELevel18Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18");
     			}
     			return this.m_ELevel18Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level18Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level18Stars1Image == null )
     			{
		    		this.m_E_Level18Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18/E_Level18Stars/E_Level18Stars1");
     			}
     			return this.m_E_Level18Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level18Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level18Stars2Image == null )
     			{
		    		this.m_E_Level18Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18/E_Level18Stars/E_Level18Stars2");
     			}
     			return this.m_E_Level18Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level18Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level18Stars3Image == null )
     			{
		    		this.m_E_Level18Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18/E_Level18Stars/E_Level18Stars3");
     			}
     			return this.m_E_Level18Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level18Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level18Bean1Image == null )
     			{
		    		this.m_E_Level18Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18/E_Level18PathBeans/E_Level18Bean1");
     			}
     			return this.m_E_Level18Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level18Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level18Bean2Image == null )
     			{
		    		this.m_E_Level18Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18/E_Level18PathBeans/E_Level18Bean2");
     			}
     			return this.m_E_Level18Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level18Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level18Bean3Image == null )
     			{
		    		this.m_E_Level18Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel18/E_Level18PathBeans/E_Level18Bean3");
     			}
     			return this.m_E_Level18Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel19Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel19Button == null )
     			{
		    		this.m_ELevel19Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19");
     			}
     			return this.m_ELevel19Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel19Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel19Image == null )
     			{
		    		this.m_ELevel19Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19");
     			}
     			return this.m_ELevel19Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level19Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level19Stars1Image == null )
     			{
		    		this.m_E_Level19Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19/E_Level19Stars/E_Level19Stars1");
     			}
     			return this.m_E_Level19Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level19Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level19Stars2Image == null )
     			{
		    		this.m_E_Level19Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19/E_Level19Stars/E_Level19Stars2");
     			}
     			return this.m_E_Level19Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level19Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level19Stars3Image == null )
     			{
		    		this.m_E_Level19Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19/E_Level19Stars/E_Level19Stars3");
     			}
     			return this.m_E_Level19Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level19Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level19Bean1Image == null )
     			{
		    		this.m_E_Level19Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19/E_Level19PathBeans/E_Level19Bean1");
     			}
     			return this.m_E_Level19Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level19Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level19Bean2Image == null )
     			{
		    		this.m_E_Level19Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19/E_Level19PathBeans/E_Level19Bean2");
     			}
     			return this.m_E_Level19Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level19Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level19Bean3Image == null )
     			{
		    		this.m_E_Level19Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel19/E_Level19PathBeans/E_Level19Bean3");
     			}
     			return this.m_E_Level19Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel110Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel110Button == null )
     			{
		    		this.m_ELevel110Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel110");
     			}
     			return this.m_ELevel110Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel110Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel110Image == null )
     			{
		    		this.m_ELevel110Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel110");
     			}
     			return this.m_ELevel110Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level110Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level110Stars1Image == null )
     			{
		    		this.m_E_Level110Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel110/E_Level110Stars/E_Level110Stars1");
     			}
     			return this.m_E_Level110Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level110Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level110Stars2Image == null )
     			{
		    		this.m_E_Level110Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel110/E_Level110Stars/E_Level110Stars2");
     			}
     			return this.m_E_Level110Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level110Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level110Stars3Image == null )
     			{
		    		this.m_E_Level110Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel110/E_Level110Stars/E_Level110Stars3");
     			}
     			return this.m_E_Level110Stars3Image;
     		}
     	}

		public UnityEngine.UI.ToggleGroup E_Chapter2ToggleGroup
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Chapter2ToggleGroup == null )
     			{
		    		this.m_E_Chapter2ToggleGroup = UIFindHelper.FindDeepChild<UnityEngine.UI.ToggleGroup>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2");
     			}
     			return this.m_E_Chapter2ToggleGroup;
     		}
     	}

		public UnityEngine.UI.Image E_Chapter2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Chapter2Image == null )
     			{
		    		this.m_E_Chapter2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2");
     			}
     			return this.m_E_Chapter2Image;
     		}
     	}

		public UnityEngine.UI.Button E_Level21Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Button == null )
     			{
		    		this.m_E_Level21Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21");
     			}
     			return this.m_E_Level21Button;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Image == null )
     			{
		    		this.m_E_Level21Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21");
     			}
     			return this.m_E_Level21Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Stars1Image == null )
     			{
		    		this.m_E_Level21Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21/E_Level21Stars/E_Level21Stars1");
     			}
     			return this.m_E_Level21Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Stars2Image == null )
     			{
		    		this.m_E_Level21Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21/E_Level21Stars/E_Level21Stars2");
     			}
     			return this.m_E_Level21Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Stars3Image == null )
     			{
		    		this.m_E_Level21Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21/E_Level21Stars/E_Level21Stars3");
     			}
     			return this.m_E_Level21Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Bean1Image == null )
     			{
		    		this.m_E_Level21Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21/E_Level21PathBeans/E_Level21Bean1");
     			}
     			return this.m_E_Level21Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Bean2Image == null )
     			{
		    		this.m_E_Level21Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21/E_Level21PathBeans/E_Level21Bean2");
     			}
     			return this.m_E_Level21Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Bean3Image == null )
     			{
		    		this.m_E_Level21Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21/E_Level21PathBeans/E_Level21Bean3");
     			}
     			return this.m_E_Level21Bean3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level21Bean4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level21Bean4Image == null )
     			{
		    		this.m_E_Level21Bean4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/E_Level21/E_Level21PathBeans/E_Level21Bean4");
     			}
     			return this.m_E_Level21Bean4Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel22Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel22Button == null )
     			{
		    		this.m_ELevel22Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22");
     			}
     			return this.m_ELevel22Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel22Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel22Image == null )
     			{
		    		this.m_ELevel22Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22");
     			}
     			return this.m_ELevel22Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level22Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level22Stars1Image == null )
     			{
		    		this.m_E_Level22Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22/E_Level22Stars/E_Level22Stars1");
     			}
     			return this.m_E_Level22Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level22Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level22Stars2Image == null )
     			{
		    		this.m_E_Level22Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22/E_Level22Stars/E_Level22Stars2");
     			}
     			return this.m_E_Level22Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level22Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level22Stars3Image == null )
     			{
		    		this.m_E_Level22Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22/E_Level22Stars/E_Level22Stars3");
     			}
     			return this.m_E_Level22Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level22Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level22Bean1Image == null )
     			{
		    		this.m_E_Level22Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22/E_Level22PathBeans/E_Level22Bean1");
     			}
     			return this.m_E_Level22Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level22Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level22Bean2Image == null )
     			{
		    		this.m_E_Level22Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22/E_Level22PathBeans/E_Level22Bean2");
     			}
     			return this.m_E_Level22Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level22Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level22Bean3Image == null )
     			{
		    		this.m_E_Level22Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel22/E_Level22PathBeans/E_Level22Bean3");
     			}
     			return this.m_E_Level22Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel23Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel23Button == null )
     			{
		    		this.m_ELevel23Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23");
     			}
     			return this.m_ELevel23Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel23Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel23Image == null )
     			{
		    		this.m_ELevel23Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23");
     			}
     			return this.m_ELevel23Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level23Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level23Stars1Image == null )
     			{
		    		this.m_E_Level23Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23/E_Level23Stars/E_Level23Stars1");
     			}
     			return this.m_E_Level23Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level23Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level23Stars2Image == null )
     			{
		    		this.m_E_Level23Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23/E_Level23Stars/E_Level23Stars2");
     			}
     			return this.m_E_Level23Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level23Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level23Stars3Image == null )
     			{
		    		this.m_E_Level23Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23/E_Level23Stars/E_Level23Stars3");
     			}
     			return this.m_E_Level23Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level23Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level23Bean1Image == null )
     			{
		    		this.m_E_Level23Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23/E_Level23PathBeans/E_Level23Bean1");
     			}
     			return this.m_E_Level23Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level23Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level23Bean2Image == null )
     			{
		    		this.m_E_Level23Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23/E_Level23PathBeans/E_Level23Bean2");
     			}
     			return this.m_E_Level23Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level23Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level23Bean3Image == null )
     			{
		    		this.m_E_Level23Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel23/E_Level23PathBeans/E_Level23Bean3");
     			}
     			return this.m_E_Level23Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel24Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel24Button == null )
     			{
		    		this.m_ELevel24Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel24");
     			}
     			return this.m_ELevel24Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel24Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel24Image == null )
     			{
		    		this.m_ELevel24Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel24");
     			}
     			return this.m_ELevel24Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level24Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level24Stars1Image == null )
     			{
		    		this.m_E_Level24Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel24/E_Level24Stars/E_Level24Stars1");
     			}
     			return this.m_E_Level24Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level24Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level24Stars2Image == null )
     			{
		    		this.m_E_Level24Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel24/E_Level24Stars/E_Level24Stars2");
     			}
     			return this.m_E_Level24Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level24Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level24Stars3Image == null )
     			{
		    		this.m_E_Level24Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel24/E_Level24Stars/E_Level24Stars3");
     			}
     			return this.m_E_Level24Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level24Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level24Bean1Image == null )
     			{
		    		this.m_E_Level24Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel24/E_Level24PathBeans/E_Level24Bean1");
     			}
     			return this.m_E_Level24Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level24Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level24Bean2Image == null )
     			{
		    		this.m_E_Level24Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel24/E_Level24PathBeans/E_Level24Bean2");
     			}
     			return this.m_E_Level24Bean2Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel25Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel25Button == null )
     			{
		    		this.m_ELevel25Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25");
     			}
     			return this.m_ELevel25Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel25Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel25Image == null )
     			{
		    		this.m_ELevel25Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25");
     			}
     			return this.m_ELevel25Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level25Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level25Stars1Image == null )
     			{
		    		this.m_E_Level25Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25/E_Level25Stars/E_Level25Stars1");
     			}
     			return this.m_E_Level25Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level25Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level25Stars2Image == null )
     			{
		    		this.m_E_Level25Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25/E_Level25Stars/E_Level25Stars2");
     			}
     			return this.m_E_Level25Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level25Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level25Stars3Image == null )
     			{
		    		this.m_E_Level25Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25/E_Level25Stars/E_Level25Stars3");
     			}
     			return this.m_E_Level25Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level25Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level25Bean1Image == null )
     			{
		    		this.m_E_Level25Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25/E_Level25PtahBeans/E_Level25Bean1");
     			}
     			return this.m_E_Level25Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level25Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level25Bean2Image == null )
     			{
		    		this.m_E_Level25Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25/E_Level25PtahBeans/E_Level25Bean2");
     			}
     			return this.m_E_Level25Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level25Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level25Bean3Image == null )
     			{
		    		this.m_E_Level25Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel25/E_Level25PtahBeans/E_Level25Bean3");
     			}
     			return this.m_E_Level25Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel26Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel26Button == null )
     			{
		    		this.m_ELevel26Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26");
     			}
     			return this.m_ELevel26Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel26Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel26Image == null )
     			{
		    		this.m_ELevel26Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26");
     			}
     			return this.m_ELevel26Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level26Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level26Stars1Image == null )
     			{
		    		this.m_E_Level26Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26/E_Level26Stars/E_Level26Stars1");
     			}
     			return this.m_E_Level26Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level26Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level26Stars2Image == null )
     			{
		    		this.m_E_Level26Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26/E_Level26Stars/E_Level26Stars2");
     			}
     			return this.m_E_Level26Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level26Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level26Stars3Image == null )
     			{
		    		this.m_E_Level26Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26/E_Level26Stars/E_Level26Stars3");
     			}
     			return this.m_E_Level26Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level26Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level26Bean1Image == null )
     			{
		    		this.m_E_Level26Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26/E_Level26PathBeans/E_Level26Bean1");
     			}
     			return this.m_E_Level26Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level26Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level26Bean2Image == null )
     			{
		    		this.m_E_Level26Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26/E_Level26PathBeans/E_Level26Bean2");
     			}
     			return this.m_E_Level26Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level26Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level26Bean3Image == null )
     			{
		    		this.m_E_Level26Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel26/E_Level26PathBeans/E_Level26Bean3");
     			}
     			return this.m_E_Level26Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel27Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel27Button == null )
     			{
		    		this.m_ELevel27Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27");
     			}
     			return this.m_ELevel27Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel27Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel27Image == null )
     			{
		    		this.m_ELevel27Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27");
     			}
     			return this.m_ELevel27Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level27Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level27Stars1Image == null )
     			{
		    		this.m_E_Level27Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27/E_Level27Stars/E_Level27Stars1");
     			}
     			return this.m_E_Level27Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level27Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level27Stars2Image == null )
     			{
		    		this.m_E_Level27Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27/E_Level27Stars/E_Level27Stars2");
     			}
     			return this.m_E_Level27Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level27Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level27Stars3Image == null )
     			{
		    		this.m_E_Level27Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27/E_Level27Stars/E_Level27Stars3");
     			}
     			return this.m_E_Level27Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level27Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level27Bean1Image == null )
     			{
		    		this.m_E_Level27Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27/E_Level27PathBeans/E_Level27Bean1");
     			}
     			return this.m_E_Level27Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level27Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level27Bean2Image == null )
     			{
		    		this.m_E_Level27Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27/E_Level27PathBeans/E_Level27Bean2");
     			}
     			return this.m_E_Level27Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level27Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level27Bean3Image == null )
     			{
		    		this.m_E_Level27Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel27/E_Level27PathBeans/E_Level27Bean3");
     			}
     			return this.m_E_Level27Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel28Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel28Button == null )
     			{
		    		this.m_ELevel28Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28");
     			}
     			return this.m_ELevel28Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel28Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel28Image == null )
     			{
		    		this.m_ELevel28Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28");
     			}
     			return this.m_ELevel28Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level28Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level28Stars1Image == null )
     			{
		    		this.m_E_Level28Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28/E_Level28Stars/E_Level28Stars1");
     			}
     			return this.m_E_Level28Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level28Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level28Stars2Image == null )
     			{
		    		this.m_E_Level28Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28/E_Level28Stars/E_Level28Stars2");
     			}
     			return this.m_E_Level28Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level28Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level28Stars3Image == null )
     			{
		    		this.m_E_Level28Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28/E_Level28Stars/E_Level28Stars3");
     			}
     			return this.m_E_Level28Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level28Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level28Bean1Image == null )
     			{
		    		this.m_E_Level28Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28/E_Level28PathBeans/E_Level28Bean1");
     			}
     			return this.m_E_Level28Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level28Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level28Bean2Image == null )
     			{
		    		this.m_E_Level28Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28/E_Level28PathBeans/E_Level28Bean2");
     			}
     			return this.m_E_Level28Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level28Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level28Bean3Image == null )
     			{
		    		this.m_E_Level28Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel28/E_Level28PathBeans/E_Level28Bean3");
     			}
     			return this.m_E_Level28Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel29Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel29Button == null )
     			{
		    		this.m_ELevel29Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29");
     			}
     			return this.m_ELevel29Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel29Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel29Image == null )
     			{
		    		this.m_ELevel29Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29");
     			}
     			return this.m_ELevel29Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level29Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level29Stars1Image == null )
     			{
		    		this.m_E_Level29Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29/E_Level29Stars/E_Level29Stars1");
     			}
     			return this.m_E_Level29Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level29Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level29Stars2Image == null )
     			{
		    		this.m_E_Level29Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29/E_Level29Stars/E_Level29Stars2");
     			}
     			return this.m_E_Level29Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level29Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level29Stars3Image == null )
     			{
		    		this.m_E_Level29Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29/E_Level29Stars/E_Level29Stars3");
     			}
     			return this.m_E_Level29Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level29Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level29Bean1Image == null )
     			{
		    		this.m_E_Level29Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29/E_Level29PathBeans/E_Level29Bean1");
     			}
     			return this.m_E_Level29Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level29Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level29Bean2Image == null )
     			{
		    		this.m_E_Level29Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29/E_Level29PathBeans/E_Level29Bean2");
     			}
     			return this.m_E_Level29Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level29Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level29Bean3Image == null )
     			{
		    		this.m_E_Level29Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel29/E_Level29PathBeans/E_Level29Bean3");
     			}
     			return this.m_E_Level29Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel210Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel210Button == null )
     			{
		    		this.m_ELevel210Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel210");
     			}
     			return this.m_ELevel210Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel210Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel210Image == null )
     			{
		    		this.m_ELevel210Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel210");
     			}
     			return this.m_ELevel210Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level210Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level210Stars1Image == null )
     			{
		    		this.m_E_Level210Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel210/E_Level210Stars1");
     			}
     			return this.m_E_Level210Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level210Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level210Stars2Image == null )
     			{
		    		this.m_E_Level210Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel210/E_Level210Stars2");
     			}
     			return this.m_E_Level210Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level210Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level210Stars3Image == null )
     			{
		    		this.m_E_Level210Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel210/E_Level210Stars3");
     			}
     			return this.m_E_Level210Stars3Image;
     		}
     	}

		public UnityEngine.UI.ToggleGroup E_Chapter3ToggleGroup
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Chapter3ToggleGroup == null )
     			{
		    		this.m_E_Chapter3ToggleGroup = UIFindHelper.FindDeepChild<UnityEngine.UI.ToggleGroup>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3");
     			}
     			return this.m_E_Chapter3ToggleGroup;
     		}
     	}

		public UnityEngine.UI.Image E_Chapter3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Chapter3Image == null )
     			{
		    		this.m_E_Chapter3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3");
     			}
     			return this.m_E_Chapter3Image;
     		}
     	}

		public UnityEngine.UI.Button E_Level31Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Button == null )
     			{
		    		this.m_E_Level31Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31");
     			}
     			return this.m_E_Level31Button;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Image == null )
     			{
		    		this.m_E_Level31Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31");
     			}
     			return this.m_E_Level31Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Stars1Image == null )
     			{
		    		this.m_E_Level31Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31/E_Level31Stars/E_Level31Stars1");
     			}
     			return this.m_E_Level31Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Stars2Image == null )
     			{
		    		this.m_E_Level31Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31/E_Level31Stars/E_Level31Stars2");
     			}
     			return this.m_E_Level31Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Stars3Image == null )
     			{
		    		this.m_E_Level31Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31/E_Level31Stars/E_Level31Stars3");
     			}
     			return this.m_E_Level31Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Bean1Image == null )
     			{
		    		this.m_E_Level31Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31/E_Level31PathBeans/E_Level31Bean1");
     			}
     			return this.m_E_Level31Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Bean2Image == null )
     			{
		    		this.m_E_Level31Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31/E_Level31PathBeans/E_Level31Bean2");
     			}
     			return this.m_E_Level31Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Bean3Image == null )
     			{
		    		this.m_E_Level31Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31/E_Level31PathBeans/E_Level31Bean3");
     			}
     			return this.m_E_Level31Bean3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level31Bean4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level31Bean4Image == null )
     			{
		    		this.m_E_Level31Bean4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/E_Level31/E_Level31PathBeans/E_Level31Bean4");
     			}
     			return this.m_E_Level31Bean4Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel32Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel32Button == null )
     			{
		    		this.m_ELevel32Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32");
     			}
     			return this.m_ELevel32Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel32Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel32Image == null )
     			{
		    		this.m_ELevel32Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32");
     			}
     			return this.m_ELevel32Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level32Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level32Stars1Image == null )
     			{
		    		this.m_E_Level32Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32/E_Level32Stars/E_Level32Stars1");
     			}
     			return this.m_E_Level32Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level32Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level32Stars2Image == null )
     			{
		    		this.m_E_Level32Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32/E_Level32Stars/E_Level32Stars2");
     			}
     			return this.m_E_Level32Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level32Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level32Stars3Image == null )
     			{
		    		this.m_E_Level32Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32/E_Level32Stars/E_Level32Stars3");
     			}
     			return this.m_E_Level32Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level32Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level32Bean1Image == null )
     			{
		    		this.m_E_Level32Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32/E_Level32PathBeans/E_Level32Bean1");
     			}
     			return this.m_E_Level32Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level32Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level32Bean2Image == null )
     			{
		    		this.m_E_Level32Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32/E_Level32PathBeans/E_Level32Bean2");
     			}
     			return this.m_E_Level32Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level32Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level32Bean3Image == null )
     			{
		    		this.m_E_Level32Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel32/E_Level32PathBeans/E_Level32Bean3");
     			}
     			return this.m_E_Level32Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel33Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel33Button == null )
     			{
		    		this.m_ELevel33Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33");
     			}
     			return this.m_ELevel33Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel33Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel33Image == null )
     			{
		    		this.m_ELevel33Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33");
     			}
     			return this.m_ELevel33Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level33Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level33Stars1Image == null )
     			{
		    		this.m_E_Level33Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33/E_Level33Stars/E_Level33Stars1");
     			}
     			return this.m_E_Level33Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level33Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level33Stars2Image == null )
     			{
		    		this.m_E_Level33Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33/E_Level33Stars/E_Level33Stars2");
     			}
     			return this.m_E_Level33Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level33Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level33Stars3Image == null )
     			{
		    		this.m_E_Level33Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33/E_Level33Stars/E_Level33Stars3");
     			}
     			return this.m_E_Level33Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level33Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level33Bean1Image == null )
     			{
		    		this.m_E_Level33Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33/E_Level33PathBeans/E_Level33Bean1");
     			}
     			return this.m_E_Level33Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level33Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level33Bean2Image == null )
     			{
		    		this.m_E_Level33Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33/E_Level33PathBeans/E_Level33Bean2");
     			}
     			return this.m_E_Level33Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level33Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level33Bean3Image == null )
     			{
		    		this.m_E_Level33Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel33/E_Level33PathBeans/E_Level33Bean3");
     			}
     			return this.m_E_Level33Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel34Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel34Button == null )
     			{
		    		this.m_ELevel34Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel34");
     			}
     			return this.m_ELevel34Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel34Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel34Image == null )
     			{
		    		this.m_ELevel34Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel34");
     			}
     			return this.m_ELevel34Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level34Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level34Stars1Image == null )
     			{
		    		this.m_E_Level34Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel34/E_Level34Stars/E_Level34Stars1");
     			}
     			return this.m_E_Level34Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level34Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level34Stars2Image == null )
     			{
		    		this.m_E_Level34Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel34/E_Level34Stars/E_Level34Stars2");
     			}
     			return this.m_E_Level34Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level34Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level34Stars3Image == null )
     			{
		    		this.m_E_Level34Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel34/E_Level34Stars/E_Level34Stars3");
     			}
     			return this.m_E_Level34Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level34Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level34Bean1Image == null )
     			{
		    		this.m_E_Level34Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel34/E_Level34PathBeans/E_Level34Bean1");
     			}
     			return this.m_E_Level34Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level34Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level34Bean2Image == null )
     			{
		    		this.m_E_Level34Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel34/E_Level34PathBeans/E_Level34Bean2");
     			}
     			return this.m_E_Level34Bean2Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel35Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel35Button == null )
     			{
		    		this.m_ELevel35Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35");
     			}
     			return this.m_ELevel35Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel35Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel35Image == null )
     			{
		    		this.m_ELevel35Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35");
     			}
     			return this.m_ELevel35Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level35Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level35Stars1Image == null )
     			{
		    		this.m_E_Level35Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35/E_Level35Stars/E_Level35Stars1");
     			}
     			return this.m_E_Level35Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level35Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level35Stars2Image == null )
     			{
		    		this.m_E_Level35Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35/E_Level35Stars/E_Level35Stars2");
     			}
     			return this.m_E_Level35Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level35Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level35Stars3Image == null )
     			{
		    		this.m_E_Level35Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35/E_Level35Stars/E_Level35Stars3");
     			}
     			return this.m_E_Level35Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level35Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level35Bean1Image == null )
     			{
		    		this.m_E_Level35Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35/E_Level35PtahBeans/E_Level35Bean1");
     			}
     			return this.m_E_Level35Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level35Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level35Bean2Image == null )
     			{
		    		this.m_E_Level35Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35/E_Level35PtahBeans/E_Level35Bean2");
     			}
     			return this.m_E_Level35Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level35Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level35Bean3Image == null )
     			{
		    		this.m_E_Level35Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel35/E_Level35PtahBeans/E_Level35Bean3");
     			}
     			return this.m_E_Level35Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel36Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel36Button == null )
     			{
		    		this.m_ELevel36Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36");
     			}
     			return this.m_ELevel36Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel36Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel36Image == null )
     			{
		    		this.m_ELevel36Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36");
     			}
     			return this.m_ELevel36Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level36Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level36Stars1Image == null )
     			{
		    		this.m_E_Level36Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36/E_Level36Stars/E_Level36Stars1");
     			}
     			return this.m_E_Level36Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level36Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level36Stars2Image == null )
     			{
		    		this.m_E_Level36Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36/E_Level36Stars/E_Level36Stars2");
     			}
     			return this.m_E_Level36Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level36Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level36Stars3Image == null )
     			{
		    		this.m_E_Level36Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36/E_Level36Stars/E_Level36Stars3");
     			}
     			return this.m_E_Level36Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level36Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level36Bean1Image == null )
     			{
		    		this.m_E_Level36Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36/E_Level36PathBeans/E_Level36Bean1");
     			}
     			return this.m_E_Level36Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level36Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level36Bean2Image == null )
     			{
		    		this.m_E_Level36Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36/E_Level36PathBeans/E_Level36Bean2");
     			}
     			return this.m_E_Level36Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level36Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level36Bean3Image == null )
     			{
		    		this.m_E_Level36Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel36/E_Level36PathBeans/E_Level36Bean3");
     			}
     			return this.m_E_Level36Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel37Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel37Button == null )
     			{
		    		this.m_ELevel37Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37");
     			}
     			return this.m_ELevel37Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel37Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel37Image == null )
     			{
		    		this.m_ELevel37Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37");
     			}
     			return this.m_ELevel37Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level37Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level37Stars1Image == null )
     			{
		    		this.m_E_Level37Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37/E_Level37Stars/E_Level37Stars1");
     			}
     			return this.m_E_Level37Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level37Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level37Stars2Image == null )
     			{
		    		this.m_E_Level37Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37/E_Level37Stars/E_Level37Stars2");
     			}
     			return this.m_E_Level37Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level37Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level37Stars3Image == null )
     			{
		    		this.m_E_Level37Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37/E_Level37Stars/E_Level37Stars3");
     			}
     			return this.m_E_Level37Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level37Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level37Bean1Image == null )
     			{
		    		this.m_E_Level37Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37/E_Level37PathBeans/E_Level37Bean1");
     			}
     			return this.m_E_Level37Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level37Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level37Bean2Image == null )
     			{
		    		this.m_E_Level37Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37/E_Level37PathBeans/E_Level37Bean2");
     			}
     			return this.m_E_Level37Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level37Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level37Bean3Image == null )
     			{
		    		this.m_E_Level37Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel37/E_Level37PathBeans/E_Level37Bean3");
     			}
     			return this.m_E_Level37Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel38Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel38Button == null )
     			{
		    		this.m_ELevel38Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38");
     			}
     			return this.m_ELevel38Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel38Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel38Image == null )
     			{
		    		this.m_ELevel38Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38");
     			}
     			return this.m_ELevel38Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level38Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level38Stars1Image == null )
     			{
		    		this.m_E_Level38Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38/E_Level38Stars/E_Level38Stars1");
     			}
     			return this.m_E_Level38Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level38Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level38Stars2Image == null )
     			{
		    		this.m_E_Level38Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38/E_Level38Stars/E_Level38Stars2");
     			}
     			return this.m_E_Level38Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level38Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level38Stars3Image == null )
     			{
		    		this.m_E_Level38Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38/E_Level38Stars/E_Level38Stars3");
     			}
     			return this.m_E_Level38Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level38Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level38Bean1Image == null )
     			{
		    		this.m_E_Level38Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38/E_Level38PathBeans/E_Level38Bean1");
     			}
     			return this.m_E_Level38Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level38Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level38Bean2Image == null )
     			{
		    		this.m_E_Level38Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38/E_Level38PathBeans/E_Level38Bean2");
     			}
     			return this.m_E_Level38Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level38Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level38Bean3Image == null )
     			{
		    		this.m_E_Level38Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel38/E_Level38PathBeans/E_Level38Bean3");
     			}
     			return this.m_E_Level38Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel39Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel39Button == null )
     			{
		    		this.m_ELevel39Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39");
     			}
     			return this.m_ELevel39Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel39Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel39Image == null )
     			{
		    		this.m_ELevel39Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39");
     			}
     			return this.m_ELevel39Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level39Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level39Stars1Image == null )
     			{
		    		this.m_E_Level39Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39/E_Level39Stars/E_Level39Stars1");
     			}
     			return this.m_E_Level39Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level39Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level39Stars2Image == null )
     			{
		    		this.m_E_Level39Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39/E_Level39Stars/E_Level39Stars2");
     			}
     			return this.m_E_Level39Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level39Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level39Stars3Image == null )
     			{
		    		this.m_E_Level39Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39/E_Level39Stars/E_Level39Stars3");
     			}
     			return this.m_E_Level39Stars3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level39Bean1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level39Bean1Image == null )
     			{
		    		this.m_E_Level39Bean1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39/E_Level39PathBeans/E_Level39Bean1");
     			}
     			return this.m_E_Level39Bean1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level39Bean2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level39Bean2Image == null )
     			{
		    		this.m_E_Level39Bean2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39/E_Level39PathBeans/E_Level39Bean2");
     			}
     			return this.m_E_Level39Bean2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level39Bean3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level39Bean3Image == null )
     			{
		    		this.m_E_Level39Bean3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel39/E_Level39PathBeans/E_Level39Bean3");
     			}
     			return this.m_E_Level39Bean3Image;
     		}
     	}

		public UnityEngine.UI.Button ELevel310Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel310Button == null )
     			{
		    		this.m_ELevel310Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel310");
     			}
     			return this.m_ELevel310Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel310Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel310Image == null )
     			{
		    		this.m_ELevel310Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel310");
     			}
     			return this.m_ELevel310Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level310Stars1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level310Stars1Image == null )
     			{
		    		this.m_E_Level310Stars1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel310/E_Level310Stars1");
     			}
     			return this.m_E_Level310Stars1Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level310Stars2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level310Stars2Image == null )
     			{
		    		this.m_E_Level310Stars2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel310/E_Level310Stars2");
     			}
     			return this.m_E_Level310Stars2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level310Stars3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level310Stars3Image == null )
     			{
		    		this.m_E_Level310Stars3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter3/ELevel310/E_Level310Stars3");
     			}
     			return this.m_E_Level310Stars3Image;
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

		public UnityEngine.UI.Image ECoinDisplayImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ECoinDisplayImage == null )
     			{
		    		this.m_ECoinDisplayImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"ECoinDisplay");
     			}
     			return this.m_ECoinDisplayImage;
     		}
     	}

		public UnityEngine.UI.Text EText_CoinNumberText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EText_CoinNumberText == null )
     			{
		    		this.m_EText_CoinNumberText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ECoinDisplay/EText_CoinNumber");
     			}
     			return this.m_EText_CoinNumberText;
     		}
     	}

		public UnityEngine.UI.Button E_NextChapterButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextChapterButton == null )
     			{
		    		this.m_E_NextChapterButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_NextChapter");
     			}
     			return this.m_E_NextChapterButton;
     		}
     	}

		public UnityEngine.UI.Image E_NextChapterImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextChapterImage == null )
     			{
		    		this.m_E_NextChapterImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_NextChapter");
     			}
     			return this.m_E_NextChapterImage;
     		}
     	}

		public UnityEngine.UI.Button E_LastChapterButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LastChapterButton == null )
     			{
		    		this.m_E_LastChapterButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_LastChapter");
     			}
     			return this.m_E_LastChapterButton;
     		}
     	}

		public UnityEngine.UI.Image E_LastChapterImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LastChapterImage == null )
     			{
		    		this.m_E_LastChapterImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_LastChapter");
     			}
     			return this.m_E_LastChapterImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower1FrameImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1FrameImage == null )
     			{
		    		this.m_E_Tower1FrameImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower1Frame");
     			}
     			return this.m_E_Tower1FrameImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower1ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1ImageImage == null )
     			{
		    		this.m_E_Tower1ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower1Frame/E_Tower1Image");
     			}
     			return this.m_E_Tower1ImageImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower2FrameImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower2FrameImage == null )
     			{
		    		this.m_E_Tower2FrameImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower2Frame");
     			}
     			return this.m_E_Tower2FrameImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower2ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower2ImageImage == null )
     			{
		    		this.m_E_Tower2ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower2Frame/E_Tower2Image");
     			}
     			return this.m_E_Tower2ImageImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower3FrameImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower3FrameImage == null )
     			{
		    		this.m_E_Tower3FrameImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower3Frame");
     			}
     			return this.m_E_Tower3FrameImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower3ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower3ImageImage == null )
     			{
		    		this.m_E_Tower3ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower3Frame/E_Tower3Image");
     			}
     			return this.m_E_Tower3ImageImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower4FrameImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower4FrameImage == null )
     			{
		    		this.m_E_Tower4FrameImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower4Frame");
     			}
     			return this.m_E_Tower4FrameImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower4ImageImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower4ImageImage == null )
     			{
		    		this.m_E_Tower4ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower4Frame/E_Tower4Image");
     			}
     			return this.m_E_Tower4ImageImage;
     		}
     	}

		public UnityEngine.UI.Button E_AdjustButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AdjustButton == null )
     			{
		    		this.m_E_AdjustButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Formation/E_Adjust");
     			}
     			return this.m_E_AdjustButton;
     		}
     	}

		public UnityEngine.UI.Image E_AdjustImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AdjustImage == null )
     			{
		    		this.m_E_AdjustImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Adjust");
     			}
     			return this.m_E_AdjustImage;
     		}
     	}

		public UnityEngine.UI.Image E_ChapterIntroductImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ChapterIntroductImage == null )
     			{
		    		this.m_E_ChapterIntroductImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct");
     			}
     			return this.m_E_ChapterIntroductImage;
     		}
     	}

		public UnityEngine.UI.Button E_IntroductCloseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_IntroductCloseButton == null )
     			{
		    		this.m_E_IntroductCloseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_IntroductClose");
     			}
     			return this.m_E_IntroductCloseButton;
     		}
     	}

		public UnityEngine.UI.Image E_IntroductCloseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_IntroductCloseImage == null )
     			{
		    		this.m_E_IntroductCloseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_IntroductClose");
     			}
     			return this.m_E_IntroductCloseImage;
     		}
     	}

		public UnityEngine.UI.Text E_IntroductLeveText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_IntroductLeveText == null )
     			{
		    		this.m_E_IntroductLeveText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_IntroductLeve");
     			}
     			return this.m_E_IntroductLeveText;
     		}
     	}

		public UnityEngine.UI.Text E_LeveNameText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LeveNameText == null )
     			{
		    		this.m_E_LeveNameText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_LeveName");
     			}
     			return this.m_E_LeveNameText;
     		}
     	}

		public UnityEngine.UI.Text E_MosterIntroductText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MosterIntroductText == null )
     			{
		    		this.m_E_MosterIntroductText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_MosterIntroduct");
     			}
     			return this.m_E_MosterIntroductText;
     		}
     	}

		public UnityEngine.UI.Image E_Reward1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Reward1Image == null )
     			{
		    		this.m_E_Reward1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar1/E_Reward1");
     			}
     			return this.m_E_Reward1Image;
     		}
     	}

		public UnityEngine.UI.Text E_RweardNum1Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RweardNum1Text == null )
     			{
		    		this.m_E_RweardNum1Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar1/E_Reward1/E_RweardNum1");
     			}
     			return this.m_E_RweardNum1Text;
     		}
     	}

		public UnityEngine.UI.Image E_Reward12Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Reward12Image == null )
     			{
		    		this.m_E_Reward12Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar1/E_Reward12");
     			}
     			return this.m_E_Reward12Image;
     		}
     	}

		public UnityEngine.UI.Text E_RweardNum12Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RweardNum12Text == null )
     			{
		    		this.m_E_RweardNum12Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar1/E_Reward12/E_RweardNum12");
     			}
     			return this.m_E_RweardNum12Text;
     		}
     	}

		public UnityEngine.UI.Image E_Reward22Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Reward22Image == null )
     			{
		    		this.m_E_Reward22Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar2/E_Reward22");
     			}
     			return this.m_E_Reward22Image;
     		}
     	}

		public UnityEngine.UI.Text E_RweardNum22Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RweardNum22Text == null )
     			{
		    		this.m_E_RweardNum22Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar2/E_Reward22/E_RweardNum22");
     			}
     			return this.m_E_RweardNum22Text;
     		}
     	}

		public UnityEngine.UI.Image E_Reward2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Reward2Image == null )
     			{
		    		this.m_E_Reward2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar2/E_Reward2");
     			}
     			return this.m_E_Reward2Image;
     		}
     	}

		public UnityEngine.UI.Text E_RweardNum2Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RweardNum2Text == null )
     			{
		    		this.m_E_RweardNum2Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar2/E_Reward2/E_RweardNum2");
     			}
     			return this.m_E_RweardNum2Text;
     		}
     	}

		public UnityEngine.UI.Image E_Reward3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Reward3Image == null )
     			{
		    		this.m_E_Reward3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar3/E_Reward3");
     			}
     			return this.m_E_Reward3Image;
     		}
     	}

		public UnityEngine.UI.Text E_RweardNum3Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RweardNum3Text == null )
     			{
		    		this.m_E_RweardNum3Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar3/E_Reward3/E_RweardNum3");
     			}
     			return this.m_E_RweardNum3Text;
     		}
     	}

		public UnityEngine.UI.Image E_Reward32Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Reward32Image == null )
     			{
		    		this.m_E_Reward32Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar3/E_Reward32");
     			}
     			return this.m_E_Reward32Image;
     		}
     	}

		public UnityEngine.UI.Text E_RweardNum32Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RweardNum32Text == null )
     			{
		    		this.m_E_RweardNum32Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_ChapterIntroduct/Reward/Bg/RewardStar3/E_Reward32/E_RweardNum32");
     			}
     			return this.m_E_RweardNum32Text;
     		}
     	}

		public UnityEngine.UI.Button E_FightButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_FightButton == null )
     			{
		    		this.m_E_FightButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_Fight");
     			}
     			return this.m_E_FightButton;
     		}
     	}

		public UnityEngine.UI.Image E_FightImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_FightImage == null )
     			{
		    		this.m_E_FightImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_Fight");
     			}
     			return this.m_E_FightImage;
     		}
     	}

		public UnityEngine.UI.Image E_MapIntImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MapIntImage == null )
     			{
		    		this.m_E_MapIntImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/MapShow/E_MapInt");
     			}
     			return this.m_E_MapIntImage;
     		}
     	}

		public UnityEngine.UI.Image EnemyLineImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EnemyLineImage == null )
     			{
		    		this.m_EnemyLineImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/EnemyLine");
     			}
     			return this.m_EnemyLineImage;
     		}
     	}

		public UnityEngine.UI.LoopHorizontalScrollRect E_EnemysLoopHorizontalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_EnemysLoopHorizontalScrollRect == null )
     			{
		    		this.m_E_EnemysLoopHorizontalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopHorizontalScrollRect>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_Enemys");
     			}
     			return this.m_E_EnemysLoopHorizontalScrollRect;
     		}
     	}

		public UnityEngine.UI.Dropdown E_ChapterSelectDropdown
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ChapterSelectDropdown == null )
     			{
		    		this.m_E_ChapterSelectDropdown = UIFindHelper.FindDeepChild<UnityEngine.UI.Dropdown>(this.uiTransform.gameObject,"E_ChapterSelect");
     			}
     			return this.m_E_ChapterSelectDropdown;
     		}
     	}

		public UnityEngine.UI.Image E_ChapterSelectImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ChapterSelectImage == null )
     			{
		    		this.m_E_ChapterSelectImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterSelect");
     			}
     			return this.m_E_ChapterSelectImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_ChaptersImage = null;
			this.m_E_Chapter1ToggleGroup = null;
			this.m_E_Chapter1Image = null;
			this.m_E_Level11Button = null;
			this.m_E_Level11Image = null;
			this.m_E_Level11Stars1Image = null;
			this.m_E_Level11Stars2Image = null;
			this.m_E_Level11Stars3Image = null;
			this.m_E_Level11Bean1Image = null;
			this.m_E_Level11Bean2Image = null;
			this.m_E_Level11Bean3Image = null;
			this.m_E_Level11Bean4Image = null;
			this.m_ELevel12Button = null;
			this.m_ELevel12Image = null;
			this.m_E_Level12Stars1Image = null;
			this.m_E_Level12Stars2Image = null;
			this.m_E_Level12Stars3Image = null;
			this.m_E_Level12Bean1Image = null;
			this.m_E_Level12Bean2Image = null;
			this.m_E_Level12Bean3Image = null;
			this.m_ELevel13Button = null;
			this.m_ELevel13Image = null;
			this.m_E_Level13Stars1Image = null;
			this.m_E_Level13Stars2Image = null;
			this.m_E_Level13Stars3Image = null;
			this.m_E_Level13Bean1Image = null;
			this.m_E_Level13Bean2Image = null;
			this.m_E_Level13Bean3Image = null;
			this.m_ELevel14Button = null;
			this.m_ELevel14Image = null;
			this.m_E_Level14Stars1Image = null;
			this.m_E_Level14Stars2Image = null;
			this.m_E_Level14Stars3Image = null;
			this.m_E_Level14Bean1Image = null;
			this.m_E_Level14Bean2Image = null;
			this.m_ELevel15Button = null;
			this.m_ELevel15Image = null;
			this.m_E_Level15Stars1Image = null;
			this.m_E_Level15Stars2Image = null;
			this.m_E_Level15Stars3Image = null;
			this.m_E_Level15Bean1Image = null;
			this.m_E_Level15Bean2Image = null;
			this.m_E_Level15Bean3Image = null;
			this.m_ELevel16Button = null;
			this.m_ELevel16Image = null;
			this.m_E_Level16Stars1Image = null;
			this.m_E_Level16Stars2Image = null;
			this.m_E_Level16Stars3Image = null;
			this.m_E_Level16Bean1Image = null;
			this.m_E_Level16Bean2Image = null;
			this.m_E_Level16Bean3Image = null;
			this.m_ELevel17Button = null;
			this.m_ELevel17Image = null;
			this.m_E_Level17Stars1Image = null;
			this.m_E_Level17Stars2Image = null;
			this.m_E_Level17Stars3Image = null;
			this.m_E_Level17Bean1Image = null;
			this.m_E_Level17Bean2Image = null;
			this.m_E_Level17Bean3Image = null;
			this.m_ELevel18Button = null;
			this.m_ELevel18Image = null;
			this.m_E_Level18Stars1Image = null;
			this.m_E_Level18Stars2Image = null;
			this.m_E_Level18Stars3Image = null;
			this.m_E_Level18Bean1Image = null;
			this.m_E_Level18Bean2Image = null;
			this.m_E_Level18Bean3Image = null;
			this.m_ELevel19Button = null;
			this.m_ELevel19Image = null;
			this.m_E_Level19Stars1Image = null;
			this.m_E_Level19Stars2Image = null;
			this.m_E_Level19Stars3Image = null;
			this.m_E_Level19Bean1Image = null;
			this.m_E_Level19Bean2Image = null;
			this.m_E_Level19Bean3Image = null;
			this.m_ELevel110Button = null;
			this.m_ELevel110Image = null;
			this.m_E_Level110Stars1Image = null;
			this.m_E_Level110Stars2Image = null;
			this.m_E_Level110Stars3Image = null;
			this.m_E_Chapter2ToggleGroup = null;
			this.m_E_Chapter2Image = null;
			this.m_E_Level21Button = null;
			this.m_E_Level21Image = null;
			this.m_E_Level21Stars1Image = null;
			this.m_E_Level21Stars2Image = null;
			this.m_E_Level21Stars3Image = null;
			this.m_E_Level21Bean1Image = null;
			this.m_E_Level21Bean2Image = null;
			this.m_E_Level21Bean3Image = null;
			this.m_E_Level21Bean4Image = null;
			this.m_ELevel22Button = null;
			this.m_ELevel22Image = null;
			this.m_E_Level22Stars1Image = null;
			this.m_E_Level22Stars2Image = null;
			this.m_E_Level22Stars3Image = null;
			this.m_E_Level22Bean1Image = null;
			this.m_E_Level22Bean2Image = null;
			this.m_E_Level22Bean3Image = null;
			this.m_ELevel23Button = null;
			this.m_ELevel23Image = null;
			this.m_E_Level23Stars1Image = null;
			this.m_E_Level23Stars2Image = null;
			this.m_E_Level23Stars3Image = null;
			this.m_E_Level23Bean1Image = null;
			this.m_E_Level23Bean2Image = null;
			this.m_E_Level23Bean3Image = null;
			this.m_ELevel24Button = null;
			this.m_ELevel24Image = null;
			this.m_E_Level24Stars1Image = null;
			this.m_E_Level24Stars2Image = null;
			this.m_E_Level24Stars3Image = null;
			this.m_E_Level24Bean1Image = null;
			this.m_E_Level24Bean2Image = null;
			this.m_ELevel25Button = null;
			this.m_ELevel25Image = null;
			this.m_E_Level25Stars1Image = null;
			this.m_E_Level25Stars2Image = null;
			this.m_E_Level25Stars3Image = null;
			this.m_E_Level25Bean1Image = null;
			this.m_E_Level25Bean2Image = null;
			this.m_E_Level25Bean3Image = null;
			this.m_ELevel26Button = null;
			this.m_ELevel26Image = null;
			this.m_E_Level26Stars1Image = null;
			this.m_E_Level26Stars2Image = null;
			this.m_E_Level26Stars3Image = null;
			this.m_E_Level26Bean1Image = null;
			this.m_E_Level26Bean2Image = null;
			this.m_E_Level26Bean3Image = null;
			this.m_ELevel27Button = null;
			this.m_ELevel27Image = null;
			this.m_E_Level27Stars1Image = null;
			this.m_E_Level27Stars2Image = null;
			this.m_E_Level27Stars3Image = null;
			this.m_E_Level27Bean1Image = null;
			this.m_E_Level27Bean2Image = null;
			this.m_E_Level27Bean3Image = null;
			this.m_ELevel28Button = null;
			this.m_ELevel28Image = null;
			this.m_E_Level28Stars1Image = null;
			this.m_E_Level28Stars2Image = null;
			this.m_E_Level28Stars3Image = null;
			this.m_E_Level28Bean1Image = null;
			this.m_E_Level28Bean2Image = null;
			this.m_E_Level28Bean3Image = null;
			this.m_ELevel29Button = null;
			this.m_ELevel29Image = null;
			this.m_E_Level29Stars1Image = null;
			this.m_E_Level29Stars2Image = null;
			this.m_E_Level29Stars3Image = null;
			this.m_E_Level29Bean1Image = null;
			this.m_E_Level29Bean2Image = null;
			this.m_E_Level29Bean3Image = null;
			this.m_ELevel210Button = null;
			this.m_ELevel210Image = null;
			this.m_E_Level210Stars1Image = null;
			this.m_E_Level210Stars2Image = null;
			this.m_E_Level210Stars3Image = null;
			this.m_E_Chapter3ToggleGroup = null;
			this.m_E_Chapter3Image = null;
			this.m_E_Level31Button = null;
			this.m_E_Level31Image = null;
			this.m_E_Level31Stars1Image = null;
			this.m_E_Level31Stars2Image = null;
			this.m_E_Level31Stars3Image = null;
			this.m_E_Level31Bean1Image = null;
			this.m_E_Level31Bean2Image = null;
			this.m_E_Level31Bean3Image = null;
			this.m_E_Level31Bean4Image = null;
			this.m_ELevel32Button = null;
			this.m_ELevel32Image = null;
			this.m_E_Level32Stars1Image = null;
			this.m_E_Level32Stars2Image = null;
			this.m_E_Level32Stars3Image = null;
			this.m_E_Level32Bean1Image = null;
			this.m_E_Level32Bean2Image = null;
			this.m_E_Level32Bean3Image = null;
			this.m_ELevel33Button = null;
			this.m_ELevel33Image = null;
			this.m_E_Level33Stars1Image = null;
			this.m_E_Level33Stars2Image = null;
			this.m_E_Level33Stars3Image = null;
			this.m_E_Level33Bean1Image = null;
			this.m_E_Level33Bean2Image = null;
			this.m_E_Level33Bean3Image = null;
			this.m_ELevel34Button = null;
			this.m_ELevel34Image = null;
			this.m_E_Level34Stars1Image = null;
			this.m_E_Level34Stars2Image = null;
			this.m_E_Level34Stars3Image = null;
			this.m_E_Level34Bean1Image = null;
			this.m_E_Level34Bean2Image = null;
			this.m_ELevel35Button = null;
			this.m_ELevel35Image = null;
			this.m_E_Level35Stars1Image = null;
			this.m_E_Level35Stars2Image = null;
			this.m_E_Level35Stars3Image = null;
			this.m_E_Level35Bean1Image = null;
			this.m_E_Level35Bean2Image = null;
			this.m_E_Level35Bean3Image = null;
			this.m_ELevel36Button = null;
			this.m_ELevel36Image = null;
			this.m_E_Level36Stars1Image = null;
			this.m_E_Level36Stars2Image = null;
			this.m_E_Level36Stars3Image = null;
			this.m_E_Level36Bean1Image = null;
			this.m_E_Level36Bean2Image = null;
			this.m_E_Level36Bean3Image = null;
			this.m_ELevel37Button = null;
			this.m_ELevel37Image = null;
			this.m_E_Level37Stars1Image = null;
			this.m_E_Level37Stars2Image = null;
			this.m_E_Level37Stars3Image = null;
			this.m_E_Level37Bean1Image = null;
			this.m_E_Level37Bean2Image = null;
			this.m_E_Level37Bean3Image = null;
			this.m_ELevel38Button = null;
			this.m_ELevel38Image = null;
			this.m_E_Level38Stars1Image = null;
			this.m_E_Level38Stars2Image = null;
			this.m_E_Level38Stars3Image = null;
			this.m_E_Level38Bean1Image = null;
			this.m_E_Level38Bean2Image = null;
			this.m_E_Level38Bean3Image = null;
			this.m_ELevel39Button = null;
			this.m_ELevel39Image = null;
			this.m_E_Level39Stars1Image = null;
			this.m_E_Level39Stars2Image = null;
			this.m_E_Level39Stars3Image = null;
			this.m_E_Level39Bean1Image = null;
			this.m_E_Level39Bean2Image = null;
			this.m_E_Level39Bean3Image = null;
			this.m_ELevel310Button = null;
			this.m_ELevel310Image = null;
			this.m_E_Level310Stars1Image = null;
			this.m_E_Level310Stars2Image = null;
			this.m_E_Level310Stars3Image = null;
			this.m_E_BackBaseButton = null;
			this.m_E_BackBaseImage = null;
			this.m_ECoinDisplayImage = null;
			this.m_EText_CoinNumberText = null;
			this.m_E_NextChapterButton = null;
			this.m_E_NextChapterImage = null;
			this.m_E_LastChapterButton = null;
			this.m_E_LastChapterImage = null;
			this.m_E_Tower1FrameImage = null;
			this.m_E_Tower1ImageImage = null;
			this.m_E_Tower2FrameImage = null;
			this.m_E_Tower2ImageImage = null;
			this.m_E_Tower3FrameImage = null;
			this.m_E_Tower3ImageImage = null;
			this.m_E_Tower4FrameImage = null;
			this.m_E_Tower4ImageImage = null;
			this.m_E_AdjustButton = null;
			this.m_E_AdjustImage = null;
			this.m_E_ChapterIntroductImage = null;
			this.m_E_IntroductCloseButton = null;
			this.m_E_IntroductCloseImage = null;
			this.m_E_IntroductLeveText = null;
			this.m_E_LeveNameText = null;
			this.m_E_MosterIntroductText = null;
			this.m_E_Reward1Image = null;
			this.m_E_RweardNum1Text = null;
			this.m_E_Reward12Image = null;
			this.m_E_RweardNum12Text = null;
			this.m_E_Reward22Image = null;
			this.m_E_RweardNum22Text = null;
			this.m_E_Reward2Image = null;
			this.m_E_RweardNum2Text = null;
			this.m_E_Reward3Image = null;
			this.m_E_RweardNum3Text = null;
			this.m_E_Reward32Image = null;
			this.m_E_RweardNum32Text = null;
			this.m_E_FightButton = null;
			this.m_E_FightImage = null;
			this.m_E_MapIntImage = null;
			this.m_EnemyLineImage = null;
			this.m_E_EnemysLoopHorizontalScrollRect = null;
			this.m_E_ChapterSelectDropdown = null;
			this.m_E_ChapterSelectImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Image m_E_ChaptersImage = null;
		private UnityEngine.UI.ToggleGroup m_E_Chapter1ToggleGroup = null;
		private UnityEngine.UI.Image m_E_Chapter1Image = null;
		private UnityEngine.UI.Button m_E_Level11Button = null;
		private UnityEngine.UI.Image m_E_Level11Image = null;
		private UnityEngine.UI.Image m_E_Level11Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level11Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level11Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level11Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level11Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level11Bean3Image = null;
		private UnityEngine.UI.Image m_E_Level11Bean4Image = null;
		private UnityEngine.UI.Button m_ELevel12Button = null;
		private UnityEngine.UI.Image m_ELevel12Image = null;
		private UnityEngine.UI.Image m_E_Level12Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level12Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level12Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level12Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level12Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level12Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel13Button = null;
		private UnityEngine.UI.Image m_ELevel13Image = null;
		private UnityEngine.UI.Image m_E_Level13Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level13Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level13Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level13Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level13Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level13Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel14Button = null;
		private UnityEngine.UI.Image m_ELevel14Image = null;
		private UnityEngine.UI.Image m_E_Level14Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level14Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level14Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level14Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level14Bean2Image = null;
		private UnityEngine.UI.Button m_ELevel15Button = null;
		private UnityEngine.UI.Image m_ELevel15Image = null;
		private UnityEngine.UI.Image m_E_Level15Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level15Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level15Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level15Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level15Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level15Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel16Button = null;
		private UnityEngine.UI.Image m_ELevel16Image = null;
		private UnityEngine.UI.Image m_E_Level16Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level16Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level16Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level16Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level16Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level16Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel17Button = null;
		private UnityEngine.UI.Image m_ELevel17Image = null;
		private UnityEngine.UI.Image m_E_Level17Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level17Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level17Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level17Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level17Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level17Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel18Button = null;
		private UnityEngine.UI.Image m_ELevel18Image = null;
		private UnityEngine.UI.Image m_E_Level18Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level18Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level18Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level18Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level18Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level18Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel19Button = null;
		private UnityEngine.UI.Image m_ELevel19Image = null;
		private UnityEngine.UI.Image m_E_Level19Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level19Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level19Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level19Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level19Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level19Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel110Button = null;
		private UnityEngine.UI.Image m_ELevel110Image = null;
		private UnityEngine.UI.Image m_E_Level110Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level110Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level110Stars3Image = null;
		private UnityEngine.UI.ToggleGroup m_E_Chapter2ToggleGroup = null;
		private UnityEngine.UI.Image m_E_Chapter2Image = null;
		private UnityEngine.UI.Button m_E_Level21Button = null;
		private UnityEngine.UI.Image m_E_Level21Image = null;
		private UnityEngine.UI.Image m_E_Level21Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level21Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level21Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level21Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level21Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level21Bean3Image = null;
		private UnityEngine.UI.Image m_E_Level21Bean4Image = null;
		private UnityEngine.UI.Button m_ELevel22Button = null;
		private UnityEngine.UI.Image m_ELevel22Image = null;
		private UnityEngine.UI.Image m_E_Level22Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level22Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level22Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level22Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level22Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level22Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel23Button = null;
		private UnityEngine.UI.Image m_ELevel23Image = null;
		private UnityEngine.UI.Image m_E_Level23Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level23Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level23Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level23Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level23Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level23Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel24Button = null;
		private UnityEngine.UI.Image m_ELevel24Image = null;
		private UnityEngine.UI.Image m_E_Level24Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level24Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level24Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level24Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level24Bean2Image = null;
		private UnityEngine.UI.Button m_ELevel25Button = null;
		private UnityEngine.UI.Image m_ELevel25Image = null;
		private UnityEngine.UI.Image m_E_Level25Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level25Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level25Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level25Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level25Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level25Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel26Button = null;
		private UnityEngine.UI.Image m_ELevel26Image = null;
		private UnityEngine.UI.Image m_E_Level26Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level26Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level26Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level26Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level26Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level26Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel27Button = null;
		private UnityEngine.UI.Image m_ELevel27Image = null;
		private UnityEngine.UI.Image m_E_Level27Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level27Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level27Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level27Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level27Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level27Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel28Button = null;
		private UnityEngine.UI.Image m_ELevel28Image = null;
		private UnityEngine.UI.Image m_E_Level28Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level28Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level28Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level28Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level28Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level28Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel29Button = null;
		private UnityEngine.UI.Image m_ELevel29Image = null;
		private UnityEngine.UI.Image m_E_Level29Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level29Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level29Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level29Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level29Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level29Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel210Button = null;
		private UnityEngine.UI.Image m_ELevel210Image = null;
		private UnityEngine.UI.Image m_E_Level210Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level210Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level210Stars3Image = null;
		private UnityEngine.UI.ToggleGroup m_E_Chapter3ToggleGroup = null;
		private UnityEngine.UI.Image m_E_Chapter3Image = null;
		private UnityEngine.UI.Button m_E_Level31Button = null;
		private UnityEngine.UI.Image m_E_Level31Image = null;
		private UnityEngine.UI.Image m_E_Level31Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level31Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level31Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level31Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level31Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level31Bean3Image = null;
		private UnityEngine.UI.Image m_E_Level31Bean4Image = null;
		private UnityEngine.UI.Button m_ELevel32Button = null;
		private UnityEngine.UI.Image m_ELevel32Image = null;
		private UnityEngine.UI.Image m_E_Level32Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level32Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level32Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level32Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level32Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level32Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel33Button = null;
		private UnityEngine.UI.Image m_ELevel33Image = null;
		private UnityEngine.UI.Image m_E_Level33Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level33Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level33Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level33Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level33Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level33Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel34Button = null;
		private UnityEngine.UI.Image m_ELevel34Image = null;
		private UnityEngine.UI.Image m_E_Level34Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level34Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level34Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level34Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level34Bean2Image = null;
		private UnityEngine.UI.Button m_ELevel35Button = null;
		private UnityEngine.UI.Image m_ELevel35Image = null;
		private UnityEngine.UI.Image m_E_Level35Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level35Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level35Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level35Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level35Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level35Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel36Button = null;
		private UnityEngine.UI.Image m_ELevel36Image = null;
		private UnityEngine.UI.Image m_E_Level36Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level36Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level36Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level36Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level36Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level36Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel37Button = null;
		private UnityEngine.UI.Image m_ELevel37Image = null;
		private UnityEngine.UI.Image m_E_Level37Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level37Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level37Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level37Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level37Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level37Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel38Button = null;
		private UnityEngine.UI.Image m_ELevel38Image = null;
		private UnityEngine.UI.Image m_E_Level38Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level38Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level38Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level38Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level38Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level38Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel39Button = null;
		private UnityEngine.UI.Image m_ELevel39Image = null;
		private UnityEngine.UI.Image m_E_Level39Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level39Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level39Stars3Image = null;
		private UnityEngine.UI.Image m_E_Level39Bean1Image = null;
		private UnityEngine.UI.Image m_E_Level39Bean2Image = null;
		private UnityEngine.UI.Image m_E_Level39Bean3Image = null;
		private UnityEngine.UI.Button m_ELevel310Button = null;
		private UnityEngine.UI.Image m_ELevel310Image = null;
		private UnityEngine.UI.Image m_E_Level310Stars1Image = null;
		private UnityEngine.UI.Image m_E_Level310Stars2Image = null;
		private UnityEngine.UI.Image m_E_Level310Stars3Image = null;
		private UnityEngine.UI.Button m_E_BackBaseButton = null;
		private UnityEngine.UI.Image m_E_BackBaseImage = null;
		private UnityEngine.UI.Image m_ECoinDisplayImage = null;
		private UnityEngine.UI.Text m_EText_CoinNumberText = null;
		private UnityEngine.UI.Button m_E_NextChapterButton = null;
		private UnityEngine.UI.Image m_E_NextChapterImage = null;
		private UnityEngine.UI.Button m_E_LastChapterButton = null;
		private UnityEngine.UI.Image m_E_LastChapterImage = null;
		private UnityEngine.UI.Image m_E_Tower1FrameImage = null;
		private UnityEngine.UI.Image m_E_Tower1ImageImage = null;
		private UnityEngine.UI.Image m_E_Tower2FrameImage = null;
		private UnityEngine.UI.Image m_E_Tower2ImageImage = null;
		private UnityEngine.UI.Image m_E_Tower3FrameImage = null;
		private UnityEngine.UI.Image m_E_Tower3ImageImage = null;
		private UnityEngine.UI.Image m_E_Tower4FrameImage = null;
		private UnityEngine.UI.Image m_E_Tower4ImageImage = null;
		private UnityEngine.UI.Button m_E_AdjustButton = null;
		private UnityEngine.UI.Image m_E_AdjustImage = null;
		private UnityEngine.UI.Image m_E_ChapterIntroductImage = null;
		private UnityEngine.UI.Button m_E_IntroductCloseButton = null;
		private UnityEngine.UI.Image m_E_IntroductCloseImage = null;
		private UnityEngine.UI.Text m_E_IntroductLeveText = null;
		private UnityEngine.UI.Text m_E_LeveNameText = null;
		private UnityEngine.UI.Text m_E_MosterIntroductText = null;
		private UnityEngine.UI.Image m_E_Reward1Image = null;
		private UnityEngine.UI.Text m_E_RweardNum1Text = null;
		private UnityEngine.UI.Image m_E_Reward12Image = null;
		private UnityEngine.UI.Text m_E_RweardNum12Text = null;
		private UnityEngine.UI.Image m_E_Reward22Image = null;
		private UnityEngine.UI.Text m_E_RweardNum22Text = null;
		private UnityEngine.UI.Image m_E_Reward2Image = null;
		private UnityEngine.UI.Text m_E_RweardNum2Text = null;
		private UnityEngine.UI.Image m_E_Reward3Image = null;
		private UnityEngine.UI.Text m_E_RweardNum3Text = null;
		private UnityEngine.UI.Image m_E_Reward32Image = null;
		private UnityEngine.UI.Text m_E_RweardNum32Text = null;
		private UnityEngine.UI.Button m_E_FightButton = null;
		private UnityEngine.UI.Image m_E_FightImage = null;
		private UnityEngine.UI.Image m_E_MapIntImage = null;
		private UnityEngine.UI.Image m_EnemyLineImage = null;
		private UnityEngine.UI.LoopHorizontalScrollRect m_E_EnemysLoopHorizontalScrollRect = null;
		private UnityEngine.UI.Dropdown m_E_ChapterSelectDropdown = null;
		private UnityEngine.UI.Image m_E_ChapterSelectImage = null;
		public Transform uiTransform = null;
	}
}
