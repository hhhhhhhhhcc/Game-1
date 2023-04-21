
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
                        num.Set(NumericType.Gold,num.GetAsInt(NumericType.Gold) + number);
                        break;
                    case 2://游戏钻石
                        break;
                }
            }
        }
        public static (List<int>,List<int>) GetRewardByLevelId(int LevelId)
        {
            List<int> rewardTypes = new List<int>();
            List<int> rewardNumbers = new List<int>();
            LevelConfig levelconfig = LevelConfigCategory.Instance.Get(LevelId);
            string levelreward = levelconfig.Reward;
            string[] rewards = levelreward.Split(';');
            for(int i=0;i< rewards.Length;i++)
            {
                string[] reward = rewards[i].Split(',');
                int rewardType = int.Parse(reward[0]);
                int rewardNumber = int.Parse(reward[1]);
                rewardTypes.Add(rewardType);
                rewardNumbers.Add(rewardNumber);
            }
            return (rewardTypes,rewardNumbers);
            
        }
    }
}
