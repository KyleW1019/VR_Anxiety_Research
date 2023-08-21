using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numTrees : MonoBehaviour
{
    public int numTreesCut = 0;
    
   

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Tree"))
        {
            numTreesCut = numTreesCut + 1;
            print(numTreesCut);
        }
    }
}
