using System.Collections.Generic;
using UnityEngine;

namespace PotionOfLoop
{
    public class LevelManager : MonoBehaviour
    {
        private static LevelManager _instance = null;

        private List<Enemy> _enemies = new List<Enemy>();

        public static LevelManager Instance
        {
            get => _instance;
        }

        public List<Enemy> Enemies
        {
            get => _enemies;
        }

        private void OnEnable()
        {
            Enemy.Spawned += Enemy_Spawned;
            DamagableUnit.Died += DamagableUnit_Died;
        }

        private void OnDisable()
        {
            Enemy.Spawned -= Enemy_Spawned;
            DamagableUnit.Died -= DamagableUnit_Died;
        }

        private void Enemy_Spawned(DamagableUnit enemy)
        {
            if (enemy is Enemy)
            {
                _enemies.Add((Enemy)enemy);
            }
        }

        private void DamagableUnit_Died(DamagableUnit damagableUnit)
        {
            if (damagableUnit is Enemy)
            {
                _enemies.Remove((Enemy)damagableUnit);
            }
        }
    }
}