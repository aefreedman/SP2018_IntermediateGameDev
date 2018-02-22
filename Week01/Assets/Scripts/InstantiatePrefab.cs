using UnityEngine;


public class InstantiatePrefab : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Parent;

    public void Start()
    {
        // var parent = someothergameobject.transform;
        Instantiate(Prefab, new Vector3(10, 2, 3), Quaternion.identity, Parent);
    }
}