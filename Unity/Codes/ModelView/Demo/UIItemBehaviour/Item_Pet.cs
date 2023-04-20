
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class Scroll_Item_Pet : Entity,IAwake,IDestroy,IUIScrollItem 
	{
		public long DataId {get;set;}
		private bool isCacheNode = false;
		public void SetCacheMode(bool isCache)
		{
			this.isCacheNode = isCache;
		}

		public Scroll_Item_Pet BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public UnityEngine.UI.Button E_PetIconButton
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
     				if( this.m_E_PetIconButton == null )
     				{
		    			this.m_E_PetIconButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_PetIcon");
     				}
     				return this.m_E_PetIconButton;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_PetIcon");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_PetIconImage
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
     				if( this.m_E_PetIconImage == null )
     				{
		    			this.m_E_PetIconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon");
     				}
     				return this.m_E_PetIconImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_PetSelectFormImage
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
     				if( this.m_E_PetSelectFormImage == null )
     				{
		    			this.m_E_PetSelectFormImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon/E_PetSelectForm");
     				}
     				return this.m_E_PetSelectFormImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon/E_PetSelectForm");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_SelectBigImage
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
     				if( this.m_E_SelectBigImage == null )
     				{
		    			this.m_E_SelectBigImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon/E_SelectBig");
     				}
     				return this.m_E_SelectBigImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon/E_SelectBig");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_PetNormeFormImage
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
     				if( this.m_E_PetNormeFormImage == null )
     				{
		    			this.m_E_PetNormeFormImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon/E_PetNormeForm");
     				}
     				return this.m_E_PetNormeFormImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_PetIcon/E_PetNormeForm");
     			}
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_PetIconButton = null;
			this.m_E_PetIconImage = null;
			this.m_E_PetSelectFormImage = null;
			this.m_E_SelectBigImage = null;
			this.m_E_PetNormeFormImage = null;
			this.uiTransform = null;
			this.DataId = 0;
		}

		private UnityEngine.UI.Button m_E_PetIconButton = null;
		private UnityEngine.UI.Image m_E_PetIconImage = null;
		private UnityEngine.UI.Image m_E_PetSelectFormImage = null;
		private UnityEngine.UI.Image m_E_SelectBigImage = null;
		private UnityEngine.UI.Image m_E_PetNormeFormImage = null;
		public Transform uiTransform = null;
	}
}
