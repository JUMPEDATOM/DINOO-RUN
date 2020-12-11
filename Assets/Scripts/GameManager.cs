using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public void EndGame()
    {
        FindObjectOfType<AudioManager>().Play("Player-Hit");
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        FindObjectOfType<ScoreManager>().HighScore();
    }

    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Ground.golobalSpeed = 7.5f;
        Time.timeScale = 1f;
    }
}
