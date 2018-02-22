using UnityEngine;

public class DetectWall : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        var raycastHit = new RaycastHit();
        var distance = 10f;

        var layerMask = LayerMask.GetMask("Game");
        
        //invert layer mask
        layerMask = ~layerMask;

        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        if (!Physics.Raycast(transform.position, transform.forward, out raycastHit, distance, layerMask)) return;
        
//            Debug.Log("Hit something!");
        if (raycastHit.collider.gameObject.name.ToLower().StartsWith("wall"))
        {
            Debug.Log(raycastHit.collider.gameObject.name);
        }
    }
}