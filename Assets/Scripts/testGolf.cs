using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testGolf : MonoBehaviour
{
    public float hitForce = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            Hitball(other.gameObject);
        }
    }
    void Hitball(GameObject ball)
    {
        Vector3 hitDirection = ((ball.transform.position - transform.position) * -90).normalized;
        //Vector3 hitDirection = transform.forward;
        // Get the Rigidbody component of the ball
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

        // Apply force to the ball in the direction from the club to the ball
        ballRigidbody.AddForce(hitDirection * hitForce, ForceMode.Impulse);
    }
}
