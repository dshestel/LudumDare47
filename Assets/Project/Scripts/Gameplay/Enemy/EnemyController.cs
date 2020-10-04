using UnityEngine;
using UnityEngine.AI;
               //tha 
namespace PotionOfLoop
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField]
        private NavMeshAgent _navMesh = null;

        [SerializeField]
        private EnemyAttacker _attacker = null;
        
        [SerializeField]
        private float _followDistance = 1.0f;

        private Player _target = null;

        private float _searchDelay = 0.05f;
        private float _nextSearchTime = 0f;

        private void Start()
        {
            _target = Player.Instance;
        }

        private void Update()
        {
            if (_nextSearchTime < Time.time)
            {
                float distance = Vector3.Distance(transform.position, _target.transform.position);

                if (distance < _followDistance && !_attacker.InRange)
                {
                    //_navMesh.isStopped = false;
                    //_navMesh.SetDestination(_target.transform.position);
                }
                else if (_attacker.CanAttack)
                {
                    //_navMesh.isStopped = true;

                    //_attacker.Shot();
                }
            }
        }
    }
}