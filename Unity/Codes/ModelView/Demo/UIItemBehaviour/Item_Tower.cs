
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class Scroll_Item_Tower : Entity,IAwake,IDestroy,IUIScrollItem 
	{
		public long DataId {get;set;}
		private bool isCacheNode = false;
		public void SetCacheMode(bool isCache)
		{
			this.isCacheNode = isCache;
		}

		public Scroll_Item_Tower BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public UnityEngine.UI.Image E_TowerIconBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerIconBaseImage == null )
     				{
		    			this.m_E_TowerIconBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIconBase");
     				}
     				return this.m_E_TowerIconBaseImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIconBase");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerIconImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerIconImage == null )
     				{
		    			this.m_E_TowerIconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIconBase/E_TowerIcon");
     				}
     				return this.m_E_TowerIconImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIconBase/E_TowerIcon");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerHandBookImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerHandBookImage == null )
     				{
		    			this.m_E_TowerHandBookImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook");
     				}
     				return this.m_E_TowerHandBookImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerBookLevel1BaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel1BaseImage == null )
     				{
		    			this.m_E_TowerBookLevel1BaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel1Base");
     				}
     				return this.m_E_TowerBookLevel1BaseImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel1Base");
     			}
     		}
     	}

		public UnityEngine.UI.Button E_TowerBookLevel1Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel1Button == null )
     				{
		    			this.m_E_TowerBookLevel1Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel1Base/E_TowerBookLevel1");
     				}
     				return this.m_E_TowerBookLevel1Button;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel1Base/E_TowerBookLevel1");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerBookLevel1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel1Image == null )
     				{
		    			this.m_E_TowerBookLevel1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel1Base/E_TowerBookLevel1");
     				}
     				return this.m_E_TowerBookLevel1Image;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel1Base/E_TowerBookLevel1");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerBookLevel2BaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel2BaseImage == null )
     				{
		    			this.m_E_TowerBookLevel2BaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel2Base");
     				}
     				return this.m_E_TowerBookLevel2BaseImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel2Base");
     			}
     		}
     	}

		public UnityEngine.UI.Button E_TowerBookLevel2Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel2Button == null )
     				{
		    			this.m_E_TowerBookLevel2Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel2Base/E_TowerBookLevel2");
     				}
     				return this.m_E_TowerBookLevel2Button;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel2Base/E_TowerBookLevel2");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerBookLevel2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel2Image == null )
     				{
		    			this.m_E_TowerBookLevel2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel2Base/E_TowerBookLevel2");
     				}
     				return this.m_E_TowerBookLevel2Image;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel2Base/E_TowerBookLevel2");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerBookLevel3BaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel3BaseImage == null )
     				{
		    			this.m_E_TowerBookLevel3BaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel3Base");
     				}
     				return this.m_E_TowerBookLevel3BaseImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel3Base");
     			}
     		}
     	}

		public UnityEngine.UI.Button E_TowerBookLevel3Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel3Button == null )
     				{
		    			this.m_E_TowerBookLevel3Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel3Base/E_TowerBookLevel3");
     				}
     				return this.m_E_TowerBookLevel3Button;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel3Base/E_TowerBookLevel3");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerBookLevel3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_TowerBookLevel3Image == null )
     				{
		    			this.m_E_TowerBookLevel3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel3Base/E_TowerBookLevel3");
     				}
     				return this.m_E_TowerBookLevel3Image;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerHandBook/E_TowerBookLevel3Base/E_TowerBookLevel3");
     			}
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_TowerIconBaseImage = null;
			this.m_E_TowerIconImage = null;
			this.m_E_TowerHandBookImage = null;
			this.m_E_TowerBookLevel1BaseImage = null;
			this.m_E_TowerBookLevel1Button = null;
			this.m_E_TowerBookLevel1Image = null;
			this.m_E_TowerBookLevel2BaseImage = null;
			this.m_E_TowerBookLevel2Button = null;
			this.m_E_TowerBookLevel2Image = null;
			this.m_E_TowerBookLevel3BaseImage = null;
			this.m_E_TowerBookLevel3Button = null;
			this.m_E_TowerBookLevel3Image = null;
			this.uiTransform = null;
			this.DataId = 0;
		}

		private UnityEngine.UI.Image m_E_TowerIconBaseImage = null;
		private UnityEngine.UI.Image m_E_TowerIconImage = null;
		private UnityEngine.UI.Image m_E_TowerHandBookImage = null;
		private UnityEngine.UI.Image m_E_TowerBookLevel1BaseImage = null;
		private UnityEngine.UI.Button m_E_TowerBookLevel1Button = null;
		private UnityEngine.UI.Image m_E_TowerBookLevel1Image = null;
		private UnityEngine.UI.Image m_E_TowerBookLevel2BaseImage = null;
		private UnityEngine.UI.Button m_E_TowerBookLevel2Button = null;
		private UnityEngine.UI.Image m_E_TowerBookLevel2Image = null;
		private UnityEngine.UI.Image m_E_TowerBookLevel3BaseImage = null;
		private UnityEngine.UI.Button m_E_TowerBookLevel3Button = null;
		private UnityEngine.UI.Image m_E_TowerBookLevel3Image = null;
		public Transform uiTransform = null;
	}
}
