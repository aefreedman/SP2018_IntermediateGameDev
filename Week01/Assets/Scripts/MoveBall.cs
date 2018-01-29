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
    }
}