using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdbehavior : MonoBehaviour
{
    public Rigidbody birdrb;
    public float speed;
    private void Start()
    {
        birdrb = GetComponent<Rigidbody>();
        
        speed = 50.0f;
    }

    private void Update()
    {
        //birdrb.AddForce(Vector3.forward * speed);     
        transform.Translate(transform.forward * Time.deltaTime, Space.World);
        
    }
}
