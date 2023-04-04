using UnityEngine;

namespace ET
{
    [FriendClass(typeof(HeadHpViewComponent))]
    [FriendClass(typeof(Monster))]
    public class MonsterDeathEvent : AEventAsync<EventType.MonsterDeath>
    {
        protected override async ETTask Run(EventType.MonsterDeath args)
        {
            int hp = args.Monster.Hp;
            if (hp > 0) return;
            if(args.IsAdd && args.Monster.Zone==UnitHelper.GetMyUnitFromCurrentScene(args.currentscene).GetComponent<NumericComponent>().GetAsInt(NumericType.Position))//添加金币
            {
                int DropMoney = args.Monster.ReturnMoney;
                Unit unit = UnitHelper.GetMyUnitFromCurrentScene(args.currentscene);
                NumericComponent unitnumeric = unit.GetComponent<NumericComponent>();
                unitnumeric.Set(NumericType.GameMoney, unitnumeric.GetAsInt(NumericType.GameMoney) + DropMoney + args.ExtraCoin);
            }
            AnimatorComponent animator = args.Monster.GetComponent<AnimatorComponent>();
            string animatorname;
            if(args.Monster.GetComponent<MonsterMoveComponent>().GetDir().x >= 0)
            {
                animatorname = "RDdie";
            }
            else
            {
                animatorname = "LDdie";
            }
            args.Monster.IsDead = true;
            AnimatorHelper.Play(args.Monster, animatorname).Coroutine();
            args.Monster.GetComponent<HeadHpViewComponent>().HpBarGroup.SetActive(false);
            if(args.Monster.DeathEvent != null) args.Monster.DeathEvent(args.Monster);
            args.currentscene.GetComponent<GameComponent>().RemoveMonster(args.Monster);
            await TimerComponent.Instance.WaitAsync(1500);

            args.Monster?.Dispose();
        }
    }
}