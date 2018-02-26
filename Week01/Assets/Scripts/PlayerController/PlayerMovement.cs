using UnityEngine;

namespace PlayerController
{
    public class PlayerMovement : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            float yAxisRotation = 1.5f;
            float movementSpeed = 10f;

            // MOVEMENT INPUT <WASD + SPACEBAR>

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * Time.deltaTime * movementSpeed;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= transform.right * Time.deltaTime * movementSpeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= transform.forward * Time.deltaTime * movementSpeed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += transform.right * Time.deltaTime * movementSpeed;
            }

            // ROTATION INPUT <ARROW KEYS>

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Transform>().eulerAngles += new Vector3(0f, -yAxisRotation, 0f);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Transform>().eulerAngles += new Vector3(0f, yAxisRotation, 0f);
            }

       
        }
    }
}