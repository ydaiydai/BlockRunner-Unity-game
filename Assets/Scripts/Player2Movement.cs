using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public Rigidbody rb2;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Fixed update for calculating physics
    void FixedUpdate()
    {
        // Add a forward force
        rb2.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("right"))
        {
            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
            rb2.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left"))
        {
            //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            rb2.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb2.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
