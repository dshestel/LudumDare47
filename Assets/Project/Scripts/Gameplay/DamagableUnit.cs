using System;
using UnityEngine;

namespace PotionOfLoop
{
    public class DamagableUnit : MonoBehaviour
    {
        public static Action<DamagableUnit> Died = delegate { };

        protected int _health = 0;

        [SerializeField]
        protected int _currentHp = 0;

        public bool IsDead
        {
            get;
            private set;
        } = false;

        public void Setup(int health = 10)
        {
            _health = health;
            _currentHp = health;
        }

        public void TakeDamage(int damage)
        {
            _currentHp -= damage;

            if (_currentHp <= 0)
            {
                IsDead = true;
                Died(this);
            }
        }
    }
}