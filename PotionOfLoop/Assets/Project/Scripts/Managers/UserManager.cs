namespace PotionOfLoop
{
    public class UserManager : GameObjectSingleton<UserManager>
    {
        private User _user = null;

        protected override void Init()
        {
            base.Init();

            if (_user == null)
            {
                _user = new User();
            }
        }

        protected override void DeInit()
        {
            base.DeInit();
        }
    }
}