using UnityEngine;

namespace PotionOfLoop
{
    public class RewardItem
    {
        private CurrencyType? _currencyType = null;

        private int _count = 0;

        public CurrencyType? CurrencyType
        {
            get => _currencyType;
        }

        public int Count
        {
            get => _count;
        }

        public RewardItem(CurrencyType? currencyType, int count)
        {
            _currencyType = currencyType;
            _count = count;
        }
    }
}