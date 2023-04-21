
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class ES_SkillAwakeSystem : AwakeSystem<ES_Skill,Transform> 
	{
		public override void Awake(ES_Skill self,Transform transform)
		{
			self.uiTransform = transform;
		}
	}


	[ObjectSystem]
	public class ES_SkillDestroySystem : DestroySystem<ES_Skill> 
	{
		public override void Destroy(ES_Skill self)
		{
			self.DestroyWidget();
		}
	}
	[FriendClass(typeof(ES_Skill))]
	[ObjectSystem]
	public static class ES_SkillSystem
	{
		public static void HideWindow(this ES_Skill self)
		{
			self.uiTransform.gameObject.SetActive(false);
		}
		public static void RegisterEvent(this ES_Skill self,int PlayerSKillId)
		{
			//注册信息
			if(PlayerSKillId != 0)
			{
                self.PlayerSkillId = PlayerSKillId;
                PlayerSkillConfig playerskillconfig = PlayerSkillConfigCategory.Instance.Get(PlayerSKillId);
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(playerskillconfig.SkillConfigId);
                Dictionary<string, int> param = SkillHelper.GetSkillString(SkillConfigCategory.Instance.Get(skillConfig.Id).Params);
                self.ChargeTime = param["chargetime"];
                //注册单击脚本
                self.E_SKillButton.onClick.AddListener(() => { self.SelectPlayerSkill(); });
                //刷新玩家技能显示信息UI
                self.InitPlayerSkillInfo();
            }
        }
        public static void SelectPlayerSkill(this ES_Skill self)
        {
            self.ClosePlayerSkillInfo();
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetSelectPlayerSkill(self.PlayerSkillId);
        }
        public static void InitPlayerSkillInfo(this ES_Skill self)
		{

		}
		public static void ClosePlayerSkillInfo(this ES_Skill self)
		{

		}
	}
}
