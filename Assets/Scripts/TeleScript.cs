using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleScript : MonoBehaviour
{

    public float dist;
    public GameObject player;
    public GameObject ChopWoodLocation;
    public bool chopWood;
    // Start is called before the first frame update
    void Start()
    {
        print(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (chopWood && dist < 1)
        {
            
            player.transform.position = ChopWoodLocation.transform.position;
            print(player.transform.position);
            
        }
    }
}
