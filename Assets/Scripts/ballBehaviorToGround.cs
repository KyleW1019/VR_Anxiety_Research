using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviorToGround : MonoBehaviour
{
    public float desiredHeight = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            Vector3 desiredPosition = hit.point + Vector3.up * desiredHeight;

            // Update the ball's position to stay at the desired height above the ground
            transform.position = desiredPosition;
        }
    }
}
