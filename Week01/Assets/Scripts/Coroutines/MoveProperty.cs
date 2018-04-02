using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

namespace Coroutines
{
    /// <inheritdoc />
    /// <summary>
    /// The MoveProperty uses a coroutine to move this GameObject's transform to the position of the Target vector any time the property changes
    /// </summary>
    public class MoveProperty : MonoBehaviour
    {
        public float Smoothing = 7f;

        public Vector3 Target
        {
            [UsedImplicitly] get { return _target; }
            set
            {
                _target = value;

                StopCoroutine("Movement");
                StartCoroutine("Movement", _target);
            }
        }

        private Vector3 _target;


        private IEnumerator Movement(Vector3 target)
        {
            while (Vector3.Distance(transform.position, target) > 0.05f)
            {
                transform.position = Vector3.Lerp(transform.position, target, Smoothing * Time.deltaTime);

                yield return null;
            }
        }
    }
}