    using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModerator : MonoBehaviour
{
    bool gameEnded = false;
    public float delay = 1f;

    public GameObject endLevel;

    public void CompleteLevel()
    {
        endLevel.SetActive(true);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", delay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
 
