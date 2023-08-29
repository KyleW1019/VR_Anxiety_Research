using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class sortFruit : MonoBehaviour
{
    public GameObject crate;
    public sortSpawn sortSpawn;
    public bool lemon;
    public bool apple;
    public bool peach;
    public bool avocado;
    public bool strawberry;
    public bool pear;
    void Start()
    {
        crate = this.gameObject;
    }

    
    

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name.Equals("_______") && lemon)
        if(other.gameObject.tag.Equals("Lemon") && lemon)
        {
            print("Congrats you sorted the lemon into the Lemon Crate");
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            spawnUpdate();
        }
        else if (other.gameObject.tag.Equals("Apple") && apple)
        {
            print("Congrats you sorted the apple into the apple Crate");
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            spawnUpdate();
        }
        else if (other.gameObject.tag.Equals("Avocado") && avocado)
        {
            print("Congrats you sorted the avocado into the avocado Crate");
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            spawnUpdate();
        }
        else if (other.gameObject.tag.Equals("Pear") && pear)
        {
            print("Congrats you sorted the pear into the pear Crate");
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            spawnUpdate();
        }
        else if (other.gameObject.tag.Equals("Peach") && peach)
        {
            print("Congrats you sorted the peach into the peach Crate");
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            spawnUpdate();
        }
        else if (other.gameObject.tag.Equals("Strawberry") && strawberry)
        {
            print("Congrats you sorted the strawberry into the strawberry Crate");
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            spawnUpdate();
        }
        
        
    }

    void spawnUpdate()
    {
        sortSpawn.spawned = false;
    }
}
