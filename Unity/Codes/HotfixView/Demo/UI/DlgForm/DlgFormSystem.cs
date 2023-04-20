using UnityEngine;
namespace ET
{
    [FriendClass(typeof(DlgForm))]
    public static class DlgFormSystem
    {

        public static void RegisterUIEvent(this DlgForm self)
        {
            self.View.E_BackBaseButton.AddListener(() => { self.CloseWindow(); });//返回标签
            

            self.View.E_TowerChooseButton.AddListener(() => { self.ChooseTowerForm(); });//选中塔标签
            self.View.E_PetChooseButton.AddListener(() => { self.ChoosePetForm(); });//选中怪标签

            self.View.E_TowerLeftPageButton.AddListener(() => { self.TowerPageReduce(); });//塔往左翻
            self.View.E_TowerRightPageButton.AddListener(() => { self.TowerPageAdd(); });//塔往右翻
            self.View.E_PetLeftPageButton.AddListener(() => { self.PetPageReduce(); });//怪往左翻
            self.View.E_PetRightPageButton.AddListener(() => { self.PetPageAdd(); });//怪往右翻

            self.View.E_Tower1CancleButton.AddListener(() => { self.TowerCancle(0); });
            self.View.E_Tower2CancleButton.AddListener(() => { self.TowerCancle(1); });
            self.View.E_Tower3CancleButton.AddListener(() => { self.TowerCancle(2); });
            self.View.E_Tower4CancleButton.AddListener(() => { self.TowerCancle(3); });
            self.View.E_Pet1CancleButton.AddListener(() => { self.PetCancle(0); });
            self.View.E_Pet2CancleButton.AddListener(() => { self.PetCancle(1); });
            self.View.E_Pet3CancleButton.AddListener(() => { self.PetCancle(2); });
            self.View.E_Pet4CancleButton.AddListener(() => { self.PetCancle(3); });

            self.View.E_ConfirmButton.AddListener(() => { self.ConfirmForm(); });
        }
        public static void ShowWindow(this DlgForm self, Entity contextData = null)
        {
            self.Init();
        }
        public static void CloseWindow(this DlgForm self)
        {
            self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Form);
            self.RemoveUIScrollItems(ref self.TowerItems);
            self.RemoveUIScrollItems(ref self.PetItems);
        }
        //初始化
        public static void Init(this DlgForm self)
        {
            self.tower1 = 0;
            self.tower2 = 0;
            self.tower3 = 0;
            self.tower4 = 0;
            self.pet1= 0;
            self.pet2 = 0;
            self.pet3 = 0;
            self.pet4 = 0;

            self.type = FightItemType.Tower;
            self.CurrentTowerPage = 1;
            self.CurrentPetPage = 1;

            NumericComponent numericcomponent = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene()).GetComponent<NumericComponent>();
            if(numericcomponent.GetAsInt(NumericType.TowerId1) != 0)
            {
                self.TowerFormAdd(numericcomponent.GetAsInt(NumericType.TowerId1), 0);
            }
            if (numericcomponent.GetAsInt(NumericType.TowerId2) != 0)
            {
                self.TowerFormAdd(numericcomponent.GetAsInt(NumericType.TowerId2), 1);
            }
            if (numericcomponent.GetAsInt(NumericType.TowerId3) != 0)
            {
                self.TowerFormAdd(numericcomponent.GetAsInt(NumericType.TowerId3), 2);
            }
            if (numericcomponent.GetAsInt(NumericType.TowerId4) != 0)
            {
                self.TowerFormAdd(numericcomponent.GetAsInt(NumericType.TowerId4), 3);
            }
            if (numericcomponent.GetAsInt(NumericType.Monster1) != 0)
            {
                self.PetFormAdd(numericcomponent.GetAsInt(NumericType.Monster1), 0);
            }
            if (numericcomponent.GetAsInt(NumericType.Monster2) != 0)
            {
                self.PetFormAdd(numericcomponent.GetAsInt(NumericType.Monster2), 1);
            }
            if (numericcomponent.GetAsInt(NumericType.Monster3) != 0)
            {
                self.PetFormAdd(numericcomponent.GetAsInt(NumericType.Monster3), 2);
            }
            if (numericcomponent.GetAsInt(NumericType.Monster4) != 0)
            {
                self.PetFormAdd(numericcomponent.GetAsInt(NumericType.Monster4), 3);
            }
            self.View.E_PetsLoopScrollListLoopVerticalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrolPetItemRefreshHandler(transform, index); });//可买怪滑动列表项
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnScrolTowerItemRefreshHandler(transform, index); });//塔滑动列表项     
            self.towerfightitem = FightItemHelper.GetFightItemsByType(self.ZoneScene(), FightItemType.Tower);
            self.petItem = FightItemHelper.GetFightItemsByType(self.ZoneScene(), FightItemType.Pet);
            //塔
            self.RefreshTowerLoop();
            //怪
            self.RefreshPetLoop();
            //end
            self.RefreshByTab();
        }
        public static void SingleModeNumber(this DlgForm self)
        {
            self.mode = 1;
        }
        //可买塔的标签
        public static void ChooseTowerForm(this DlgForm self)
        {
            self.CurrentTowerPage = 1;
            //self.currentId = self.towerfightitem[0].Id;
            self.currentId = 0;
            self.type = FightItemType.Tower;
            //self.RefreshTowerLoop();
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.RefillCells();
            self.RefreshByTab();
        }
        //可买怪的标签
        public static void ChoosePetForm(this DlgForm self)
        {
            self.CurrentPetPage = 1;
            //self.currentId = self.petItem[0].Id;
            self.currentId = 0;
            self.type = FightItemType.Pet;
            //self.RefreshPetLoop();
            self.View.E_PetsLoopScrollListLoopVerticalScrollRect.RefillCells();
            self.RefreshByTab();
        }

        public static void SelectTowerConfig(this DlgForm self, long id)
        {
            self.currentId = id;
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.RefreshCells();
            self.RefreshByTab();
        }

        public static void SelectPetConfig(this DlgForm self, long id)
        {
            self.currentId = id;
            self.View.E_PetsLoopScrollListLoopVerticalScrollRect.RefreshCells();
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
            Scroll_Item_Pet petItem = self.PetItems[index].BindTrans(transform);
            FightItem fightitem = self.petItem[index + (self.CurrentPetPage - 1) * 16];
            FightItemConfig fightItemConfig = FightItemConfigCategory.Instance.Get(fightitem.Config.Id);
            if (fightitem.Id == self.currentId)//表示选中
            {
                if (self.pet[0] == fightitem.Config.Id || self.pet[1] == fightitem.Config.Id || self.pet[2] == fightitem.Config.Id || self.pet[3] == fightitem.Config.Id)
                {
                    return;
                }
                petItem.E_SelectBigImage.gameObject.SetActive(true);
                petItem.E_PetSelectFormImage.gameObject.SetActive(true);
                if (self.pet[0] == 0)
                {
                    self.pet[0] = fightitem.Config.Id;
                    self.pet1 = fightitem.Config.Id;
                    self.PetFormAdd(self.pet1, 0);
                }
                else if (self.pet[1] == 0)
                {
                    self.pet[1] = fightitem.Config.Id;
                    self.pet2 = fightitem.Config.Id;
                    self.PetFormAdd(self.pet2, 1);
                }
                else if (self.pet[2] == 0)
                {
                    self.pet[2] = fightitem.Config.Id;
                    self.pet3 = fightitem.Config.Id;
                    self.PetFormAdd(self.pet3, 2);
                }
                else if (self.pet[3] == 0)
                {
                    self.pet[3] = fightitem.Config.Id;
                    self.pet4 = fightitem.Config.Id;
                    self.PetFormAdd(self.pet4, 3);
                }
                petItem.E_PetIconButton.interactable = false;
            }
            else//未选中
            {
                petItem.E_PetIconImage.sprite = IconHelper.LoadIconSprite("monster", fightItemConfig.ResourceCode);
            }
            if (self.pet[0] != fightitem.Config.Id && self.pet[1] != fightitem.Config.Id && self.pet[2] != fightitem.Config.Id && self.pet[3] != fightitem.Config.Id)
            { 
                petItem.E_PetIconButton.interactable = true;
                petItem.E_SelectBigImage.gameObject.SetActive(false);
                petItem.E_PetSelectFormImage.gameObject.SetActive(false);
            }
            if (self.pet[0] == fightitem.Config.Id || self.pet[1] == fightitem.Config.Id || self.pet[2] == fightitem.Config.Id || self.pet[3] == fightitem.Config.Id)
            {
                petItem.E_PetIconButton.interactable = false;
                petItem.E_PetSelectFormImage.gameObject.SetActive(true);
                petItem.E_SelectBigImage.gameObject.SetActive(true);
            }
            petItem.E_PetIconButton.AddListener(() => { self.SelectPetConfig(fightitem.Id); });

        }

        public static void OnScrolTowerItemRefreshHandler(this DlgForm self, Transform transform, int index)
        {
            Scroll_Item_TowerForm towerItem = self.TowerItems[index].BindTrans(transform);
            FightItem fightitem = self.towerfightitem[index + (self.CurrentPetPage - 1) * 16];
            FightItemConfig fightItemConfig = FightItemConfigCategory.Instance.Get(fightitem.Config.Id);
            if (fightitem.Id == self.currentId)//表示选中
            {
                if (self.tower[0] == fightitem.Config.Id || self.tower[1] == fightitem.Config.Id || self.tower[2] == fightitem.Config.Id || self.tower[3] == fightitem.Config.Id)
                {
                    return;
                }
                towerItem.E_SelectedBigImage.gameObject.SetActive(true);
                towerItem.E_TowerNomerFormImage.gameObject.SetActive(true);
                if (self.tower[0] == 0)
                {
                    self.tower[0] = fightitem.Config.Id; ;
                    self.tower1 = fightitem.Config.Id;
                    self.TowerFormAdd(self.tower1, 0);
                }
                else if (self.tower[1] == 0)
                {
                    self.tower[1] = fightitem.Config.Id;
                    self.tower2 = fightitem.Config.Id;
                    self.TowerFormAdd(self.tower2, 1);
                }
                else if (self.tower[2] == 0)
                {
                    self.tower[2] = fightitem.Config.Id;
                    self.tower3 = fightitem.Config.Id;
                    self.TowerFormAdd(self.tower3, 2);
                }
                else if (self.tower[3] == 0)
                {
                    self.tower[3] = fightitem.Config.Id;
                    self.tower4 = fightitem.Config.Id;
                    self.TowerFormAdd(self.tower4, 3);
                }
                towerItem.E_TowerIconButton.interactable= false;
            }
            else//未选中
            {
                towerItem.E_TowerIconImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig.ResourceCode);
            }
            if (self.tower[0] != fightitem.Config.Id && self.tower[1] != fightitem.Config.Id && self.tower[2] != fightitem.Config.Id && self.tower[3] != fightitem.Config.Id)
            {
                towerItem.E_TowerIconButton.interactable = true;
                towerItem.E_SelectedBigImage.gameObject.SetActive(false);
                towerItem.E_TowerNomerFormImage.gameObject.SetActive(false);
            }
            if (self.tower[0] == fightitem.Config.Id || self.tower[1] == fightitem.Config.Id || self.tower[2] == fightitem.Config.Id || self.tower[3] == fightitem.Config.Id)
            {
                towerItem.E_TowerIconButton.interactable = false;
                towerItem.E_SelectedBigImage.gameObject.SetActive(true);
                towerItem.E_TowerNomerFormImage.gameObject.SetActive(true);
            }
            towerItem.E_TowerIconButton.AddListener(() => { self.SelectTowerConfig(fightitem.Id); });

        }

        public static void RefreshByTab(this DlgForm self)
        {
            self.View.E_TowerIndexTextText.SetText(self.CurrentTowerPage.ToString() + " / " + ((self.towerfightitem.Count - 1) / 16 + 1).ToString());//页数
            self.View.E_PetIndexTextText.SetText(self.CurrentPetPage.ToString() + " / " + ((self.PetItems.Count - 1) / 16 + 1).ToString());//页数
            if (self.type == FightItemType.Tower)
            {
                //更换索引标签
                self.View.E_TowerChooseImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "LableButtonBright");
                self.View.E_TowerChooseNameImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "TowerBright");
                self.View.E_TowerChooseNameImage.transform.localPosition = new Vector3(10, 0, 0);

                self.View.E_PetChooseImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "LableButtonNorme");
                self.View.E_PetChooseNameImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "PetNorme");
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
                self.View.E_TowerChooseImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "LableButtonNorme");
                self.View.E_TowerChooseNameImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "TowerNorme");
                self.View.E_TowerChooseNameImage.transform.localPosition = new Vector3(20, 0, 0);

                self.View.E_PetChooseImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "LableButtonBright");
                self.View.E_PetChooseNameImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "PetBright");
                self.View.E_PetChooseNameImage.transform.localPosition = new Vector3(10, 0, 0);
                //end
                //主显示部分
                self.View.E_TowerBgImage.gameObject.SetActive(false);
                self.View.E_PetBgImage.gameObject.SetActive(true);
                //end
            }
        }

        //塔页数增多
        public static void TowerPageAdd(this DlgForm self)
        {
            int alltowernumber = self.towerfightitem.Count;
            int maxPage = (alltowernumber - 1) / 16 + 1;
            if (self.CurrentTowerPage < maxPage)
            {
                self.CurrentTowerPage++;
                self.currentId = self.towerfightitem[(self.CurrentTowerPage - 1) * 16].Id;
                self.RefreshTowerLoop();
                self.RefreshByTab();
            }
        }
        //塔页数减少
        public static void TowerPageReduce(this DlgForm self)
        {
            if (self.CurrentTowerPage > 1)
            {
                self.CurrentTowerPage--;
                self.currentId = self.towerfightitem[(self.CurrentTowerPage - 1) * 16].Id;
                self.RefreshTowerLoop();
                self.RefreshByTab();
            }
        }
        //怪物页数增多
        public static void PetPageAdd(this DlgForm self)
        {
            int allmonsternumber = self.petItem.Count;
            int maxPage = (allmonsternumber - 1) / 16 + 1;
            if (self.CurrentPetPage < maxPage)
            {
                self.CurrentPetPage++;
                self.currentId = self.petItem[(self.CurrentPetPage - 1) * 16].Id;
                self.RefreshPetLoop();
                self.RefreshByTab();
            }
        }
        //怪物页数减少
        public static void PetPageReduce(this DlgForm self)
        {
            int allmonsternumber = self.petItem.Count;
            if (self.CurrentPetPage > 1)
            {
                self.CurrentPetPage--;
                self.currentId = self.petItem[(self.CurrentPetPage - 1) * 16].Id;
                self.RefreshPetLoop();
                self.RefreshByTab();
            }
        }

        public static void TowerCancle(this DlgForm self,int index)
        {
            self.tower[index] = 0;
            switch (index)
            {
                case 0:
                    {
                        self.View.E_Tower1_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.tower1 = 0;
                        break;
                    }
                case 1:
                    {
                        self.View.E_Tower2_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.tower2 = 0;
                        break;
                    }
                case 2:
                    {
                        self.View.E_Tower3_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.tower3 = 0;
                        break;
                    }
                case 3:
                    {
                        self.View.E_Tower4_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.tower4 = 0;
                        break;
                    }
            }
            self.currentId = 0;
            self.View.E_TowerLoopScrollListLoopVerticalScrollRect.RefreshCells();
        }

        public static void PetCancle(this DlgForm self, int index)
        {
            self.pet[index] = 0;
            switch (index)
            {
                case 0:
                    {
                        self.View.E_Pet1_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.pet1 = 0;
                        break;
                    }
                case 1:
                    {
                        self.View.E_Pet2_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.pet2 = 0;
                        break;
                    }
                case 2:
                    {
                        self.View.E_Pet3_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.pet3 = 0;
                        break;
                    }
                case 3:
                    {
                        self.View.E_Pet4_ImageImage.sprite = IconHelper.LoadIconSprite("SelectLevel", "NoPeople");
                        self.pet4 = 0;
                        break;
                    }
            }
            self.currentId = 0;
            self.View.E_PetsLoopScrollListLoopVerticalScrollRect.RefreshCells();
        }

        public static void TowerFormAdd(this DlgForm self, int chooseOne, int index)
        {
            FightItemConfig fightItemConfig = FightItemConfigCategory.Instance.Get(chooseOne);
            self.tower[index] = chooseOne;
            switch (index)
            {
                case 0:
                    {
                        self.View.E_Tower1_ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig.ResourceCode);
                        self.tower1 = chooseOne;
                        break;
                    }
                case 1:
                    {
                        self.View.E_Tower2_ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig.ResourceCode);
                        self.tower2 = chooseOne;
                        break;
                    }
                case 2:
                    {
                        self.View.E_Tower3_ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig.ResourceCode);
                        self.tower3 = chooseOne;
                        break;
                    }
                case 3:
                    {
                        self.View.E_Tower4_ImageImage.sprite = IconHelper.LoadIconSprite("Tower", fightItemConfig.ResourceCode);
                        self.tower4 = chooseOne;
                        break;
                    }
            }
        }

        public static void PetFormAdd(this DlgForm self, int chooseOne, int index)
        {
            FightItemConfig fightItemConfig = FightItemConfigCategory.Instance.Get(chooseOne);
            self.pet[index] = chooseOne;
            switch (index)
            {
                case 0:
                    {
                        self.View.E_Pet1_ImageImage.sprite = IconHelper.LoadIconSprite("monster", fightItemConfig.ResourceCode);
                        self.pet1= chooseOne;
                        break;
                    }
                case 1:
                    {
                        self.View.E_Pet2_ImageImage.sprite = IconHelper.LoadIconSprite("monster", fightItemConfig.ResourceCode);
                        self.pet2 = chooseOne;
                        break;
                    }
                case 2:
                    {
                        self.View.E_Pet3_ImageImage.sprite = IconHelper.LoadIconSprite("monster", fightItemConfig.ResourceCode);
                        self.pet3 = chooseOne;
                        break;
                    }
                case 3:
                    {
                        self.View.E_Pet4_ImageImage.sprite = IconHelper.LoadIconSprite("monster", fightItemConfig.ResourceCode);
                        self.pet4 = chooseOne;
                        break;
                    }
            }
        }

        public static void ConfirmForm(this DlgForm self)
        {
            bool st = true;
/*            for (int i = 0; i < 4; i++)
            {
                if (self.pet[i] == -1)
                {
                    st = false;
                    break;
                }
                if (self.tower[i] == -1)
                {
                    st = false;
                    break;
                }
            }*/
            if (st)
            {
                self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_AdjustForm()
                {
                    Pet1 = self.pet1,
                    Pet2 = self.pet2,
                    Pet3 = self.pet3,
                    Pet4 = self.pet4,
                    Tower1 = self.tower1,
                    Tower2 = self.tower2,
                    Tower3 = self.tower3,
                    Tower4 = self.tower4,
                });
            }
            Log.Debug("123");
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgSelect>().RefreshForm(self.tower1, self.tower2, self.tower3, self.tower4);
        }
    }
}
