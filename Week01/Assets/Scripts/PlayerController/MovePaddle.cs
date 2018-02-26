using UnityEngine;

namespace PlayerController
{
    public class MovePaddle : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            // every frame change the transform position according to input

            // get input
//		var up = Input.GetKeyDown(KeyCode.W);
//		var down = Input.GetKeyDown(KeyCode.S);

            var up = Input.GetKey(KeyCode.W);
            var down = Input.GetKey(KeyCode.S);

            var speed = 0.1f;

            // change transform -- these are all equivalent
//		var t = GetComponent<Transform>();
//		var t2 = transform;
//		var t3 = gameObject.transform;

//		transform.position = new Vector3(0, 0, 0);

            if (up)
                transform.Translate(Vector3.up * speed);
            if (down)
                transform.Translate(Vector3.down * speed);
        }
    }
}