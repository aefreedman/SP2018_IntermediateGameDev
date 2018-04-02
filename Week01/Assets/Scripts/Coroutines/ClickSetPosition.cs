using UnityEngine;

namespace Coroutines
{
    /// <inheritdoc />
    /// <summary>
    /// This behavior uses the mouse to change the MoveProperty Target property and trigger the other behavior's coroutine
    /// </summary>
    [RequireComponent(typeof(MoveProperty))]
    public class ClickSetPosition : MonoBehaviour
    {
        private MoveProperty _coroutineScript;
        public GameObject MovementArea;

        private void Awake()
        {
            _coroutineScript = GetComponent<MoveProperty>();
        }

        //Requires "floor" collider to raycast against
        // This Unity event function only triggers when the mouse is over the collider on the SAME GameObject that
        // the script is on (the official documentation isn't clear about that)
        private void OnMouseDown()
        {
            MoveToCollision2D();
//            MoveToScreenPosition2D();
        }

        private void OnMouseDrag()
        {
            MoveToCollision2D();
        }

        private void MoveToCollision()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Physics.Raycast(ray, out hit);

            if (hit.collider.gameObject != MovementArea)
                return;
            var newTarget = hit.point + new Vector3(0, 0.5f, 0);
            _coroutineScript.Target = newTarget;
        }

        private void MoveToCollision2D()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (!Physics.Raycast(ray, out hit)
            ) // Use the bool return from Raycast to perform an early escape or you can get a NullReferenceException when the raycast fails
                return;
            // You need to click inside of the gameobject while ALSO within the movement area
            if ((MovementArea != null && hit.collider.gameObject != MovementArea))
                return;
            var newTarget = new Vector3(hit.point.x, hit.point.y, 0);
            _coroutineScript.Target = newTarget;
        }

        private void MoveToScreenPosition2D()
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _coroutineScript.Target = new Vector3(mousePos.x, mousePos.y, 0);
            Debug.LogFormat("Moving player to {0}", mousePos);
        }
    }
}