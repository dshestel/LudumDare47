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

		[SerializeField]
		private Transform _rotateRoot = null;

		void Update()
		{
			if (UIJoystick.Instance != null)
			{
				if (UIJoystick.Instance.IsDragging)
				{
					_playerAnimator.SetBool("IsRunning", true);

					transform.Translate(new Vector3(UIJoystick.Instance.H, 0f, UIJoystick.Instance.V) * speed * Time.deltaTime);

					_rotateRoot.LookAt(transform.position + new Vector3(UIJoystick.Instance.H, 0f, UIJoystick.Instance.V));
				}
                else
                {
					_playerAnimator.SetBool("IsRunning", false);
				}
			}
		}
	}
}