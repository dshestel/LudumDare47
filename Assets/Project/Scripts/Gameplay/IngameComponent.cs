using UnityEngine;

namespace PotionOfLoop
{
    public class IngameComponent : MonoBehaviour
    {
        [SerializeField]
        private ComponentType? _componentType;

        private void Setup(ComponentType? componentType)
        {
            _componentType = componentType;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Player>() != null)
            {
                //new Reward(new RewardItem[] { new RewardItem(componentType: _componentType, 1) });
            }
        }
    }
}