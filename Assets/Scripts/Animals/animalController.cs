using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalController : MonoBehaviour
{
    public Rigidbody animal;
    public bool square;
    public bool backAndForth;
    public bool triangle;
    void Start()
    {
        animal = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (square)
        {
            transform.Translate(transform.forward * Time.deltaTime, Space.World);
        }
    }
    
}
