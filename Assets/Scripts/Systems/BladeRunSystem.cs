using System.Collections;
using UnityEngine;
using Leopotam.Ecs;
using Components;

namespace Systems
{
    public class BladeRunSystem : IEcsRunSystem
    {
        private EcsFilter<BladeComponent> _filter;
        public void Run()
        {
            foreach (var i in _filter)
            {
                var blade = _filter.Get1(i);
                if (Input.touchCount > 0)
                {
                    var touch = Input.GetTouch(0);
                    if(touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
                    blade.Transform.position = Camera.main.ScreenToWorldPoint(touch.position);
                }
            }
        }
    }
}