using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTree : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject log;
    public GameObject tree;
    public GameObject axe;
    public int numberOfSwings;
    public bool logSpawned = false;
    void Start()
    {

        numberOfSwings = 0;
        tree = this.gameObject;
        //new Vector3(tree.transform.position.x, tree.transform.position.y + 1, tree.transform.position.z);
    }

    // Update is called once per frame
    private void Update()
    {
        if (numberOfSwings > 1)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            if (logSpawned == false)
            {
                GameObject.Instantiate(log, new Vector3(tree.transform.position.x, tree.transform.position.y + 1, tree.transform.position.z), tree.transform.rotation);
                logSpawned = true;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Cube"))
        {
            numberOfSwings = numberOfSwings + 1;
        }
    }
}
