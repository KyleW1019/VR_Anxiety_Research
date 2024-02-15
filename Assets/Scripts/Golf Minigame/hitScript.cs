using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitScript : MonoBehaviour
{
    // Start is called before the first frame update
    public playerScore ps;
    public GameObject ball;
    public GameObject club;
    private Rigidbody ball_s;
    private int force = 5;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Club"))
        {
            //print("Collided with the club");
            ps.pscore = ps.pscore + 1;
            print(ps.pscore);

            //club.transform.localRotation.eulerAngles;
            //ball.transform.rotation = club.transform.rotation;
           // ball.transform.Translate(-Vector3.forward, Space.Self);
           ball_s = ball.GetComponent<Rigidbody>();
            ball_s.transform.rotation = club.transform.rotation;
            //ball_s = ball.GetComponent<Rigidbody>();
                ball_s.AddForce(-Vector3.forward * 100);
                //WaitForSeconds();
                //ball_s.AddForce(-Vector3.forward *-force);
                //ball_s.AddRelativeForce(-Vector3.forward * 100);
                
        }
        //else if (other.gameObject.name.Equals("GolfHole (1)"))
        else if(other.CompareTag("Hole"))
        {
            ball.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        //print("club");
    }
}
