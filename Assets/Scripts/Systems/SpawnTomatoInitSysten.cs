using System.Collections;
using UnityEngine;
using Leopotam.Ecs;
using ScriptableObjects;
using Components;
using ScriptsComponents;

namespace Systems
{
    public class SpawnTomatoInitSysten : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        private SceneInitData _sceneInitData;
        public void Init()
        {
            var sceneKitchen = _world.NewEntity();
            var spawnedKitchen = GameObject.Instantiate(_sceneInitData.KitchenPrefab);
            ref var kitchenComponent = ref sceneKitchen.Get<KitchenComponent>();
            kitchenComponent.Transform = spawnedKitchen.GetComponent<Transform>();
            kitchenComponent.SpriteRenderer = spawnedKitchen.GetComponent<SpriteRenderer>();

            var spawnTomato = _world.NewEntity();
            var spawnTommatog = GameObject.Instantiate(_sceneInitData.SpawnedTomato);
            ref var tomatoComponent = ref spawnTomato.Get<TomatoComponent>();
            tomatoComponent.SpawnedTomato = spawnTommatog.GetComponent<SpawnedTomato>();
            tomatoComponent.SpawnedTomato.CoroutineTomato();


        }

        
    }
}