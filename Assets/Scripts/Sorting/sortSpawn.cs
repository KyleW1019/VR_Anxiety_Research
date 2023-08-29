using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sortSpawn : MonoBehaviour
{
    public GameObject spawner;
    public GameObject lemon;
    public GameObject apple;
    public GameObject peach;
    public GameObject avocado;
    public GameObject strawberry;
    public GameObject pear;
    public GameObject player;
    private new Vector3 spawnPoint;
    public bool spawned = false;
    public int num = -1;
    public float dist;
    
    
    void Start()
    {
        spawnPoint = spawner.transform.position;
    }

    
    void Update()
    {
        playerLocation();
    }

    void spawnShape()
    {
        if (spawned == false)
        {
            num = Random.Range(0, 6);
            
            if (num == 0)
            {
                Instantiate(lemon, spawnPoint, Quaternion.identity);
                spawned = true;
            }
            else if (num == 1)
            {
                Instantiate(apple, spawnPoint, Quaternion.identity);
                spawned = true;
            }
            else if (num == 2)
            {
                Instantiate(peach, spawnPoint, Quaternion.identity);
                spawned = true;
            }
            else if (num == 3)
            {
                Instantiate(avocado, spawnPoint, Quaternion.identity);
                spawned = true;
            }
            else if (num == 4)
            {
                Instantiate(strawberry, spawnPoint, Quaternion.identity);
                spawned = true;
            }
            else if (num == 5)
            {
                Instantiate(pear, spawnPoint, Quaternion.identity);
                spawned = true;
            }
            else
            {
                print("Something went wrong trying to spawn shapes at the sorting mini game!");
                spawned = true;
            }
        }
    }

    void playerLocation()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < 3)
        {
            spawnShape();
        }
    }
}
