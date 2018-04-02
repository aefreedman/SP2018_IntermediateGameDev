using System.Collections;
using UnityEngine;

namespace Coroutines
{
    public class ProximityCheckCoroutine : MonoBehaviour
    {
        private Renderer _renderer;
        public GameObject Target;

        public float Distance;
        public float PollingFrequency;
        
        // If you google Unity coroutines you'll see suggestions to keep your WaitForSeconds objects
        // as member variables to avoid allocations in the Coroutine such as:
        //        private WaitForSeconds _waitForSeconds;
        // Decompile the WaitForSeconds/WaitForSecondsRealtime class to see why that leads to undesired behavior

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
            StartCoroutine(DoCheck());
        }

        private IEnumerator DoCheck()
        {
            for (;;) // Indefinite loop
            {
                ProximityCheck();
                yield return new WaitForSecondsRealtime(PollingFrequency);
            }
        }

        private void ProximityCheck()
        {
            _renderer.material.color = Vector2.Distance(transform.position, Target.transform.position) < Distance ? Color.red : Color.grey;
        }
    }
}