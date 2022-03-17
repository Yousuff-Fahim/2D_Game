using UnityEngine;

public class MissionComplete : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagManager.PLAYER_TAG))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Mission Complete");
        }
    }
}
