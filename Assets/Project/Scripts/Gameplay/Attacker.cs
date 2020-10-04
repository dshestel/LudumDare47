using UnityEngine;
using PotionOfLoop.UI;
using System.Collections.Generic;

namespace PotionOfLoop
{
    public class Attacker : MonoBehaviour
    {
		private int _damage = 1;
		private float _range = 2f;
		private float _shotDelay = 0.1f;

		private float _nextShotTime = 0f;

        private Enemy _enemy = null;

		public void Setup(int damage, float range, float shotDelay)
        {
			_damage = damage;
			_range = range;
			_shotDelay = shotDelay;
		}

        private void Update()
        {
			if (Time.time > _nextShotTime)
			{
				if (UIJoystick.Instance != null)
				{
					if (!UIJoystick.Instance.IsDragging)
					{
                        TryShot();
                    }
				}
			}
        }

		private void TryShot()
        {
			var enemies = LevelManager.Instance.Enemies;

            _enemy = GetNearestEnemy(enemies, transform.position);

            if (_enemy != null)
            {
                if (Vector3.Distance(_enemy.transform.position, transform.position) <= _range)
                {
                    Shot();
                }
            }
        }

        private void Shot()
        {
            _nextShotTime = Time.time + _shotDelay;

            _enemy.TakeDamage(_damage);
        }

        private Enemy GetNearestEnemy(List<Enemy> enemies, Vector3 origin)
        {
			int length = enemies.Count;

            if (length == 0)
            {
                return null;
            }

            Enemy nearest = null;
            float distance = float.MaxValue;
            for (int i = length - 1; i >= 0; i--)
            {
                var targetable = enemies[i];
                if (targetable == null || targetable.IsDead)
                {
                    enemies.RemoveAt(i);
                    continue;
                }
                float currentDistance = (origin - targetable.transform.position).sqrMagnitude;
                if (currentDistance < distance)
                {
                    distance = currentDistance;
                    nearest = targetable;
                }
            }

            return nearest;
        }
    }
}