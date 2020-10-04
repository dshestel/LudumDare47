namespace PotionOfLoop
{
    public class EnemyAttacker : Attacker
    {
        private void Start()
        {
            _target = Player.Instance;
        }

        protected override void TryShot()
        {
            base.TryShot();

            Shot();
        }
    }
}