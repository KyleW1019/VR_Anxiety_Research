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

    public GameObject empty1;
    public GameObject empty2;
    public GameObject empty3;
    public GameObject empty4;
    public GameObject empty5;
    public GameObject empty6;
    public GameObject empty7;
    public GameObject empty8;
    public GameObject empty9;
    private int randomInt;
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
            randomInt = Random.Range(1, 10);
            print("THE RANDOM INT IS: " + randomInt);
            if (randomInt == 1)
            {
                Instantiate(rock, empty1.transform.position, Quaternion.Euler(0,0,0));
            }
            else if (randomInt == 2)
            {
                Instantiate(rock, empty2.transform.position, Quaternion.Euler(0,0,0));
            }
            else if (randomInt == 3)
            {
                Instantiate(rock, empty3.transform.position, Quaternion.Euler(0,0,0));
            }
            else if (randomInt == 4)
            {
                Instantiate(rock, empty4.transform.position, Quaternion.Euler(0,0,0));
            }
            else if (randomInt == 5)
            {
                Instantiate(rock, empty5.transform.position, Quaternion.Euler(0,0,0));
            }
            else if (randomInt == 6)
            {
                Instantiate(rock, empty6.transform.position, Quaternion.Euler(0,0,0));
            }
            else if (randomInt == 7)
            {
                Instantiate(rock, empty7.transform.position, Quaternion.Euler(0,0,0));
            }
            else if (randomInt == 8)
            {
                Instantiate(rock, empty8.transform.position, Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(rock, empty9.transform.position, Quaternion.Euler(0,0,0));
            }
        }
    }
}
