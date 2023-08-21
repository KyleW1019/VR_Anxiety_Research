using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdSpawn : MonoBehaviour
{
    public GameObject bird;
    public GameObject spawner;
    private int numBirds;
    
    private Vector3 birdSpawnPoint;
    private Vector3 birdSpawnPoint2;
    private Vector3 birdSpawnPoint3;
    private Vector3 birdSpawnPoint4;
    private Vector3 birdSpawnPoint5;

    private void Start()
    {
        
        birdSpawnPoint = new Vector3(spawner.transform.position.x, spawner.transform.position.y,
            spawner.transform.position.z);
        birdSpawnPoint2 = new Vector3(spawner.transform.position.x - 1, spawner.transform.position.y,
            spawner.transform.position.z - 1);
        birdSpawnPoint3 = new Vector3(spawner.transform.position.x + 1, spawner.transform.position.y,
            spawner.transform.position.z - 1);
        birdSpawnPoint4 = new Vector3(spawner.transform.position.x - 2, spawner.transform.position.y,
            spawner.transform.position.z - 2);
        birdSpawnPoint5 = new Vector3(spawner.transform.position.x + 2, spawner.transform.position.y,
            spawner.transform.position.z - 2);
        
        StartCoroutine(spawnDelay(10));
    }


    void Update()
    {
        
    }

    void spawnBird()
    {
        numBirds = Random.Range(1, 6);
        if (numBirds == 1)
        {
            Instantiate(bird, birdSpawnPoint, Quaternion.identity);
        }
        else if (numBirds == 2)
        {
            Instantiate(bird, birdSpawnPoint, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint2, Quaternion.identity);
        }
        else if (numBirds == 3)
        {
            Instantiate(bird, birdSpawnPoint, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint2, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint3, Quaternion.identity);
        }
        else if (numBirds == 4)
        {
            Instantiate(bird, birdSpawnPoint, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint2, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint3, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint4, Quaternion.identity);
        }
        else if (numBirds == 5)
        {
            Instantiate(bird, birdSpawnPoint, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint2, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint3, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint4, Quaternion.identity);
            Instantiate(bird, birdSpawnPoint5, Quaternion.identity);
        }
        
        else
        {
            print("There was a problem spawning the Birds in the birdSpawn script");
        }
        
    }

    IEnumerator spawnDelay(float d)
    {
        while (true)
        {
            
            this.spawnBird();
            yield return new WaitForSecondsRealtime(d);
        }

    }

}
