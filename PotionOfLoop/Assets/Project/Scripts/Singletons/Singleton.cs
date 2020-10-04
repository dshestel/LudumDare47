using UnityEngine;

namespace PotionOfLoop
{
	public abstract class Singleton<T> where T : class, new()
	{
		#region Fields

		private static T _instance = null;

		#endregion

		#region Properties

		public static T Instance
		{
			get
			{
				if (_instance == null)
				{
#if UNITY_EDITOR
					Debug.LogException(new System.Exception($"{nameof(Singleton<T>)} with type {nameof(T)} is null: go to startup manager and setup"));
#endif
				}

				return _instance;
			}
		}

		#endregion

		protected virtual void Awake()
		{
			if (_instance == null)
			{
				_instance = this as T;
			}
		}

		public void GetInstance()
		{
			if (_instance == null)
			{
				if (_instance == null)
				{
					_instance = new T();
				}
			}
			else
			{
#if UNITY_EDITOR
				Debug.LogException(new System.Exception($"Trying to instance {nameof(Singleton<T>)} duplicate with type {nameof(T)}"));
#endif
			}
		}
	}
}