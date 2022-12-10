using ScriptsComponents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "BladeInitData", menuName = "ScriptableObjects/BladeInitData", order = 0)]
    public class BladeInitData : ScriptableObject
    {
        [SerializeField] private GameObject bladePrefab;
        public GameObject BladePrefab => bladePrefab;
      
    }

}