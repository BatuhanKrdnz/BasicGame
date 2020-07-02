using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Rigidbody rb;

    public float Force = 1500f;

    // Better for mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -Force * Time.deltaTime);
    }

    
}
 
