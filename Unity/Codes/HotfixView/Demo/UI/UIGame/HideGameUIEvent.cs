using ET.EventType;
using UnityEngine;

namespace ET
{
    [FriendClass(typeof(MapComponent))]
    [FriendClass(typeof(DlgGameUI))]
    public class HideGameUIEvent : AEventAsync<EventType.HideGameUI>
    {
        protected override async ETTask Run(HideGameUI args)
        {
            if (args.ZoneScene.GetComponent<UIComponent>().IsWindowVisible(WindowID.WindowID_Login))
            {
                args.ZoneScene.GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Login);
            }
            args.ZoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_MainHome);
            if (args.ZoneScene.GetComponent<UIComponent>().IsWindowVisible(WindowID.WindowID_GameUI))//如果存在
            {
                if(args.ZoneScene.GetComponent<UIComponent>().GetDlgLogic<DlgGameUI>().MatchMode == 1)
                {
                    args.ZoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Select);
                }
                args.ZoneScene.GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_GameUI);
            }
     
            GlobalComponent.Instance.MainCamera.transform.position = new UnityEngine.Vector3(0, 0, -35.2f);

            //展示地图
            GameObject bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
            GameObject prefab = bundleGameObject.Get<GameObject>("Map1");
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            go.transform.position = new Vector3(0, 0, 0);
            MapComponent mapcomponent = args.CurrentScene.AddComponent<MapComponent>();
            mapcomponent.MapObject = go;
            await ETTask.CompletedTask;
        }
    }
}
