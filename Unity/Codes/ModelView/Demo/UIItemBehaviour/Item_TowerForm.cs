
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class Scroll_Item_TowerForm : Entity,IAwake,IDestroy,IUIScrollItem 
	{
		public long DataId {get;set;}
		private bool isCacheNode = false;
		public void SetCacheMode(bool isCache)
		{
			this.isCacheNode = isCache;
		}

		public Scroll_Item_TowerForm BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public UnityEngine.UI.Button E_TowerIconButton
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
     				if( this.m_E_TowerIconButton == null )
     				{
		    			this.m_E_TowerIconButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerIcon");
     				}
     				return this.m_E_TowerIconButton;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_TowerIcon");
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
		    			this.m_E_TowerIconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon");
     				}
     				return this.m_E_TowerIconImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_SelectedBigImage
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
     				if( this.m_E_SelectedBigImage == null )
     				{
		    			this.m_E_SelectedBigImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon/E_SelectedBig");
     				}
     				return this.m_E_SelectedBigImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon/E_SelectedBig");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerSelectFormImage
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
     				if( this.m_E_TowerSelectFormImage == null )
     				{
		    			this.m_E_TowerSelectFormImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon/E_TowerSelectForm");
     				}
     				return this.m_E_TowerSelectFormImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon/E_TowerSelectForm");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_TowerNomerFormImage
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
     				if( this.m_E_TowerNomerFormImage == null )
     				{
		    			this.m_E_TowerNomerFormImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon/E_TowerNomerForm");
     				}
     				return this.m_E_TowerNomerFormImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_TowerIcon/E_TowerNomerForm");
     			}
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_TowerIconButton = null;
			this.m_E_TowerIconImage = null;
			this.m_E_SelectedBigImage = null;
			this.m_E_TowerSelectFormImage = null;
			this.m_E_TowerNomerFormImage = null;
			this.uiTransform = null;
			this.DataId = 0;
		}

		private UnityEngine.UI.Button m_E_TowerIconButton = null;
		private UnityEngine.UI.Image m_E_TowerIconImage = null;
		private UnityEngine.UI.Image m_E_SelectedBigImage = null;
		private UnityEngine.UI.Image m_E_TowerSelectFormImage = null;
		private UnityEngine.UI.Image m_E_TowerNomerFormImage = null;
		public Transform uiTransform = null;
	}
}
