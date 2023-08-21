using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterDialog : MonoBehaviour
{
    public float dist;
    public bool displayDialog;
    public GameObject player;
    public CutTree CutTreeScript;
    public GameObject diaglogBox;
    public GameObject dialogBox2;
    public numTrees nt;
    

    
    
    
    public bool secondBool;

    public int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        displayDialog = false;
        diaglogBox.GetComponent<MeshRenderer>().enabled = false;
        secondBool = false;
        dialogBox2.GetComponent<MeshRenderer>().enabled = false;
        //print(CutTreeScript.numberOfSwings);

       // CutTree CutTreeScript;
}

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < 3 && secondBool != true)
        {
            displayDialog = true;
        }
        else
        {
            displayDialog = false;
        }

        if (displayDialog)
        {
            diaglogBox.GetComponent<MeshRenderer>().enabled = true;
        }

        if (nt.numTreesCut >= 10)
        {
            secondBool = true;
        }

        if (secondBool)
        {
            displayDialog = false;
            diaglogBox.GetComponent<MeshRenderer>().enabled = false;
            dialogBox2.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
