using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    private GameObject fruitObject;
    public bool lemon;
    public bool apple;
    public bool peach;
    public bool avocado;
    public bool strawberry;
    public bool pear;
    void Start()
    {
        fruitObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Crate") && lemon)
        {
            fruitObject.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else if (other.gameObject.tag.Equals("Crate") && apple)
        {
            fruitObject.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else if (other.gameObject.tag.Equals("Crate") && peach)
        {
            fruitObject.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else if (other.gameObject.tag.Equals("Crate") && avocado)
        {
            fruitObject.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else if (other.gameObject.tag.Equals("Crate") && strawberry)
        {
            fruitObject.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else if (other.gameObject.tag.Equals("Crate") && pear)
        {
            fruitObject.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            print("Something went wrong in the fruit script");
        }
    }
}
