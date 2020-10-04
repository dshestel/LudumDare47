using UnityEngine;
using System;

namespace PotionOfLoop
{
    public class Boiler : MonoBehaviour
    {
        [Serializable]
        public struct Ingredient
        {
            public ComponentType component;
            public int componentCount;
        }

        [SerializeField]
        private Ingredient[] _recipe = null;

        private Ingredient[] _receptLeft = null;

        public Ingredient[] Recipe
        {
            get => _recipe;
        }

        private void Start()
        {
            _receptLeft = new Ingredient[_recipe.Length];

            for (int i=0; i < _recipe.Length; i++)
            {
                _receptLeft[i] = _recipe[i];
            }
        }

        public void AddComponentToBoiler(ComponentType componentType, int count)
        {
            for (int i = 0; i < _receptLeft.Length; i++)
            {
                if (_receptLeft[i].component == componentType)
                {
                    _receptLeft[i].componentCount -= count;

                    if (_receptLeft[i].componentCount < 0)
                    {
                        _receptLeft[i].componentCount = 0;
                    }

                    break;
                }
            }
        }
    }
}