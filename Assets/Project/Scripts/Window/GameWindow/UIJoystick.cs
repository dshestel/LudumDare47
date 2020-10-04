using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace PotionOfLoop.UI
{
    public class UIJoystick : MonoBehaviour, IDragHandler, IEndDragHandler
	{
		public static UIJoystick Instance = null;

		public float _speed = 6f;

		[Tooltip("the joystick radius ")]
		public float R = 90f;

		private float _r;

		private Vector2 centerPos;

		private RectTransform _transfrorm = null;

		public float _halfScreenWidth = 0;
		public float _halfScreenHeight = 0;
		private float _h;
		private float _v;

		public float H
		{
			get { return _h; }
		}
		public float V
		{
			get { return _v; }
		}

		public bool IsDragging
        {
			get;
			private set;
        }

		private void Awake()
        {
			Instance = this;
        }

		private void Start()
		{
			_halfScreenWidth = Screen.width / 2;
			_halfScreenHeight = Screen.height / 2;

			_r = 1f * Screen.width / 960f * R; //this to calculate the scale of screen

			_transfrorm = GetComponent<RectTransform>();
			centerPos = _transfrorm.anchoredPosition;
		}

		private void SetHAndF(Vector2 pos)
		{ 
			Vector2 diff = pos - centerPos;
			float distance = diff.magnitude;

			if (distance > _r)
			{
				pos = centerPos + diff / distance * _r;
			}

			_transfrorm.anchoredPosition = pos;

			Vector2 move = pos - centerPos;

			_h = move.x;
			_v = move.y;
		}

		public void OnDrag(PointerEventData data)
		{
			IsDragging = true;

			Vector2 newPos = new Vector2(data.position.x - _halfScreenWidth, data.position.y - _halfScreenHeight);

			SetHAndF(newPos);
		}

		public void OnEndDrag(PointerEventData data)
		{
			_transfrorm.anchoredPosition = centerPos;
			SetHAndF(centerPos);
			IsDragging = false;
		}
    }
}