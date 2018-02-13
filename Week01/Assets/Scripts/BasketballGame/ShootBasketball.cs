using UnityEngine;

namespace BasketballGame
{
    public class ShootBasketball : MonoBehaviour
    {
        // F = m * a
        private Rigidbody _rigidbody;
        [Range(0, 1000f)]
        public float Strength;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
//            _rigidbody.AddTorque(5, 5, 5);
            _rigidbody.AddRelativeForce(Vector3.right * Strength, ForceMode.Force);

        }

        private void Update()
        {
            
            // check for input
            // move a transform by some vector like (1, 0, 0)
            Debug.Log("Update");
        }

        private void FixedUpdate()
        {
//            var dt = Time.deltaTime;
//            _rigidbody.AddRelativeForce(new Vector3(20, 0, 0), ForceMode.Force);
            Debug.Log("Fixed Update");
            
            
        }

        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.name.StartsWith("BasketZone"))
            {
                Debug.LogFormat("I hit {0}", other.gameObject.name);
                return;
            }
            
            Debug.Log("TRIGGERD");
            
            
        }

        private void OnCollisionEnter(Collision other)
        {
            
        }
    }
}