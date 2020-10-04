using UnityEngine;
using System.Collections.Generic;

namespace PotionOfLoop
{
    public class PlayerAttacker : Attacker
    {
        protected override void TryShot()
        {
            base.TryShot();

            var enemies = LevelManager.Instance.Enemies;

            _target = GetNearestEnemy(enemies, transform.position);

            if (_target != null)
            {
                if (InRange)
                {
                    Shot();
                }
            }
        }

        private DamagableUnit GetNearestEnemy(List<Enemy> enemies, Vector3 origin)
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