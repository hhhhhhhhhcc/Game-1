
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
    [ObjectSystem]
    public class DlgGameUIViewComponentAwakeSystem : AwakeSystem<DlgGameUIViewComponent>
    {
        public override void Awake(DlgGameUIViewComponent self)
        {
            self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
        }
    }
    [ObjectSystem]
    [FriendClass(typeof(GameComponent))]
    public class DlgGameUIViewComponentUpdateSystem : UpdateSystem<DlgGameUIViewComponent>
    {
        public override void Update(DlgGameUIViewComponent self)
        {
            if (self.ZoneScene()?.CurrentScene()?.GetComponent<GameComponent>()?.GameEnding == false || self.ZoneScene()?.CurrentScene()?.GetComponent<GameComponent>() == null) return;
            //视角缩放
            float Scale = self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetVisualScale(Input.GetAxis("Mouse ScrollWheel"));
            float MaxX = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MaxVisualX / 216.0f;
            float MaxY = self.ZoneScene().CurrentScene().GetComponent<GameComponent>().MaxVisualY / 216.0f;
            Transform cameratransform = GlobalComponent.Instance.MainCamera;
            cameratransform.GetComponent<Camera>().orthographicSize = 5.0f / Scale;
            if (cameratransform.position.x > MaxX - cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//在右边最大值往左移动
            {
                cameratransform.position = new Vector3(MaxX - cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f, cameratransform.position.y, -35.2f);
            }
            if (cameratransform.position.x < -MaxX + cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//在左边最大值往右移动
            {
                cameratransform.position = new Vector3(-MaxX + cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f, cameratransform.position.y, -35.2f);
            }
            if (cameratransform.position.y > MaxY - cameratransform.GetComponent<Camera>().orthographicSize)//在上边最大值往下移动
            {
                cameratransform.position = new Vector3(cameratransform.position.x, MaxY - cameratransform.GetComponent<Camera>().orthographicSize, -35.2f);
            }
            if (cameratransform.position.y < -MaxY + cameratransform.GetComponent<Camera>().orthographicSize)//在下边最大值往右移动
            {
                cameratransform.position = new Vector3(cameratransform.position.x, -MaxY + cameratransform.GetComponent<Camera>().orthographicSize, -35.2f);
            }
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetBuildTowerPosUI(cameratransform.position);
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetWaveInfoPosUI(cameratransform.position);
            self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().SetReleaseMonsterPosUI(cameratransform.position);
            
            //end
            //视角移动
            int VisualControl = self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().GetVisual();//移动参数
            float movespeed = 3;
            if (VisualControl == 1)//左
            {
                if (cameratransform.position.x >= -MaxX + cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//左
                {
                    cameratransform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(-1, 0, 0));
                }

            }
            if (VisualControl == 2)//左上
            {
                if (cameratransform.position.x >= -MaxX + cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//左
                {
                    cameratransform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(-1, 0, 0));
                }
                if (cameratransform.position.y <= MaxY - cameratransform.GetComponent<Camera>().orthographicSize)//上
                {
                    cameratransform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(0, 1, 0));
                }
            }
            if (VisualControl == 3)//上
            {
                if (cameratransform.position.y <= MaxY - cameratransform.GetComponent<Camera>().orthographicSize)//上
                {
                    cameratransform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(0, 1, 0));
                }
            }
            if (VisualControl == 4)//右上
            {
                if (cameratransform.position.x <= MaxX - cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//右
                {
                    cameratransform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(1, 0, 0));
                }
                if (cameratransform.position.y <= MaxY - cameratransform.GetComponent<Camera>().orthographicSize)//上
                {
                    cameratransform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(0, 1, 0));
                }
            }
            if (VisualControl == 5)//右
            {
                if (cameratransform.position.x <= MaxX - cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//右
                {
                    cameratransform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(1, 0, 0));
                }
            }
            if (VisualControl == 6)//右下
            {
                if (cameratransform.position.x <= MaxX - cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//右
                {
                    cameratransform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(1, 0, 0));
                }
                if (cameratransform.position.y >= -MaxY + cameratransform.GetComponent<Camera>().orthographicSize)//下
                {
                    cameratransform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(0, -1, 0));
                }
            }
            if (VisualControl == 7)//下
            {
                if (cameratransform.position.y >= -MaxY + cameratransform.GetComponent<Camera>().orthographicSize)//下
                {
                    cameratransform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(0, -1, 0));
                }
            }
            if (VisualControl == 8)//左下
            {
                if (cameratransform.position.x >= -MaxX + cameratransform.GetComponent<Camera>().orthographicSize * 16.0f / 9.0f)//左
                {
                    cameratransform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(-1, 0, 0));
                }
                if (cameratransform.position.y >= -MaxY + cameratransform.GetComponent<Camera>().orthographicSize)//下
                {
                    cameratransform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * movespeed);
                    //self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MoveCurrentTower(new Vector3(0, -1, 0));
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().InputToAction(1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().InputToAction(2);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().InputToAction(3);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().InputToAction(4);
            }
            self.E_RangeSkillImage.transform.localPosition = (Input.mousePosition - new Vector3(Screen.width / 2, Screen.height / 2, 0)) * Screen.currentResolution.width / Screen.width;
            if (Input.GetMouseButtonUp(0))
            {
                int playerskillId = self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().GetCurrentPlayerSkillId();
                if (playerskillId == 0)
                {
                    RaycastHit2D hit = Physics2D.Raycast(GlobalComponent.Instance.MainCamera.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                    if (hit)
                    {
                        if (hit.collider.transform.tag == "Map")
                        {
                            float x = hit.point.x;
                            float y = hit.point.y;
                            GameComponent gamecomponent = self.ZoneScene().CurrentScene().GetComponent<GameComponent>();
                            bool IsHaveUnit = false;
                            for (int i = 0; i < gamecomponent.AllTower.Count; i++)
                            {
                                Tower tower = gamecomponent.AllTower[i];
                                float distance = Vector2.Distance(new Vector2(x, y), tower.Position);
                                if (distance <= 0.5f)
                                {
                                    IsHaveUnit = true;
                                    self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().RefreshTowerInfo(tower.Id,true);
                                    break;
                                }
                            }
                            for (int i = 0; i < gamecomponent.AllEnemy.Count; i++)
                            {
                                Monster monster = gamecomponent.AllEnemy[i];
                                float distance = Vector2.Distance(new Vector2(x, y), monster.Position);
                                if (distance <= 0.3f)
                                {
                                    IsHaveUnit = true;
                                    self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().RefreshMonsterInfo(monster.Id,true);
                                    break;
                                }
                            }
                            for (int i = 0; i < gamecomponent.AllTroop.Count; i++)
                            {
                                Troop troop = gamecomponent.AllTroop[i];
                                float distance = Vector2.Distance(new Vector2(x, y), troop.Position);
                                if (distance <= 0.3f)
                                {
                                    IsHaveUnit = true;
                                    self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().RefreshTroopInfo(troop.Id);
                                    break;
                                }
                            }
                            if (IsHaveUnit == false)
                            {
                                self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().HideUnitInfo();
                            }
                        }
                    }
                }
                else
                {
                    PlayerSkillConfig config = PlayerSkillConfigCategory.Instance.Get(playerskillId);
                    int playerskilltype = config.ReleaseType;

                    if (playerskilltype == 2 || playerskilltype == 3)
                    {
                        RaycastHit2D hit = Physics2D.Raycast(GlobalComponent.Instance.MainCamera.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                        if (hit)
                        {
                            if (hit.collider.transform.tag == "Map")
                            {
                                self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().ReleasePlayerSkill((int)(hit.point.x * 10000), (int)(hit.point.y * 10000), new List<long>() { });
                            }
                        }
                    }
                }
            }
        }
    }

    [ObjectSystem]
    public class DlgGameUIViewComponentDestroySystem : DestroySystem<DlgGameUIViewComponent>
    {
        public override void Destroy(DlgGameUIViewComponent self)
        {
            self.DestroyWidget();
        }
    }
}
