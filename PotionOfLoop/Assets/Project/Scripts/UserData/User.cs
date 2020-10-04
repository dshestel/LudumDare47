using System;

namespace PotionOfLoop
{
    public class User
    {
        public static event Action CurrencyChanged = delegate { };

        private static Coin _coin = null;

        private static User _user = null;

        public Coin Coin
        {
            get => _coin;
        }

        public static User Current
        {
            get => _user;
        }

        public User()
        {
            _user = this;

            Load();
        }

        private void Load()
        {
            if (_coin == null)
            {
                _coin = new Coin();

                GameManager.CurrencyIncomed += GameManager_CurrencyIncomed;
            }
        }

        private void GameManager_CurrencyIncomed(int income)
        {
            _coin.AdjustCurrency(income);

            CurrencyChanged();
        }
    }
}