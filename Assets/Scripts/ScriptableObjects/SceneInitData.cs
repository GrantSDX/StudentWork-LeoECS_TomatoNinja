using System.Collections;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "SceneInitData", menuName = "ScriptableObjects/SceneInitData", order = 0)]
    public class SceneInitData : ScriptableObject
    {
        [SerializeField] private GameObject kitchenPrefab;
        public GameObject KitchenPrefab => kitchenPrefab;

        [SerializeField] private GameObject spawnedTomato;
        public GameObject SpawnedTomato => spawnedTomato;

    }
}