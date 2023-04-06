namespace ET
{
    [FriendClass(typeof(LevelComponent))]
    [MessageHandler]
    public class G2C_UpdateLevelDataHandler : AMHandler<G2C_UpdateLevelData>
    {
        protected override async void Run(Session session, G2C_UpdateLevelData message)
        {
            LevelComponent levelcomponent = session.ZoneScene().GetComponent<LevelComponent>();
            for(int i=0;i<message.LevelData.Count;i++)
            {
                if(i<levelcomponent.LevelData.Count)//已经打了的关卡
                {
                    levelcomponent.LevelData[i] = message.LevelData[i];
                }
                else
                {
                    levelcomponent.LevelData.Add(message.LevelData[i]);
                }
            }
            await ETTask.CompletedTask;
        }
    }
}
