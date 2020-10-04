using System;

namespace PotionOfLoop
{
    public class Reward
    {
        public static event Action<Reward> Received = delegate { };

        public RewardItem[] RewardItems
        {
            get;
            private set;
        }

        public Reward(RewardItem[] rewardItems)
        {
            RewardItems = rewardItems;

            Received(this);
        }
    }
}