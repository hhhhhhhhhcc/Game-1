using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.ComponentModel;
using static UnityEngine.UI.CanvasScaler;

namespace ET
{
    [FriendClass(typeof(FightItemComponent))]
    [FriendClass(typeof(FightItem))]
	[FriendClass(typeof(DlgTalentUI))]
	public static  class DlgTalentUISystem
	{

		public static void RegisterUIEvent(this DlgTalentUI self)
		{
            self.View.E_TowersLoopVerticalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrollTowerItemRefreshHandler(transform, index); });//塔滑动列表项
            self.View.E_MonstersLoopVerticalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrollMonsterItemRefreshHandler(transform, index); });//怪滑动列表项
            self.View.E_LabelTowerButton.AddListener(() => { self.ChooseTowerTab(); });//选中塔标签
            self.View.E_LabelMonsterButton.AddListener(() => { self.ChooseMonsterTab(); });//选中怪标签
            self.View.E_TowerInfoButton.AddListener(() => { self.ChooseTowerInfo(); });//选中塔信息标签
            self.View.E_TowerTalentButton.AddListener(() => { self.ChooseTowerTalent(); });//选中塔天赋标签
            self.View.E_BackBaseButton.AddListener(() => { self.CloseWindow(); });//返回标签
            self.View.E_TowerLeftPageBtButton.AddListener(() => { self.TowerPageReduce(); });//塔往左翻
            self.View.E_TowerRightPageBtButton.AddListener(() => { self.TowerPageAdd(); });//塔往右翻
            self.View.E_MonsterLeftPageBtButton.AddListener(() => { self.MonsterPageReduce(); });//怪往左翻
            self.View.E_MonsterRightPageBtButton.AddListener(() => { self.MonsterPageAdd(); });//怪往右翻
            self.View.E_TowerTalentUpgradeBaseButton.AddListener(() => { self.UpgradeFightItem(); });//升级塔解锁天赋
            self.View.E_TowerTalentLevel1LeftButton.AddListener(() => { self.AddFightItemTalent(1); });//天赋点位置1
            self.View.E_TowerTalentLevel1RightButton.AddListener(() => { self.AddFightItemTalent(2); });//天赋点位置2
            self.View.E_TowerTalentLevel2LeftButton.AddListener(() => { self.AddFightItemTalent(3); });//天赋点位置3
            self.View.E_TowerTalentLevel2RightButton.AddListener(() => { self.AddFightItemTalent(4); });//天赋点位置4
            self.View.E_TowerTalentLevel3LeftButton.AddListener(() => { self.AddFightItemTalent(5); });//天赋点位置5
            self.View.E_TowerTalentLevel3RightButton.AddListener(() => { self.AddFightItemTalent(6); });//天赋点位置6
            self.View.E_TowerTalentResetBaseButton.AddListener(() => { self.ResetFightItemTalent(); });
        }
        public static void CloseWindow(this DlgTalentUI self)
        {
            self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_TalentUI);
        }

		public static void ShowWindow(this DlgTalentUI self, Entity contextData = null)
        {
            self.type = FightItemType.Tower;
			self.TalentTowerState = TalentTowerState.Info;
            self.CurrentTowerPage = 1;
            self.CurrentMonsterPage = 1;
            self.TowerConfigLevel = 1;
            self.towerfightitem = FightItemHelper.GetFightItemsByType(self.ZoneScene(), FightItemType.Tower);
            self.monsterfightitem = FightItemHelper.GetFightItemsByType(self.ZoneScene(), FightItemType.Monster);
            //塔
            self.currentId = self.towerfightitem[0].Id;
            self.RefreshTowerLoop();
            //怪
            self.RefreshMonsterLoop();
            //end
            self.RefreshByTab();
        }
        public static void ResetFightItemTalent(this DlgTalentUI self)
        {
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2G_OpFightItem() { FightItemUid = self.currentId, OpType = (int)FightItemOp.ResetTalent }); //添加天赋点
        }
        public static void AddFightItemTalent(this DlgTalentUI self,int Pos)
        {
            FightItem fightitem = self.ZoneScene().GetComponent<FightItemComponent>().FightItemDict[self.currentId];
            int TalentLevel = (Pos - 1) / 2 + 1;//层级
            int Sn = (Pos - 1) % 2 + 1;//左右
            int talentId = TalentConfigCategory.Instance.GetTalentId(fightitem.Config.TalentCode, TalentLevel, Sn);
            if(TalentLevel == 1 )//第一层的天赋点
            {
                bool IsNotAddThisLevel = false;//用来判断是否已经点了这个层
                for (int i = 0; i < fightitem.AddedTalent.Count; i++)
                {
                    int temp = fightitem.AddedTalent[i];
                    temp = (temp - 1) % 6 + 1;
                    if (temp == 1 || temp == 2) IsNotAddThisLevel = true;
                }
                if (!IsNotAddThisLevel)//未添加这个层
                {
                    if ((fightitem.AddedTalent.Count + fightitem.Upgrading) >= 1)//总数大于等于3
                    {
                        self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2G_OpFightItem() { FightItemUid = self.currentId, OpType = (int)FightItemOp.AddTalent, TalentConfigId = talentId }); //添加天赋点
                    }
                }
            }
            if (TalentLevel == 2)//第一层的天赋点
            {
                bool IsNotAddThisLevel = false;//用来判断是否已经点了这个层
                for (int i = 0; i < fightitem.AddedTalent.Count; i++)
                {
                    int temp = fightitem.AddedTalent[i];
                    temp = (temp - 1) % 6 + 1;
                    if (temp == 3 || temp == 4) IsNotAddThisLevel = true;
                }
                if (!IsNotAddThisLevel)//未添加这个层
                {
                    if ((fightitem.AddedTalent.Count + fightitem.Upgrading) >= 2)//总数大于等于3
                    {
                        self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2G_OpFightItem() { FightItemUid = self.currentId, OpType = (int)FightItemOp.AddTalent, TalentConfigId = talentId }); //添加天赋点//添加天赋点
                    }
                }            
            }
            if (TalentLevel == 3)//第一层的天赋点
            {
                bool IsNotAddThisLevel = false;//用来判断是否已经点了这个层
                for(int i=0;i<fightitem.AddedTalent.Count;i++)
                {
                    int temp = fightitem.AddedTalent[i];
                    temp = (temp - 1) % 6 + 1;
                    if (temp == 5 || temp == 6) IsNotAddThisLevel = true;
                }
                if(!IsNotAddThisLevel)//未添加这个层
                {
                    if ((fightitem.AddedTalent.Count + fightitem.Upgrading) >= 3)//总数大于等于3
                    {
                        self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2G_OpFightItem() { FightItemUid = self.currentId, OpType = (int)FightItemOp.AddTalent, TalentConfigId = talentId }); //添加天赋点  //添加天赋点
                    }
                }   
            }
        }
        public static void UpgradeFightItem(this DlgTalentUI self)
        {
            FightItem fightitem = self.ZoneScene().GetComponent<FightItemComponent>().FightItemDict[self.currentId];
    		 Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
            NumericComponent component = unit.GetComponent<NumericComponent>();
            int talentlevel = fightitem.AddedTalent.Count;
            if ((fightitem.Upgrading + talentlevel) < 3 && (fightitem.Upgrading + talentlevel) >= 0)//可升级
            {
                int needmoney = TalentCostConfigCategory.Instance.GetCostByCodeAndLevel(fightitem.Config.TalentCode, fightitem.Upgrading + talentlevel + 1);
                int currentmoney = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.Gold);
                if (currentmoney >= needmoney)
                {
                    self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2G_OpFightItem() { FightItemUid = self.currentId, OpType = (int)FightItemOp.Upgrade });
                }
                else//提示金币不足
                {
                    return;
                }
            }
        }
        public static void RefreshTowerLoop(this DlgTalentUI self)
        {
            int count = self.towerfightitem.Count - (self.CurrentTowerPage - 1) * 4;
            if (count > 4) count = 4;
            self.AddUIScrollItems(ref self.TowerItems, count);
            self.View.E_TowersLoopVerticalScrollRect.SetVisible(true, count);
        }
        public static void RefreshMonsterLoop(this DlgTalentUI self)
        {
            int count = self.monsterfightitem.Count - (self.CurrentMonsterPage - 1) * 16;
            if (count > 16) count = 16;
            self.AddUIScrollItems(ref self.MonsterItems, count);
            self.View.E_MonstersLoopVerticalScrollRect.SetVisible(true, count);
        }
        //塔图鉴页数增多
        public static void TowerPageAdd(this DlgTalentUI self)
        {
            int alltowernumber = self.towerfightitem.Count;
            int maxPage = (alltowernumber - 1) / 4 + 1;
            if(self.CurrentTowerPage < maxPage)
            {
                self.CurrentTowerPage++;
                self.currentId = self.towerfightitem[(self.CurrentTowerPage - 1) * 4].Id;
                self.RefreshTowerLoop();
                self.RefreshByTab();
            }
        }
        //塔图鉴页数减少
        public static void TowerPageReduce(this DlgTalentUI self)
        {
            if (self.CurrentTowerPage > 1)
            {
                self.CurrentTowerPage--;
                self.currentId = self.towerfightitem[(self.CurrentTowerPage - 1) * 4].Id;
                self.RefreshTowerLoop();
                self.RefreshByTab();
            }
        }
        //怪物图鉴页数增多
        public static void MonsterPageAdd(this DlgTalentUI self)
        {
            int allmonsternumber = self.monsterfightitem.Count;
            int maxPage = (allmonsternumber - 1) / 16 + 1;
            if (self.CurrentMonsterPage < maxPage)
            {
                self.CurrentMonsterPage++;
                self.currentId = self.monsterfightitem[(self.CurrentMonsterPage - 1) * 16].Id;
                self.RefreshMonsterLoop();
                self.RefreshByTab();
            }
        }
        //怪物图鉴页数减少
        public static void MonsterPageReduce(this DlgTalentUI self)
        {
            int allmonsternumber = self.monsterfightitem.Count;
            if (self.CurrentMonsterPage > 1)
            {
                self.CurrentMonsterPage--;
                self.currentId = self.monsterfightitem[(self.CurrentMonsterPage - 1) * 16].Id;
                self.RefreshMonsterLoop();
                self.RefreshByTab();
            }
        }
        //选择塔的信息界面
        public static void ChooseTowerInfo(this DlgTalentUI self)
        {
            self.TalentTowerState = TalentTowerState.Info;
            self.RefreshByTab();
        }
        //选择塔的天赋界面
        public static void ChooseTowerTalent(this DlgTalentUI self)
        {
            self.TalentTowerState = TalentTowerState.Talent;
            self.RefreshByTab();
        }
        //选择塔标签
        public static void ChooseTowerTab(this DlgTalentUI self)
        {
            self.CurrentTowerPage = 1;
            self.currentId = self.towerfightitem[0].Id;
            self.type = FightItemType.Tower;
            self.TalentTowerState = TalentTowerState.Info;
            self.RefreshTowerLoop();
            self.RefreshByTab();
        }
        //选择怪物标签
        public static void ChooseMonsterTab(this DlgTalentUI self)
        {
            self.CurrentMonsterPage = 1;
            self.currentId = self.monsterfightitem[0].Id;
            self.type = FightItemType.Monster;
            self.RefreshMonsterLoop();
            self.RefreshByTab();
        }
        public static void OnScrollTowerItemRefreshHandler(this DlgTalentUI self, Transform transform, int index)
        {
            Scroll_Item_Tower toweritem = self.TowerItems[index].BindTrans(transform);
            toweritem.E_TowerBookLevel1BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerNormal");
            toweritem.E_TowerBookLevel2BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerNormal");
            toweritem.E_TowerBookLevel3BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerNormal");
            FightItem fightitem = self.towerfightitem[index + (self.CurrentTowerPage - 1) * 4];
            if(fightitem.Id == self.currentId)//表示选中
            {
                if(self.TowerConfigLevel == 1)
                {
                    toweritem.E_TowerBookLevel1BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerChoose");
                }
                if (self.TowerConfigLevel == 2)
                {
                    toweritem.E_TowerBookLevel2BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerChoose");
                }
                if (self.TowerConfigLevel == 3)
                {
                    toweritem.E_TowerBookLevel3BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerChoose");
                }
                toweritem.E_TowerHandBookImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "BookBright");//选中亮颜色
            }
            else//未选中
            {
                toweritem.E_TowerHandBookImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "BookDark");

            }
            toweritem.E_TowerBookLevel1Button.AddListener(() => { self.SelectTowerConfigLevel(fightitem.Id,1); });
            toweritem.E_TowerBookLevel2Button.AddListener(() => { self.SelectTowerConfigLevel(fightitem.Id,2); });
            toweritem.E_TowerBookLevel3Button.AddListener(() => { self.SelectTowerConfigLevel(fightitem.Id,3); });
        }
        public static void OnScrollMonsterItemRefreshHandler(this DlgTalentUI self,Transform transform,int index)
        {
            Scroll_Item_Monster monsteritem = self.MonsterItems[index].BindTrans(transform);
            FightItem fightitem = self.monsterfightitem[index + (self.CurrentMonsterPage - 1) * 16];
            if (fightitem.Id == self.currentId)//表示选中
            {
                monsteritem.E_MonsterBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterChoose");//选中亮颜色
            }
            else//未选中
            {
                monsteritem.E_MonsterBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterNormal");
            }
            monsteritem.E_MonsterIconButton.AddListener(() => { self.SelectMonster(fightitem.Id); });
        }
        public static void SelectTowerConfigLevel(this DlgTalentUI self,long id,int ConfigLevel)
        {
            self.TowerConfigLevel = ConfigLevel;
            self.currentId = id;
            self.View.E_TowersLoopVerticalScrollRect.RefreshCells();
            self.RefreshByTab();
        }
        public static void SelectMonster(this DlgTalentUI self,long id)
        {
            self.currentId = id;
            self.View.E_MonstersLoopVerticalScrollRect.RefreshCells();
            self.RefreshByTab();
        }
        public static void HideWindow(this DlgTalentUI self)
        {
            self.RemoveUIScrollItems(ref self.TowerItems);
            self.RemoveUIScrollItems(ref self.MonsterItems);
        }

        public static void RefreshByTab(this DlgTalentUI self)
        {
            self.View.E_TowerIndexPageNumberText.SetText(self.CurrentTowerPage.ToString() + " / " + ((self.towerfightitem.Count - 1) / 4 + 1).ToString());//页数
            self.View.E_MonsterIndexPageNumberText.SetText(self.CurrentMonsterPage.ToString() + " / " + ((self.monsterfightitem.Count - 1) / 16 + 1).ToString());//页数
            if (self.type == FightItemType.Tower)
            {
                //更换索引标签
                self.View.E_LabelTowerImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelBright");
                self.View.E_TowerStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerBright");
                self.View.E_TowerStateImage.transform.localPosition = new Vector3(10, 0, 0);

                self.View.E_LabelMonsterImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_MonsterStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterDark");
                self.View.E_MonsterStateImage.transform.localPosition = new Vector3(20, 0, 0);

                self.View.E_LabelPetImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_PetStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "PetDark");
                self.View.E_PetStateImage.transform.localPosition = new Vector3(20, 0, 0);
                //end
                //主显示部分
                self.View.E_TowerPartImage.gameObject.SetActive(true);
                self.View.E_MonsterPartImage.gameObject.SetActive(false);
                //end
            }
            if (self.type == FightItemType.Monster)
            {
                //更换索引标签
                self.View.E_LabelTowerImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_TowerStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerDark");
                self.View.E_TowerStateImage.transform.localPosition = new Vector3(20, 0, 0);

                self.View.E_LabelMonsterImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelBright");
                self.View.E_MonsterStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterBright");
                self.View.E_MonsterStateImage.transform.localPosition = new Vector3(10, 0, 0);

                self.View.E_LabelPetImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_PetStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "PetDark");
                self.View.E_PetStateImage.transform.localPosition = new Vector3(20, 0, 0);
                //end
                //主显示部分
                self.View.E_TowerPartImage.gameObject.SetActive(false);
                self.View.E_MonsterPartImage.gameObject.SetActive(true);
                //end
            }
            if (self.type == FightItemType.Pet)
            {
                //更换索引标签
                self.View.E_LabelTowerImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_TowerStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerDark");
                self.View.E_TowerStateImage.transform.localPosition = new Vector3(20, 0, 0);

                self.View.E_LabelMonsterImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_MonsterStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterDark");
                self.View.E_MonsterStateImage.transform.localPosition = new Vector3(20, 0, 0);

                self.View.E_LabelPetImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelBright");
                self.View.E_PetStateImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "PetBright");
                self.View.E_PetStateImage.transform.localPosition = new Vector3(10, 0, 0);
                //end
                //主显示部分
                self.View.E_TowerPartImage.gameObject.SetActive(false);
                self.View.E_MonsterPartImage.gameObject.SetActive(false);
                //end
            }
            //更换塔右边部分
            if (self.TalentTowerState == TalentTowerState.Info)
            {
                self.View.E_TowerInfoBaseImage.gameObject.SetActive(true);
                self.View.E_TowerTalentBaseImage.gameObject.SetActive(false);
                self.View.E_TowerInfoTalentTitleImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ChooseInfo");
                self.View.E_TowerInfoImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "InfoBright");
                self.View.E_TowerInfoImage.transform.localPosition = new Vector3(-80, -4, 0);
                self.View.E_TowerTalentImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentDark");
                self.View.E_TowerTalentImage.transform.localPosition = new Vector3(80, 4, 0);
            }
            if (self.TalentTowerState == TalentTowerState.Talent)
            {
                self.View.E_TowerInfoBaseImage.gameObject.SetActive(false);
                self.View.E_TowerTalentBaseImage.gameObject.SetActive(true);
                self.View.E_TowerInfoTalentTitleImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ChooseTalent");
                self.View.E_TowerInfoImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "InfoDark");
                self.View.E_TowerInfoImage.transform.localPosition = new Vector3(-80, 4, 0);
                self.View.E_TowerTalentImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBright");
                self.View.E_TowerTalentImage.transform.localPosition = new Vector3(80, -4, 0);
            }
            //end

            //塔的信息展示
            if (self.type == FightItemType.Tower)
            {
                FightItem FightItem = self.ZoneScene().GetComponent<FightItemComponent>().FightItemDict[self.currentId];
                int fightItemId = FightItem.Config.Id;
                int configId = fightItemId - 1 + self.TowerConfigLevel;
                TowerConfig towerconfig = TowerConfigCategory.Instance.Get(configId);
                self.View.E_TowerInfoDescriptionText.text = towerconfig.Introduction;

                string attack, attackInterval, range;
                if (towerconfig.Attack[0] + towerconfig.Attack[1] < 10) attack = "低";
                else if (towerconfig.Attack[0] + towerconfig.Attack[1] < 20) attack = "中";
                else attack = "高";

                if (towerconfig.AttackInterval < 1000) attackInterval = "低";
                else if (towerconfig.AttackInterval < 2000) attackInterval = "中";
                else attackInterval = "高";

                if (towerconfig.Range < 2300) range = "低";
                else if (towerconfig.Attack[0] + towerconfig.Attack[1] < 2500) range = "中";
                else range = "高";

                self.View.E_TowerProperties1NumberText.text = attack;
                self.View.E_TowerProperties2NumberText.text = attackInterval;
                self.View.E_TowerProperties3NumberText.text = range;
                self.View.E_TowerProperties4NumberText.text = towerconfig.Price.ToString();
            }

            //怪的信息展示
            if (self.type == FightItemType.Monster)
            {
                FightItem FightItem = self.ZoneScene().GetComponent<FightItemComponent>().FightItemDict[self.currentId];
                int fightItemId = FightItem.Config.Id;
                FightItemConfig fightitemconfig = FightItemConfigCategory.Instance.Get(fightItemId);
                self.View.E_MonsterDescriptionText.text = fightitemconfig.Introduction;
                self.View.E_MonsterProperties1NumberText.text = fightitemconfig.Hp;
                self.View.E_MonsterProperties2NumberText.text = fightitemconfig.speed;
                self.View.E_MonsterProperties3NumberText.text = fightitemconfig.damage;
                self.View.E_MonsterProperties4NumberText.text = fightitemconfig.defence;
            }

            //初始化天赋面板
            self.View.E_TowerTalent1BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseDark");//灰色背景
            self.View.E_TowerTalent2BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseDark");//灰色背景
            self.View.E_TowerTalent3BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseDark");//灰色背景
            self.View.E_TowerTalentLevel1LeftArrowImage.gameObject.SetActive(false);//关闭箭头
            self.View.E_TowerTalentLevel1RightArrowImage.gameObject.SetActive(false);
            self.View.E_TowerTalentLevel2LeftArrowImage.gameObject.SetActive(false);
            self.View.E_TowerTalentLevel2RightArrowImage.gameObject.SetActive(false);
            self.View.E_TowerTalentLevel3LeftArrowImage.gameObject.SetActive(false);
            self.View.E_TowerTalentLevel3RightArrowImage.gameObject.SetActive(false);
            self.View.E_TowerTalentLevel1LockImage.gameObject.SetActive(true);//打开锁
            self.View.E_TowerTalentLevel2LockImage.gameObject.SetActive(true);
            self.View.E_TowerTalentLevel3LockImage.gameObject.SetActive(true);
            FightItem CurrentFightItem = self.ZoneScene().GetComponent<FightItemComponent>().FightItemDict[self.currentId];
            int TalentLevel = CurrentFightItem.AddedTalent.Count;
            if ((TalentLevel + CurrentFightItem.Upgrading) >= 1)//1级
            {
                self.View.E_TowerTalent1BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseBright");//亮色背景
                self.View.E_TowerTalentLevel1LeftArrowImage.gameObject.SetActive(true);//打开箭头
                self.View.E_TowerTalentLevel1RightArrowImage.gameObject.SetActive(true);
                self.View.E_TowerTalentLevel1LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowChoose");
                self.View.E_TowerTalentLevel1RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowChoose");
                self.View.E_TowerTalentLevel1LockImage.gameObject.SetActive(false);//关闭锁
            }
            if ((TalentLevel + CurrentFightItem.Upgrading) >= 2)//2级
            {
                self.View.E_TowerTalent2BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseBright");//亮色背景
                self.View.E_TowerTalentLevel2LeftArrowImage.gameObject.SetActive(true);//打开箭头
                self.View.E_TowerTalentLevel2RightArrowImage.gameObject.SetActive(true);
                self.View.E_TowerTalentLevel2LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowChoose");
                self.View.E_TowerTalentLevel2RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowChoose");
                self.View.E_TowerTalentLevel2LockImage.gameObject.SetActive(false);//关闭锁
            }
            if ((TalentLevel + CurrentFightItem.Upgrading) == 3)//3级满级
            {
                self.View.E_TowerTalent3BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseBright");//亮色背景
                self.View.E_TowerTalentLevel3LeftArrowImage.gameObject.SetActive(true);//打开箭头
                self.View.E_TowerTalentLevel3RightArrowImage.gameObject.SetActive(true);
                self.View.E_TowerTalentLevel3LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowChoose");
                self.View.E_TowerTalentLevel3RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowChoose");
                self.View.E_TowerTalentLevel3LockImage.gameObject.SetActive(false);//关闭锁
            }
            //更新升级按钮
            self.View.E_TowerTalentUpgradeBaseImage.gameObject.SetActive(true);
            self.View.E_TowerTalentMaxBaseImage.gameObject.SetActive(false);
            //------------更新天赋花费金币
            FightItem fightitem = self.ZoneScene().GetComponent<FightItemComponent>().FightItemDict[self.currentId];
            int talentlevel = fightitem.AddedTalent.Count;
            int needmoney = TalentCostConfigCategory.Instance.GetCostByCodeAndLevel(fightitem.Config.TalentCode, fightitem.Upgrading + talentlevel + 1);
            if (needmoney > 0)//未满级
            {
                self.View.E_TowerSpendMoneyNumberText.SetText(needmoney.ToString());
            }
            if (needmoney == 0)
            {
                self.View.E_TowerSpendMoneyNumberText.SetText("最高级");
                self.View.E_TowerTalentUpgradeBaseImage.gameObject.SetActive(false);
                self.View.E_TowerTalentMaxBaseImage.gameObject.SetActive(true);
            }
            //初始化天赋外框
            self.View.E_TowerTalentLevel1LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
            self.View.E_TowerTalentLevel1RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
            self.View.E_TowerTalentLevel2LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
            self.View.E_TowerTalentLevel2RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
            self.View.E_TowerTalentLevel3LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
            self.View.E_TowerTalentLevel3RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
            //根据已经拥有的天赋点更新外框和背景
            for (int i = 0; i < fightitem.AddedTalent.Count; i++)
            {

                int talent = fightitem.AddedTalent[i];
                Log.Debug(talent.ToString());
                TalentConfig config = TalentConfigCategory.Instance.Get(talent);
                int Level = config.Level;
                int Sn = config.Sn;
                if(Level == 1)//第一层
                {
                    self.View.E_TowerTalent1BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseNormal");//正常背景
                    if (Sn == 1)//左边选中--亮色  右边未选中--暗色
                    {
                        self.View.E_TowerTalentLevel1LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowBright");
                        self.View.E_TowerTalentLevel1LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxChoose");
                        self.View.E_TowerTalentLevel1RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowDark");
                        self.View.E_TowerTalentLevel1RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
                    }
                    if(Sn == 2)//左边未选中--暗色  右边选中--亮色
                    {
                        self.View.E_TowerTalentLevel1LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowDark");
                        self.View.E_TowerTalentLevel1LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
                        self.View.E_TowerTalentLevel1RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowBright");
                        self.View.E_TowerTalentLevel1RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxChoose");
                    }
                }
                if(Level == 2)//第二层
                {
                    self.View.E_TowerTalent2BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseNormal");//正常背景
                    if (Sn == 1)//左边选中--亮色  右边未选中--暗色
                    {
                        self.View.E_TowerTalentLevel2LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowBright");
                        self.View.E_TowerTalentLevel2LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxChoose");
                        self.View.E_TowerTalentLevel2RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowDark");
                        self.View.E_TowerTalentLevel2RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
                    }
                    if (Sn == 2)//左边未选中--暗色  右边选中--亮色
                    {
                        self.View.E_TowerTalentLevel2LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowDark");
                        self.View.E_TowerTalentLevel2LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
                        self.View.E_TowerTalentLevel2RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowBright");
                        self.View.E_TowerTalentLevel2RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxChoose");
                    }
                }
                if (Level == 3)//第三层
                {
                    self.View.E_TowerTalent3BaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBaseNormal");//正常背景
                    if (Sn == 1)//左边选中--亮色  右边未选中--暗色
                    {
                        self.View.E_TowerTalentLevel3LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowBright");
                        self.View.E_TowerTalentLevel3LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxChoose");
                        self.View.E_TowerTalentLevel3RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowDark");
                        self.View.E_TowerTalentLevel3RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
                    }
                    if (Sn == 2)//左边未选中--暗色  右边选中--亮色
                    {
                        self.View.E_TowerTalentLevel3LeftArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowDark");
                        self.View.E_TowerTalentLevel3LeftBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxNormal");
                        self.View.E_TowerTalentLevel3RightArrowImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "ArrowBright");
                        self.View.E_TowerTalentLevel3RightBaseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TalentBoxChoose");
                    }
                }
            }
        }
    }
}
