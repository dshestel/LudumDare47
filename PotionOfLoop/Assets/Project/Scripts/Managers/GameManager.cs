using System;
using System.Collections;
using UnityEngine;

namespace PotionOfLoop
{
    public class GameManager : MonoBehaviour
    {
        public static event Action<int> CurrencyIncomed = delegate { };

        [SerializeField]
        private Camera _camera = null;

        private static GameManager _instance = null;

        public static GameManager Instance => _instance;

        private Coroutine _currencyIncomeCor = null;

        private void Awake()
        {
            _instance = this;
        }

        private void Start()
        {
            if (_currencyIncomeCor != null)
            {
                StopCoroutine(_currencyIncomeCor);
                _currencyIncomeCor = null;
            }

            _currencyIncomeCor = StartCoroutine(CurrencyIncomeCor());
        }

        private void OnEnable()
        {

        }

        private void OnDisable()
        {

        }

        private IEnumerator CurrencyIncomeCor()
        {
            var waiter = new WaitForSeconds(1f);

            while (true)
            {
                yield return waiter;

                CurrencyIncomed(1);
            }
        }
    }
}