namespace PotionOfLoop
{
    public class Coin : ICurrency
    {
        private int _count = 0;

        public int Count
        {
            get => _count;
        }

        public Coin()
        {
            Load();
        }

        public void Load()
        {
            _count = LocalConfig.CoinCurrency;
        }

        public void AdjustCurrency(int count)
        {
            _count += count;

            LocalConfig.CoinCurrency = _count;
        }
    }
}