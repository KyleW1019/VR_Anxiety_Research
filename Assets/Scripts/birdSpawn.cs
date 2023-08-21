using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdSpawn : MonoBehaviour
{
    public GameObject bird;
    public GameObject spawner;
    private Vector3 birdSpawnPoint;
    
    private void Start()
    {
        birdSpawnPoint = new Vector3(spawner.transform.position.x, spawner.transform.position.y, spawner.transform.position.z);
        Instantiate(bird, birdSpawnPoint, Quaternion.identity);
        
    }


    void Update()
    {
        
    }
}
