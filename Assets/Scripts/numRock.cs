using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numRock : MonoBehaviour
{
    public int noRocks = 0;

    public bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (noRocks >= 4 && finished == false)
        {
            print("Thanks for your help");
            finished = true;
        }
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Rock_04 (4)"))
        {
            print("Collided");
            noRocks = noRocks + 1;
        }
        else if (other.gameObject.name.Equals("Rock_04 (3)"))
        {
            print("Collided");
            noRocks = noRocks + 1;
        }
        else if (other.gameObject.name.Equals("Rock_04 (2)"))
        {
            print("Collided");
            noRocks = noRocks + 1;
        }
        else if (other.gameObject.name.Equals("Rock_04"))
        {
            print("Collided");
            noRocks = noRocks + 1;
        }
    }
}
