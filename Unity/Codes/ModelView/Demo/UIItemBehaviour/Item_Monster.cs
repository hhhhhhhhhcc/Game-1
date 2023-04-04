
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class Scroll_Item_Monster : Entity,IAwake,IDestroy,IUIScrollItem 
	{
		public long DataId {get;set;}
		private bool isCacheNode = false;
		public void SetCacheMode(bool isCache)
		{
			this.isCacheNode = isCache;
		}

		public Scroll_Item_Monster BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public UnityEngine.UI.Button E_MonsterBaseButton
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
     				if( this.m_E_MonsterBaseButton == null )
     				{
		    			this.m_E_MonsterBaseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_MonsterBase");
     				}
     				return this.m_E_MonsterBaseButton;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_MonsterBase");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_MonsterBaseImage
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
     				if( this.m_E_MonsterBaseImage == null )
     				{
		    			this.m_E_MonsterBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_MonsterBase");
     				}
     				return this.m_E_MonsterBaseImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_MonsterBase");
     			}
     		}
     	}

		public UnityEngine.UI.Button E_MonsterIconButton
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
     				if( this.m_E_MonsterIconButton == null )
     				{
		    			this.m_E_MonsterIconButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_MonsterIcon");
     				}
     				return this.m_E_MonsterIconButton;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_MonsterIcon");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_MonsterIconImage
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
     				if( this.m_E_MonsterIconImage == null )
     				{
		    			this.m_E_MonsterIconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_MonsterIcon");
     				}
     				return this.m_E_MonsterIconImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_MonsterIcon");
     			}
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_MonsterBaseButton = null;
			this.m_E_MonsterBaseImage = null;
			this.m_E_MonsterIconButton = null;
			this.m_E_MonsterIconImage = null;
			this.uiTransform = null;
			this.DataId = 0;
		}

		private UnityEngine.UI.Button m_E_MonsterBaseButton = null;
		private UnityEngine.UI.Image m_E_MonsterBaseImage = null;
		private UnityEngine.UI.Button m_E_MonsterIconButton = null;
		private UnityEngine.UI.Image m_E_MonsterIconImage = null;
		public Transform uiTransform = null;
	}
}
