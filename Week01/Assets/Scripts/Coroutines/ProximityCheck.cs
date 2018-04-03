using UnityEngine;

namespace Coroutines
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class ProximityCheck : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Renderer _renderer;
        public GameObject Target;
        public bool UsePhysicsDetection;
        public float Distance;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _renderer = GetComponent<Renderer>();
        }

        private void Update()
        {
            if (!UsePhysicsDetection)
                _renderer.material.color = Vector2.Distance(transform.position, Target.transform.position) < Distance ? Color.red : Color.grey;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            _renderer.material.color = Color.red;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            _renderer.material.color = Color.gray;
        }
    }
}