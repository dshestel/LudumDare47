using System;

namespace PotionOfLoop
{
    public class Enemy : DamagableUnit
    {
        public static event Action<Enemy> Spawned = delegate { };
    }
}