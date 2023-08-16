using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fishingpole : MonoBehaviour
{
    public GameObject fishSpawn;

    public GameObject fishObject;

    public bool inwater = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inwater)
        {
            
            waitTime();
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Equals("WaterProNighttime (11)"))
        {
            inwater = true;
            print(inwater);
            spawnF();
        }
    }
    
    

    IEnumerable waitTime()
    {
        yield return new WaitForSeconds(10);
       
    }

    private void spawnF()
    {
        Vector3 fs = fishSpawn.transform.position;
        Instantiate(fishObject, fs, Quaternion.identity);
    }
}
