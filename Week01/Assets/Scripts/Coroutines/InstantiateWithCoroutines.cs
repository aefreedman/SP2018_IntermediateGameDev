using System.Collections;
using UnityEngine;

namespace Coroutines
{
    public class InstantiateWithCoroutines : MonoBehaviour
    {
        public GameObject Prefab;
        [Range(2, 1000)] public int InstancesToInstantiate;
        [Range(2, 1000)] public int Groups;

        public void Start()
        {
            if (Groups > InstancesToInstantiate)
                Groups = InstancesToInstantiate;
            if (InstancesToInstantiate / Groups < 2)
                Groups = InstancesToInstantiate / 2;
            StartCoroutine(InstantiateGroups());
        }

        private IEnumerator InstantiateGroups()
        {
            var parent = Instantiate(new GameObject(), Vector3.zero, Quaternion.identity, transform);
            for (var i = 0; i < Groups; i++)
            {
                for (var j = 0; j < InstancesToInstantiate / Groups; j++)
                {
                    var obj = Instantiate(Prefab, VectorExtensions.RandomVector3(-2f, 2f), Quaternion.identity, parent.transform);
                    obj.name = string.Format("#{0:000}", InstancesToInstantiate / Groups * i + j);
                }

                Debug.LogFormat("Instantiated #{0}-#{1} prefab instances out of {2}", InstancesToInstantiate / Groups * i,
                    InstancesToInstantiate / Groups * (i + 1), InstancesToInstantiate);
                yield return new WaitForEndOfFrame();
            }
            Destroy(parent);
        }
    }
}