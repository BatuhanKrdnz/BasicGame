using UnityEngine;

public class PlayerCollision : MonoBehaviour { 

    public PlayerMove movement;
    public GameModerator gameModerator;

    public void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            FindObjectOfType<GameModerator>().EndGame();

        }

        else if (collision.collider.tag == "End")
        {
            FindObjectOfType<GameModerator>().CompleteLevel();
        }
    }

}
