using UnityEngine;

public class PlayerMove : MonoBehaviour { 

    // Rigidbody component
    public Rigidbody rb;

    public float Force = 1500f;
    public float sideForce = 500f;

  
    // Better for mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Force * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameModerator>().EndGame();
        }
    }
}

