﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgLoadingViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Text E_LoadingTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LoadingTextText == null )
     			{
		    		this.m_E_LoadingTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_LoadingText");
     			}
     			return this.m_E_LoadingTextText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_LoadingTextText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Text m_E_LoadingTextText = null;
		public Transform uiTransform = null;
	}
}
