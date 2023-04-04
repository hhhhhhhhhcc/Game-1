using UnityEngine;

namespace ET
{
    [FriendClass(typeof(GlobalComponent))]
    [FriendClass(typeof(Bullet))]
    [FriendClass(typeof(BulletNavComponent))]
    public class AfterBulletCreate_CreateBullet : AEventAsync<EventType.AfterUnitCreateBullet>
    {
        protected override async ETTask Run(EventType.AfterUnitCreateBullet args)
        {
            // Unit View层
            // 这里可以改成异步加载，demo就不搞了
            GameObject bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
            GameObject prefab = bundleGameObject.Get<GameObject>(args.Bullet.BulletPrefabName);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);

            args.Bullet.AddComponent<GameObjectComponent>().GameObject = go;
            args.Bullet.GetComponent<GameObjectComponent>().SpriteRender = go.GetComponent<SpriteRenderer>();
            args.Bullet.AddComponent<AnimatorComponent>();

            float px = args.Tower.Position.x;
            float py = args.Tower.Position.y;

            go.transform.position = new Vector3(px, py, 0);

            args.Bullet.Position = go.transform.position;
            args.Bullet.LogicPos = go.transform.position;

            args.Bullet.Position = new Vector3(px, py, 0);//子弹初始位置同步塔的位置
            args.Bullet.LogicPos = new Vector3(px, py, 0);
            
        }

    }
}