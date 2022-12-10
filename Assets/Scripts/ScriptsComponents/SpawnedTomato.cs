using System.Collections;
using UnityEngine;

namespace ScriptsComponents
{
    public class SpawnedTomato : MonoBehaviour
    {
        [SerializeField] private Tomato tomato;

        public void CoroutineTomato()
        {
            StartCoroutine(TomatoIEnumerator());
        }
        private IEnumerator TomatoIEnumerator()
        {
            while (true)
            {
                yield return new WaitForSeconds(2f);
                var spawnTomato = Instantiate(tomato.gameObject, transform.position, Quaternion.identity);
                spawnTomato.AddComponent<CircleCollider2D>();
                spawnTomato.AddComponent<Rigidbody2D>().AddForce(new Vector2(-1f, 1f) * 600f);
            }
        }
    }
}