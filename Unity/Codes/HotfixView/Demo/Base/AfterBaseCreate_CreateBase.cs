using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [FriendClass(typeof(GlobalComponent))]
    [FriendClass(typeof(GameComponent))]
    [FriendClass(typeof(Base))]
    public class AfterBaseCreate_CreateBase : AEventAsync<EventType.AfterUnitCreateBase>
    {
        protected override async ETTask Run(EventType.AfterUnitCreateBase args)
        {
            // Unit View层
            // 这里可以改成异步加载，demo就不搞了
            GameObject bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
            GameObject prefab = bundleGameObject.Get<GameObject>("Base");
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);

            args.baseitem.AddComponent<GameObjectComponent>().GameObject = go;
            args.baseitem.GetComponent<GameObjectComponent>().SpriteRender = go.GetComponent<SpriteRenderer>();
            args.baseitem.AddComponent<AnimatorComponent>();
            args.baseitem.AddComponent<HeadHpViewComponent>();
            args.baseitem.GetComponent<HeadHpViewComponent>().Init(2);
            args.baseitem.GetComponent<HeadHpViewComponent>().SetBaseHp();
            int BasePos = args.baseitem.PosId;

            Vector3[] v3s = args.currentscene.GetComponent<GameComponent>().MonsterNavs[BasePos];
            Vector3 pos = v3s[v3s.Length - 1];
            args.baseitem.Position = go.transform.position;
            args.baseitem.Position = pos;
            //设置起始坐标
            await ETTask.CompletedTask;
        }
    }
}