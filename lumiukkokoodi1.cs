using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumiukkokoodi1 : MonoBehaviour {


    public float speed = 0.005f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(-19, 4, 0);
        pointB = new Vector3(55, 4, 0);
    }

    void Update()
    {
        
        float time = Time.time * speed;
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
