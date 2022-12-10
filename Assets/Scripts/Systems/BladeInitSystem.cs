using UnityEngine;
using Leopotam.Ecs;
using ScriptableObjects;
using Components;

namespace Systems
{
    public class BladeInitSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        private BladeInitData _bladeInitData;
        public void Init()
        {
            var blade = _world.NewEntity();

            var spawnedBlade = GameObject.Instantiate(_bladeInitData.BladePrefab);

            ref var bladeComponent = ref blade.Get<BladeComponent>();
            bladeComponent.Transform = spawnedBlade.transform;
            bladeComponent.Rigidbody2D = spawnedBlade.AddComponent<Rigidbody2D>();
            bladeComponent.Rigidbody2D.gravityScale = 0f;
            bladeComponent.CircleCollider2D = spawnedBlade.AddComponent<CircleCollider2D>();
            

        }
    }
}