
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class ESNextWave : Entity,ET.IAwake<UnityEngine.Transform>,IUpdate,IDestroy 
	{
		public UnityEngine.UI.Button E_NextWaveIconButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveIconButton == null )
     			{
		    		this.m_E_NextWaveIconButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_NextWaveIcon");
     			}
     			return this.m_E_NextWaveIconButton;
     		}
     	}

		public UnityEngine.UI.Image E_NextWaveIconImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveIconImage == null )
     			{
		    		this.m_E_NextWaveIconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_NextWaveIcon");
     			}
     			return this.m_E_NextWaveIconImage;
     		}
     	}

		public UnityEngine.EventSystems.EventTrigger E_NextWaveIconEventTrigger
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveIconEventTrigger == null )
     			{
		    		this.m_E_NextWaveIconEventTrigger = UIFindHelper.FindDeepChild<UnityEngine.EventSystems.EventTrigger>(this.uiTransform.gameObject,"E_NextWaveIcon");
     			}
     			return this.m_E_NextWaveIconEventTrigger;
     		}
     	}

		public UnityEngine.UI.Image E_NextWaveArrowImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveArrowImage == null )
     			{
		    		this.m_E_NextWaveArrowImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_NextWaveArrow");
     			}
     			return this.m_E_NextWaveArrowImage;
     		}
     	}

		public UnityEngine.UI.Image E_NextWaveInfoBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveInfoBaseImage == null )
     			{
		    		this.m_E_NextWaveInfoBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_NextWaveInfoBase");
     			}
     			return this.m_E_NextWaveInfoBaseImage;
     		}
     	}

		public UnityEngine.UI.Image E_NextWaveInfoTitleBaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveInfoTitleBaseImage == null )
     			{
		    		this.m_E_NextWaveInfoTitleBaseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_NextWaveInfoBase/E_NextWaveInfoTitleBase");
     			}
     			return this.m_E_NextWaveInfoTitleBaseImage;
     		}
     	}

		public UnityEngine.UI.Text E_NextWaveInfoTitleText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveInfoTitleText == null )
     			{
		    		this.m_E_NextWaveInfoTitleText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_NextWaveInfoBase/E_NextWaveInfoTitleBase/E_NextWaveInfoTitle");
     			}
     			return this.m_E_NextWaveInfoTitleText;
     		}
     	}

		public UnityEngine.UI.Text E_NextWaveInfoDescriptionText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveInfoDescriptionText == null )
     			{
		    		this.m_E_NextWaveInfoDescriptionText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_NextWaveInfoBase/E_NextWaveInfoDescription");
     			}
     			return this.m_E_NextWaveInfoDescriptionText;
     		}
     	}

		public UnityEngine.UI.Text E_NextWaveInfoWarmText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextWaveInfoWarmText == null )
     			{
		    		this.m_E_NextWaveInfoWarmText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_NextWaveInfoBase/E_NextWaveInfoWarm");
     			}
     			return this.m_E_NextWaveInfoWarmText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_NextWaveIconButton = null;
			this.m_E_NextWaveIconImage = null;
			this.m_E_NextWaveIconEventTrigger = null;
			this.m_E_NextWaveArrowImage = null;
			this.m_E_NextWaveInfoBaseImage = null;
			this.m_E_NextWaveInfoTitleBaseImage = null;
			this.m_E_NextWaveInfoTitleText = null;
			this.m_E_NextWaveInfoDescriptionText = null;
			this.m_E_NextWaveInfoWarmText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_NextWaveIconButton = null;
		private UnityEngine.UI.Image m_E_NextWaveIconImage = null;
		private UnityEngine.EventSystems.EventTrigger m_E_NextWaveIconEventTrigger = null;
		private UnityEngine.UI.Image m_E_NextWaveArrowImage = null;
		private UnityEngine.UI.Image m_E_NextWaveInfoBaseImage = null;
		private UnityEngine.UI.Image m_E_NextWaveInfoTitleBaseImage = null;
		private UnityEngine.UI.Text m_E_NextWaveInfoTitleText = null;
		private UnityEngine.UI.Text m_E_NextWaveInfoDescriptionText = null;
		private UnityEngine.UI.Text m_E_NextWaveInfoWarmText = null;
		public Transform uiTransform = null;
        public Dictionary<int,int> currenwaveinfo = new Dictionary<int,int>();
        public float WaveInfoTimer;
        public bool waveInfoTrigger;
	}
}
