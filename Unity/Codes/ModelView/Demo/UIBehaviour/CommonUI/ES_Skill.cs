﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class ES_Skill : Entity,ET.IAwake<UnityEngine.Transform>,IDestroy 
	{
		public UnityEngine.UI.Image E_SkillBaseSpriteImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SkillBaseSpriteImage == null )
     			{
		    		this.m_E_SkillBaseSpriteImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_SkillBaseSprite");
     			}
     			return this.m_E_SkillBaseSpriteImage;
     		}
     	}

		public UnityEngine.UI.Image E_SkillInputBaseSpriteImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SkillInputBaseSpriteImage == null )
     			{
		    		this.m_E_SkillInputBaseSpriteImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_SkillInputBaseSprite");
     			}
     			return this.m_E_SkillInputBaseSpriteImage;
     		}
     	}

		public UnityEngine.UI.Text E_SkillInputTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SkillInputTextText == null )
     			{
		    		this.m_E_SkillInputTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_SkillInputBaseSprite/E_SkillInputText");
     			}
     			return this.m_E_SkillInputTextText;
     		}
     	}

		public UnityEngine.UI.Image E_SkillNumberBaseSpriteImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SkillNumberBaseSpriteImage == null )
     			{
		    		this.m_E_SkillNumberBaseSpriteImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_SkillNumberBaseSprite");
     			}
     			return this.m_E_SkillNumberBaseSpriteImage;
     		}
     	}

		public UnityEngine.UI.Text E_SkillNumberTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SkillNumberTextText == null )
     			{
		    		this.m_E_SkillNumberTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_SkillNumberBaseSprite/E_SkillNumberText");
     			}
     			return this.m_E_SkillNumberTextText;
     		}
     	}

		public UnityEngine.UI.Button E_SKillButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SKillButton == null )
     			{
		    		this.m_E_SKillButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_SKill");
     			}
     			return this.m_E_SKillButton;
     		}
     	}

		public UnityEngine.UI.Image E_SKillImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SKillImage == null )
     			{
		    		this.m_E_SKillImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_SKill");
     			}
     			return this.m_E_SKillImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_SkillBaseSpriteImage = null;
			this.m_E_SkillInputBaseSpriteImage = null;
			this.m_E_SkillInputTextText = null;
			this.m_E_SkillNumberBaseSpriteImage = null;
			this.m_E_SkillNumberTextText = null;
			this.m_E_SKillButton = null;
			this.m_E_SKillImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Image m_E_SkillBaseSpriteImage = null;
		private UnityEngine.UI.Image m_E_SkillInputBaseSpriteImage = null;
		private UnityEngine.UI.Text m_E_SkillInputTextText = null;
		private UnityEngine.UI.Image m_E_SkillNumberBaseSpriteImage = null;
		private UnityEngine.UI.Text m_E_SkillNumberTextText = null;
		private UnityEngine.UI.Button m_E_SKillButton = null;
		private UnityEngine.UI.Image m_E_SKillImage = null;
		public Transform uiTransform = null;
        public int PlayerSkillId;
        public int ChargeTime;
    }
}
