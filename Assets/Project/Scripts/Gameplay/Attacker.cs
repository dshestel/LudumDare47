using System.Collections;
using UnityEngine;

namespace PotionOfLoop
{
    public class Attacker : MonoBehaviour
    {
        [SerializeField]
        private int _damage = 1;
        [SerializeField]
        private float _range = 2f;
        [SerializeField]
        private float _shotDelay = 0.4f;

        [SerializeField]
        private Transform _rotateRoot = null;

        private float _animLength = 0.4f;
        private float _nextShotTime = 0f;

        protected DamagableUnit _target = null;

        public bool InRange
        {
            get => !ReferenceEquals(_target, null) && Vector3.Distance(transform.position, _target.transform.position) < _range;
        }

        public bool CanAttack
        {
            get => _nextShotTime < Time.time && InRange;
        }

        public void Setup(int damage, float range, float shotDelay)
        {
            _damage = damage;
            _range = range;
            _shotDelay = shotDelay;
        }

        private void Update()
        {
            if (CanAttack)
            {
                TryShot();
            }
        }

        protected virtual void TryShot()
        {
            
        }

        protected virtual void Shot()
        {
            _nextShotTime = Time.time + _shotDelay;

            StartCoroutine(ShotCor());
        }

        private IEnumerator ShotCor()
        {
            var endAnimationTime = Time.time + _animLength;

            while (Time.time < endAnimationTime)
            {
                _rotateRoot.LookAt(_target.transform, Vector3.up);

                yield return null;
            }

            _target.TakeDamage(_damage);
        }
    }
}