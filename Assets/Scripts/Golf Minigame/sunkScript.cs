using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunkScript : MonoBehaviour
{
public int holeNum;

public GameObject golfBall;

public Vector3 nextHole;
    // Start is called before the first frame update
    void Start()
    {
        holeNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("GolfBall (1)"))
        {
            print("ball has sunk");
            holeNum = holeNum + 1;
            //if (holeNum == 2)
            //{
                GameObject.Instantiate(golfBall, nextHole, Quaternion.identity);
            //}
        }
        
    }
    
}
