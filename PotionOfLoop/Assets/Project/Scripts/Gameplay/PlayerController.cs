using UnityEngine;
using PotionOfLoop.UI;

namespace PotionOfLoop
{
	public class PlayerController : MonoBehaviour
	{
		[SerializeField]
		private float speed = .1f;

		[SerializeField]
		private Animator _playerAnimator = null;

		void Update()
		{
			if (UIJoystick.Instance != null)
			{
				if (UIJoystick.Instance.IsDragging)
				{
					transform.Translate(new Vector3(UIJoystick.Instance.H, 0f, UIJoystick.Instance.V) * speed * Time.deltaTime);

					transform.LookAt(transform.position + new Vector3(UIJoystick.Instance.H, 0f, UIJoystick.Instance.V));

				}
				else
				{

				}

				//if (JoystickFire.instance.Fire)
				//{
				//	Debug.Log("fire");
				//}
			}
		}
	}
}