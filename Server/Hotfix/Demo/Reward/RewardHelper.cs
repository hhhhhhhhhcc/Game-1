
using System.Collections.Generic;

namespace ET
{
    public static class RewardHelper
    {
        public static void AddReward(Unit unit,List<int> ItemId,List<int> ItemNumber)
        {
            NumericComponent num = unit.GetComponent<NumericComponent>();
            for(int i=0;i<ItemId.Count;i++)
            {
                int id = ItemId[i];
                int number = ItemNumber[i];
                switch(id)
                {
                    case 1://游戏金币
                        num.SetNoEvent(NumericType.Gold,num.GetAsInt(NumericType.Gold) + number);
                        break;
                    case 2://游戏钻石
                        break;
                }
            }
        }
        public static Dictionary<int,int> GetRewardByLevelId(int LevelId)
        {
            Dictionary<int,int> RewardDict = new Dictionary<int,int>();
            LevelConfig levelconfig = LevelConfigCategory.Instance.Get(LevelId);
            string reward = levelconfig.Reward;
            string[] rewards = reward.Split(';');
            for(int i=0;i<rewards.Length;i++)
            {
                int rewardid = int.Parse(rewards[i].Split(',')[0]);
                int rewardnumber = int.Parse(rewards[i].Split(',')[1]);
                RewardDict.Add(rewardid,rewardnumber);
            }
            return RewardDict;
        }
        public static int[] GetPercentByLevelId(int LevelId)
        {
            int[] percents = new int[2];
            LevelConfig levelconfig = LevelConfigCategory.Instance.Get(LevelId);
            percents[0] = levelconfig.Percent[0];
            percents[1] = levelconfig.Percent[1];
            return percents;
        }
    }
}
