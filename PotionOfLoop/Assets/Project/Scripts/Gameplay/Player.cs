namespace PotionOfLoop
{
    public class Player : DamagableUnit
    {
        private static Player _instance = null;

        public static Player Instance
        {
            get => _instance;
        }

        private void Awake()
        {
            _instance = this;
        }
    }
}