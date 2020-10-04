using UnityEngine;
using PotionOfLoop.UI;

namespace PotionOfLoop
{
    public class CameraController : MonoBehaviour
    {
        private Transform _followTarget = null;

        private void Start()
        {
            _followTarget = Player.Instance.gameObject.transform;
        }

        private void LateUpdate()
        {
            //transform.Translate(new Vector3(UIJoystick.instance.H, transform.position.y, UIJoystick.instance.V) * .1f * Time.deltaTime);
        }
    }
}