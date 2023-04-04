namespace ET
{
    [MessageHandler]
    public class G2C_AllFightItemsListHandler : AMHandler<G2C_AllFightItemsList>
    {
        protected override void Run(Session session, G2C_AllFightItemsList message)
        {
            FightItemHelper.Clear(session.ZoneScene());
            for(int i=0;i<message.FightItemInfoList.Count;i++)
            {
                FightItem fightitem = FightItemFactory.Create(session.ZoneScene(), message.FightItemInfoList[i]);
                FightItemHelper.AddFightItem(session.ZoneScene(), fightitem);
            }
        }
    }
}
