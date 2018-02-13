using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Vector3 startDirection;

    // Use this for initialization
    void Start()
    {
        startDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(startDirection);
        
        
        var myNewVector = Vector3.one;
        var myVeryNewVector = Vector3.one;

        myNewVector = new Vector3(1, 1, 1);
        
        var anotherVector = new Vector3(3411, 340, 234);

        var myGameObject = new GameObject();
        var thisIsTheSameGameObject = myGameObject;
        
        myGameObject.transform.Translate(1, 0, 0);
    }
}