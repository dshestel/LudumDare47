using UnityEngine;

namespace PotionOfLoop.UI
{
    public class Window : MonoBehaviour
    {
        protected virtual void Start()
        {

        }

        protected virtual void OnEnable()
        {
            User.CurrencyChanged += User_CurrencyChanged;
        }

        protected virtual void OnDisable()
        {
            User.CurrencyChanged -= User_CurrencyChanged;
        }

        public virtual void Prepare()
        {

        }

        public virtual void OnShow()
        {

        }

        public virtual void Refresh()
        {

        }

        public virtual void OnHide()
        {

        }

        private void User_CurrencyChanged()
        {
            Debug.Log($"{nameof(Refresh)}");

            Refresh();
        }
    }
}