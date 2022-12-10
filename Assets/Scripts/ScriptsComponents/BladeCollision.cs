using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptsComponents
{
    public class BladeCollision : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.TryGetComponent(out Tomato tomato))
            {
                
                tomato.CutThis();
            }
        }
    }
}