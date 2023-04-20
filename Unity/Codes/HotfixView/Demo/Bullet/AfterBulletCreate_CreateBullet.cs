using UnityEngine;

namespace ET
{
    [FriendClass(typeof(GlobalComponent))]
    [FriendClass(typeof(Bullet))]
    [FriendClass(typeof(BulletNavComponent))]
    [FriendClass(typeof(TowerChargeComponent))]
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

            Vector3 attackpoint = args.Tower.GetComponent<TowerChargeComponent>().AttackPoint.transform.position;

            go.transform.position = attackpoint;

            args.Bullet.Position = go.transform.position;
            args.Bullet.LogicPos = go.transform.position;

            args.Bullet.Position = attackpoint;//子弹初始位置同步塔的位置
            args.Bullet.LogicPos = attackpoint;
            await ETTask.CompletedTask;
        }

    }
}