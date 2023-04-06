namespace ET
{
    [FriendClass(typeof(LevelComponent))]
    public static class LevelHelper
    {
        public static void AsycnLevelData(Unit unit)
        {
            G2C_UpdateLevelData message = new G2C_UpdateLevelData();
            LevelComponent levelcomponent = unit.GetComponent<LevelComponent>();
            foreach(int leveldata in levelcomponent.LevelData)
            {
                message.LevelData.Add(leveldata);
            }
            MessageHelper.SendToClient(unit, message);
        }
    }
}
