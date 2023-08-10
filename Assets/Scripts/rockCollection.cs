using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockCollection : MonoBehaviour
{
    public int numberOfRocks = 0;
    public GameObject rock;
    public GameObject crate;
    public bool b = true;
    public bool isColl = false;
    void Start()
    {
        rock = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //if (numberOfRocks >= 5 && b == true)
        //{
          //  print("Thank you for collecting 5 rocks out of my garden!");
            //b = false;
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Box_01"))
        {
            print("Collided");
            numberOfRocks = numberOfRocks + 1;
            rock.gameObject.GetComponent<MeshRenderer>().enabled = false;
            isColl = true;
            isColl = false;
        }
    }
}
