using UnityEngine;

namespace Instantiation
{
    public class InstantiatePrefab : MonoBehaviour
    {
        public GameObject Prefab;
        public Transform Parent;

        public void Start()
        {
            Instantiate(Prefab, new Vector3(10, 2, 3), Quaternion.identity, Parent);
        }
    }
}