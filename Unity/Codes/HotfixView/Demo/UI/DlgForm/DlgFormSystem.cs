using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [FriendClass(typeof(DlgForm))]
    public static class DlgFormSystem
    {

        public static void RegisterUIEvent(this DlgForm self)
        {
            self.View.E_BackBaseButton.AddListener(() => { self.CloseWindow(); });//返回标签
            self.View.E_PetsLoopScrollListLoopVerticalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrolPetItemRefreshHandler(transform, index); });//可买怪滑动列表项
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrolTowerItemRefreshHandler(transform, index); });//塔滑动列表项
            self.View.E_TowerChooseButton.AddListener(() => { self.ChooseTowerForm(); });//选中塔标签
            self.View.E_PetChooseButton.AddListener(() => { self.ChoosePetForm(); });//选中怪标签
        }

        public static void ShowWindow(this DlgForm self, Entity contextData = null)
        {
            self.Init();
        }

        public static void CloseWindow(this DlgForm self)
        {
            self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Form);
            self.RemoveUIScrollItems(ref self.PetItems);
            self.RemoveUIScrollItems(ref self.TowerItems);
        }

        //初始化
        public static void Init(this DlgForm self)
        {
            self.type = FightItemType.Tower;
            self.CurrentTowerPage = 1;
            self.CurrentPetPage = 1;

            self.towerfightitem = FightItemHelper.GetFightItemsByType(self.ZoneScene(), FightItemType.Tower);
            self.petItem = FightItemHelper.GetFightItemsByType(self.ZoneScene(), FightItemType.Pet);
            Log.Debug("" + self.towerfightitem.Count);
            //塔
            self.currentId = self.towerfightitem[0].Id;
            self.RefreshTowerLoop();
            //怪
            self.RefreshPetLoop();
            //end
            self.RefreshByTab();

            self.TowerCount = self.towerfightitem.Count;
            self.AddUIScrollItems(ref self.TowerItems, self.TowerCount);
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.SetVisible(true, self.TowerCount);
        }

        //可买塔的标签
        public static void ChooseTowerForm(this DlgForm self)
        {
            self.CurrentTowerPage = 1;
            self.currentId = self.towerfightitem[0].Id;
            self.type = FightItemType.Tower;
            self.RefreshTowerLoop();
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.RefillCells();
            self.RefreshByTab();
        }

        //可买怪的标签
        public static void ChoosePetForm(this DlgForm self)
        {
            self.CurrentPetPage = 1;
            self.currentId = self.petItem[0].Id;
            self.type = FightItemType.Pet;
            self.RefreshPetLoop();
            self.View.E_PetsLoopScrollListLoopVerticalScrollRect.RefillCells();
            self.RefreshByTab();
        }

        public static void RefreshTowerLoop(this DlgForm self)
        {
            self.TowerCount = self.towerfightitem.Count;
            self.AddUIScrollItems(ref self.TowerItems, self.TowerCount);
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.SetVisible(true, self.TowerCount);
        }
        public static void RefreshPetLoop(this DlgForm self)
        {
            self.PetCount = self.petItem.Count;
            self.AddUIScrollItems(ref self.PetItems, self.PetCount);
            self.View.E_PetsLoopScrollListLoopVerticalScrollRect.SetVisible(true, self.PetCount);
        }

        public static void OnScrolPetItemRefreshHandler(this DlgForm self, Transform transform, int index)
        {

            for (int i = 0; i < self.PetCount; i++)
            {
                Scroll_Item_Pet petItem = self.PetItems[index].BindTrans(transform);
                petItem.E_PetIconImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterNormal");
            }

            /*            FightItem fightitem = self.monsterfightitem[index + (self.CurrentPetPage - 1) * 16];
                        if (fightitem.Id == self.currentId)//表示选中
                        {
                            petItem.E_PetIconImage.sprite = IconHelper.LoadIconSprite(Scroll_Item_Pet petItem = self.PetItems[index].BindTrans(transform););//选中亮颜色
                        }
                        else//未选中
                        {
                            petItem.E_PetIconImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterNormal");
                        }*/
        }

        public static void OnScrolTowerItemRefreshHandler(this DlgForm self, Transform transform, int index)
        {

/*            for (int i = 0; i < self.TowerCount; i++)
            {
                Scroll_Item_Tower towerItem = self.TowerItems[index].BindTrans(transform);
                towerItem.E_TowerIconImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterNormal");
            }*/

            /*            FightItem fightitem = self.monsterfightitem[index + (self.CurrentPetPage - 1) * 16];
                        if (fightitem.Id == self.currentId)//表示选中
                        {
                            petItem.E_PetIconImage.sprite = IconHelper.LoadIconSprite(Scroll_Item_Pet petItem = self.PetItems[index].BindTrans(transform););//选中亮颜色
                        }
                        else//未选中
                        {
                            petItem.E_PetIconImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterNormal");
                        }*/
        }

        public static void RefreshByTab(this DlgForm self)
        {
            self.View.E_TowerIndexTextText.SetText(self.CurrentTowerPage.ToString() + " / " + ((self.towerfightitem.Count - 1) / 16 + 1).ToString());//页数
            self.View.E_PetIndexTextText.SetText(self.CurrentPetPage.ToString() + " / " + ((self.PetItems.Count - 1) / 16 + 1).ToString());//页数
            if (self.type == FightItemType.Tower)
            {
                //更换索引标签
                self.View.E_TowerChooseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelBright");
                self.View.E_TowerChooseNameImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerBright");
                self.View.E_TowerChooseNameImage.transform.localPosition = new Vector3(10, 0, 0);

                self.View.E_PetChooseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_PetChooseNameImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterDark");
                self.View.E_PetChooseNameImage.transform.localPosition = new Vector3(20, 0, 0);

                //end
                //主显示部分
                self.View.E_TowerBgImage.gameObject.SetActive(true);
                self.View.E_PetBgImage.gameObject.SetActive(false);
                //end
            }
            if (self.type == FightItemType.Pet)
            {
                //更换索引标签
                self.View.E_TowerChooseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelDark");
                self.View.E_TowerChooseNameImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "TowerDark");
                self.View.E_TowerChooseNameImage.transform.localPosition = new Vector3(20, 0, 0);

                self.View.E_PetChooseImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "LabelBright");
                self.View.E_PetChooseNameImage.sprite = IconHelper.LoadIconSprite("TalentUIRes", "MonsterBright");
                self.View.E_PetChooseNameImage.transform.localPosition = new Vector3(10, 0, 0);
                //end
                //主显示部分
                self.View.E_TowerBgImage.gameObject.SetActive(false);
                self.View.E_PetBgImage.gameObject.SetActive(true);
                //end
            }
        }

    }
}
