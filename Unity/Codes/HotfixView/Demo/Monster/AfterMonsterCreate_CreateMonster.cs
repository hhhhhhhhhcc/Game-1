using UnityEngine;

namespace ET
{
    [FriendClass(typeof(GlobalComponent))]
    [FriendClass(typeof(MonsterMoveComponent))]
    [FriendClass(typeof(Monster))]
    public class AfterMonsterCreate_CreateMonster: AEventAsync<EventType.AfterUnitCreateMonster>
    {
        protected override async ETTask Run(EventType.AfterUnitCreateMonster args)
        {
            // Unit View层
            // 这里可以改成异步加载，demo就不搞了
            GameObject bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
            string PrefabOrIconName = FightItemConfigCategory.Instance.Get(args.Monster.Config.MonsterConfigId).ResourceCode;
            GameObject prefab = bundleGameObject.Get<GameObject>(PrefabOrIconName);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            
            args.Monster.AddComponent<GameObjectComponent>().GameObject = go;
            args.Monster.GetComponent<GameObjectComponent>().SpriteRender = go.GetComponent<SpriteRenderer>();
            args.Monster.GetComponent<GameObjectComponent>().SpriteRender.sprite = IconHelper.LoadIconSprite("monster", PrefabOrIconName);
            if(args.Monster.PlayerBuy == true)
            {
                GameObject Material = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Material");
                string material = args.Monster.Zone != UnitHelper.GetMyUnitFromCurrentScene(args.CurrentScene).GetComponent<NumericComponent>().GetAsInt(NumericType.Position) ? "GreenOutLine" : "RedOutLine";
                args.Monster.GetComponent<GameObjectComponent>().SpriteRender.material = Material.Get<Material>(material);
            }
            args.Monster.AddComponent<AnimatorComponent>();
            args.Monster.AddComponent<HeadHpViewComponent>();
            args.Monster.GetComponent<HeadHpViewComponent>().Init(1);
            args.Monster.GetComponent<HeadHpViewComponent>().SetMonsterHp();

            MonsterMoveComponent movecomponent = args.Monster.GetComponent<MonsterMoveComponent>();
            //设置起始坐标
            movecomponent.LogicPos = movecomponent.NavPos[0];
            args.Monster.Position = movecomponent.NavPos[0];
        }
    }
}