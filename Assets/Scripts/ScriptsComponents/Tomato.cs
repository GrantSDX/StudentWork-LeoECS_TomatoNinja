using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptsComponents
{
    public class Tomato : MonoBehaviour
    {
        [SerializeField] private Tomato croppedTomato;

        public void CutThis()
        {
            
            if (croppedTomato == null) return;

            
            var polTomato1 = Instantiate(croppedTomato.gameObject, transform.position, Quaternion.identity);
            polTomato1.AddComponent<CircleCollider2D>();
            polTomato1.AddComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1f) * 200f);
            Destroy(polTomato1, 3f);

            var polTomato2 = Instantiate(croppedTomato.gameObject, transform.position, Quaternion.identity);
            polTomato2.AddComponent<CircleCollider2D>();
            polTomato2.AddComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1f) * 200f);
            Destroy(polTomato2, 3f);

            Destroy(gameObject);

            
        }
        
    }
}