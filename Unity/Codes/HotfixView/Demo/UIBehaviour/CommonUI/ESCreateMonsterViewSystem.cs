
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace ET
{
    [ObjectSystem]
    public class ESCreateMonsterAwakeSystem : AwakeSystem<ESCreateMonster, Transform>
    {
        public override void Awake(ESCreateMonster self, Transform transform)
        {
            self.uiTransform = transform;
            self.InfoIsTrigger = false;
        }
    }

    [ObjectSystem]
    public class ESCreateMonsterUpdateSystem : UpdateSystem<ESCreateMonster>
    {
        public override void Update(ESCreateMonster self)
        {
            if(self.InfoIsTrigger)
            {
                self.InfoTimer = self.InfoTimer + Time.deltaTime;
            }
            else
            {
                self.InfoTimer = 0;
            }
            if(self.InfoTimer >= 1)
            {
                self.EMonsterInfoBaseSpriteImage.gameObject.SetActive(true);
            }
        }
    }


    [ObjectSystem]
    public class ESCreateMonsterDestroySystem : DestroySystem<ESCreateMonster>
    {
        public override void Destroy(ESCreateMonster self)
        {
            self.DestroyWidget();
        }
    }
    [FriendClass(typeof(ESCreateMonster))]
    public static class ESCreateMonsterViewSystem
    {
        public static void RegisterEvent(this ESCreateMonster self, int MonsterConfigId)
        {
            if(MonsterConfigId != 0)
            {
                self.MonsterConfigId = MonsterConfigId;
                self.InitMonsterInfo();
                self.ECreateMonsterButtonButton.AddListener(() =>
                {
                    self.SelectMonster();
                });
                self.RegisterMonsterInfo();
            }
        }
        public static void InitMonsterInfo(this ESCreateMonster self)
        {
            int MonsterConfigId = self.MonsterConfigId;
            MonsterConfig monsterconfig = MonsterConfigCategory.Instance.Get(MonsterConfigId);
            self.ECreateMonsterMoneyNumberTextText.SetText(monsterconfig.NeedMoney.ToString());
            FightItemConfig fightitemconfig = FightItemConfigCategory.Instance.Get(monsterconfig.MonsterConfigId);
            self.EMonsterNameTextText.SetText(fightitemconfig.FightItemName);
            self.EMonsterLvTextText.SetText("1");
            self.ECreateMonsterButtonImage.sprite = IconHelper.LoadIconSprite("monster", fightitemconfig.ResourceCode);
            self.ECreateMonsterButtonImage.SetNativeSize();
            self.ECreateMonsterButtonImage.gameObject.SetActive(true);
            self.EMonsterAttackTextText.SetText(monsterconfig.MonsterAttack.ToString());//攻击
            self.EMonsterHpTextText.SetText(monsterconfig.Hp.ToString());//血量
            string speed;
            if (monsterconfig.Speed <= 400) speed = "慢";
            else if (monsterconfig.Speed <= 800) speed = "中";
            else speed = "快";
            self.EMonsterAttackTextText.SetText(speed);//移速
            List<int> PetSkills = self.ZoneScene().GetComponent<FightItemComponent>().GetPetTalentIdByConfigId(MonsterConfigId);
            if(PetSkills.Count == 0)
            {
                self.EMonsterSkillBaseSprite1Image.gameObject.SetActive(false);
                self.EMonsterSkillBaseSprite2Image.gameObject.SetActive(false);
                self.EMonsterInfoBaseSpriteImage.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(308, 180);
            }
            if(PetSkills.Count == 1)
            {
                self.EMonsterSkillBaseSprite1Image.gameObject.SetActive(false);
                self.EMonsterSkillBaseSprite2Image.gameObject.SetActive(true);
                self.EMonsterInfoBaseSpriteImage.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(308, 330);
            }
            if(PetSkills.Count == 2)
            {
                self.EMonsterSkillBaseSprite1Image.gameObject.SetActive(true);
                self.EMonsterSkillBaseSprite2Image.gameObject.SetActive(true);
                self.EMonsterInfoBaseSpriteImage.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(308, 480);
            }
        }
        public static void RegisterMonsterInfo(this ESCreateMonster self)
        {
            EventTrigger.Entry entry1 = new EventTrigger.Entry();
            entry1.eventID = EventTriggerType.PointerEnter;
            entry1.callback.AddListener((data1) =>
            {
                self.ShowInfos();
            });
            self.ECreateMonsterButtonEventTrigger.triggers.Add(entry1);

            EventTrigger.Entry entry2 = new EventTrigger.Entry();
            entry2.eventID = EventTriggerType.PointerExit;
            entry2.callback.AddListener((data2) =>
            {
                self.CloseInfos();
            });
            self.ECreateMonsterButtonEventTrigger.triggers.Add(entry2);
        }
        public static void ShowInfos(this ESCreateMonster self)
        {
            self.InfoIsTrigger = true;
        }
        public static void CloseInfos(this ESCreateMonster self)
        {
            self.EMonsterInfoBaseSpriteImage.gameObject.SetActive(false);
            self.InfoIsTrigger = false;
        }
        public static void ShowWindow(this ESCreateMonster self, int MonsterConfigId)
        {
            self.uiTransform.gameObject.SetActive(true);
            self.EMonsterInfoBaseSpriteImage.transform.gameObject.SetActive(false);
            //self.ELabelMonsterNameText.SetText(Monster.ToString());
        }
        public static void HideWindow(this ESCreateMonster self)
        {
            self.uiTransform.gameObject.SetActive(false);

        }
        public static void SelectMonster(this ESCreateMonster self)
        {
            self.CloseInfos();
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetSelectMonster(self.MonsterConfigId);
            /*MonsterConfig monsterconfig = MonsterConfigCategory.Instance.Get(MonsterConfigId);
            int needmoney = monsterconfig.NeedMoney;
            int currentmoney = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.GameMoney);
            if (needmoney > currentmoney) return;
            try
            {
                int errorcode = await GameHelper.CreateMonster(self.ZoneScene(), MonsterConfigId);
                if (errorcode != ErrorCode.ERR_Success)
                {
                    Log.Error(errorcode.ToString());
                    return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }*/
        }
    }
}
