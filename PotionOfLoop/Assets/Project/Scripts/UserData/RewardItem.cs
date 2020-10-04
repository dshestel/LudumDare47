using UnityEngine;

namespace PotionOfLoop
{
    public class RewardItem
    {
        private CurrencyType? _currencyType = null;
        private ComponentType? _componentType = null;

        private int _count = 0;

        public CurrencyType? CurrencyType
        {
            get => _currencyType;
        }

        public ComponentType? ComponentType
        {
            get => _componentType;
        }

        public int Count
        {
            get => _count;
        }

        public RewardItem(CurrencyType? currencyType = null, ComponentType? componentType = null, int count = 0)
        {
            _currencyType = currencyType;
            _componentType = componentType;
            _count = count;
        }
    }
}