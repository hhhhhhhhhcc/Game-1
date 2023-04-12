
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

		public UnityEngine.UI.Button ELevel11Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel11Button == null )
     			{
		    		this.m_ELevel11Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel11");
     			}
     			return this.m_ELevel11Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel11Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel11Image == null )
     			{
		    		this.m_ELevel11Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel11");
     			}
     			return this.m_ELevel11Image;
     		}
     	}

		public UnityEngine.UI.Image E_Level1StarsImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level1StarsImage == null )
     			{
		    		this.m_E_Level1StarsImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel11/E_Level1Stars");
     			}
     			return this.m_E_Level1StarsImage;
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

		public UnityEngine.UI.Image E_Level2StarsImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level2StarsImage == null )
     			{
		    		this.m_E_Level2StarsImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel12/E_Level2Stars");
     			}
     			return this.m_E_Level2StarsImage;
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

		public UnityEngine.UI.Image E_Level3StarsImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Level3StarsImage == null )
     			{
		    		this.m_E_Level3StarsImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter1/ELevel13/E_Level3Stars");
     			}
     			return this.m_E_Level3StarsImage;
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

		public UnityEngine.UI.Button ELevel21Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel21Button == null )
     			{
		    		this.m_ELevel21Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel21");
     			}
     			return this.m_ELevel21Button;
     		}
     	}

		public UnityEngine.UI.Image ELevel21Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELevel21Image == null )
     			{
		    		this.m_ELevel21Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Chapters/E_Chapter2/ELevel21");
     			}
     			return this.m_ELevel21Image;
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
		    		this.m_E_MapIntImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ChapterIntroduct/E_MapInt");
     			}
     			return this.m_E_MapIntImage;
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
		    		this.m_E_Tower1ImageImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower1Image");
     			}
     			return this.m_E_Tower1ImageImage;
     		}
     	}

		public UnityEngine.UI.Image E_Tower1Image2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1Image2Image == null )
     			{
		    		this.m_E_Tower1Image2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower1Image2");
     			}
     			return this.m_E_Tower1Image2Image;
     		}
     	}

		public UnityEngine.UI.Image E_Tower1Image3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1Image3Image == null )
     			{
		    		this.m_E_Tower1Image3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower1Image3");
     			}
     			return this.m_E_Tower1Image3Image;
     		}
     	}

		public UnityEngine.UI.Image E_Tower1Image4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Tower1Image4Image == null )
     			{
		    		this.m_E_Tower1Image4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Formation/E_Tower1Image4");
     			}
     			return this.m_E_Tower1Image4Image;
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

		public void DestroyWidget()
		{
			this.m_E_ChaptersImage = null;
			this.m_E_Chapter1ToggleGroup = null;
			this.m_E_Chapter1Image = null;
			this.m_ELevel11Button = null;
			this.m_ELevel11Image = null;
			this.m_E_Level1StarsImage = null;
			this.m_ELevel12Button = null;
			this.m_ELevel12Image = null;
			this.m_E_Level2StarsImage = null;
			this.m_ELevel13Button = null;
			this.m_ELevel13Image = null;
			this.m_E_Level3StarsImage = null;
			this.m_E_Chapter2ToggleGroup = null;
			this.m_E_Chapter2Image = null;
			this.m_ELevel21Button = null;
			this.m_ELevel21Image = null;
			this.m_ELevel22Button = null;
			this.m_ELevel22Image = null;
			this.m_ELevel23Button = null;
			this.m_ELevel23Image = null;
			this.m_E_BackBaseButton = null;
			this.m_E_BackBaseImage = null;
			this.m_ECoinDisplayImage = null;
			this.m_EText_CoinNumberText = null;
			this.m_E_NextChapterButton = null;
			this.m_E_NextChapterImage = null;
			this.m_E_LastChapterButton = null;
			this.m_E_LastChapterImage = null;
			this.m_E_ChapterIntroductImage = null;
			this.m_E_IntroductCloseButton = null;
			this.m_E_IntroductCloseImage = null;
			this.m_E_MapIntImage = null;
			this.m_E_IntroductLeveText = null;
			this.m_E_LeveNameText = null;
			this.m_E_MosterIntroductText = null;
			this.m_E_EnemysLoopHorizontalScrollRect = null;
			this.m_E_Reward1Image = null;
			this.m_E_RweardNum1Text = null;
			this.m_E_Reward2Image = null;
			this.m_E_RweardNum2Text = null;
			this.m_E_Reward3Image = null;
			this.m_E_RweardNum3Text = null;
			this.m_E_FightButton = null;
			this.m_E_FightImage = null;
			this.m_E_ChapterSelectDropdown = null;
			this.m_E_ChapterSelectImage = null;
			this.m_E_Tower1ImageImage = null;
			this.m_E_Tower1Image2Image = null;
			this.m_E_Tower1Image3Image = null;
			this.m_E_Tower1Image4Image = null;
			this.m_E_AdjustButton = null;
			this.m_E_AdjustImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Image m_E_ChaptersImage = null;
		private UnityEngine.UI.ToggleGroup m_E_Chapter1ToggleGroup = null;
		private UnityEngine.UI.Image m_E_Chapter1Image = null;
		private UnityEngine.UI.Button m_ELevel11Button = null;
		private UnityEngine.UI.Image m_ELevel11Image = null;
		private UnityEngine.UI.Image m_E_Level1StarsImage = null;
		private UnityEngine.UI.Button m_ELevel12Button = null;
		private UnityEngine.UI.Image m_ELevel12Image = null;
		private UnityEngine.UI.Image m_E_Level2StarsImage = null;
		private UnityEngine.UI.Button m_ELevel13Button = null;
		private UnityEngine.UI.Image m_ELevel13Image = null;
		private UnityEngine.UI.Image m_E_Level3StarsImage = null;
		private UnityEngine.UI.ToggleGroup m_E_Chapter2ToggleGroup = null;
		private UnityEngine.UI.Image m_E_Chapter2Image = null;
		private UnityEngine.UI.Button m_ELevel21Button = null;
		private UnityEngine.UI.Image m_ELevel21Image = null;
		private UnityEngine.UI.Button m_ELevel22Button = null;
		private UnityEngine.UI.Image m_ELevel22Image = null;
		private UnityEngine.UI.Button m_ELevel23Button = null;
		private UnityEngine.UI.Image m_ELevel23Image = null;
		private UnityEngine.UI.Button m_E_BackBaseButton = null;
		private UnityEngine.UI.Image m_E_BackBaseImage = null;
		private UnityEngine.UI.Image m_ECoinDisplayImage = null;
		private UnityEngine.UI.Text m_EText_CoinNumberText = null;
		private UnityEngine.UI.Button m_E_NextChapterButton = null;
		private UnityEngine.UI.Image m_E_NextChapterImage = null;
		private UnityEngine.UI.Button m_E_LastChapterButton = null;
		private UnityEngine.UI.Image m_E_LastChapterImage = null;
		private UnityEngine.UI.Image m_E_ChapterIntroductImage = null;
		private UnityEngine.UI.Button m_E_IntroductCloseButton = null;
		private UnityEngine.UI.Image m_E_IntroductCloseImage = null;
		private UnityEngine.UI.Image m_E_MapIntImage = null;
		private UnityEngine.UI.Text m_E_IntroductLeveText = null;
		private UnityEngine.UI.Text m_E_LeveNameText = null;
		private UnityEngine.UI.Text m_E_MosterIntroductText = null;
		private UnityEngine.UI.LoopHorizontalScrollRect m_E_EnemysLoopHorizontalScrollRect = null;
		private UnityEngine.UI.Image m_E_Reward1Image = null;
		private UnityEngine.UI.Text m_E_RweardNum1Text = null;
		private UnityEngine.UI.Image m_E_Reward2Image = null;
		private UnityEngine.UI.Text m_E_RweardNum2Text = null;
		private UnityEngine.UI.Image m_E_Reward3Image = null;
		private UnityEngine.UI.Text m_E_RweardNum3Text = null;
		private UnityEngine.UI.Button m_E_FightButton = null;
		private UnityEngine.UI.Image m_E_FightImage = null;
		private UnityEngine.UI.Dropdown m_E_ChapterSelectDropdown = null;
		private UnityEngine.UI.Image m_E_ChapterSelectImage = null;
		private UnityEngine.UI.Image m_E_Tower1ImageImage = null;
		private UnityEngine.UI.Image m_E_Tower1Image2Image = null;
		private UnityEngine.UI.Image m_E_Tower1Image3Image = null;
		private UnityEngine.UI.Image m_E_Tower1Image4Image = null;
		private UnityEngine.UI.Button m_E_AdjustButton = null;
		private UnityEngine.UI.Image m_E_AdjustImage = null;
		public Transform uiTransform = null;
	}
}
