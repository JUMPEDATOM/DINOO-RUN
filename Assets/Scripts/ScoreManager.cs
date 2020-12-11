using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public int Round = 100;
    private float score;

    void Start ()
    {
        highScoreText.text = "HI 000" + PlayerPrefs.GetFloat("High Score", 0).ToString("f0");
    }
    void Update()
    {
        score = Time.timeSinceLevelLoad * 10;
        scoreText.text = "000" + score.ToString("f0");

        if((int)score ==  Round)
        {
            FindObjectOfType<AudioManager>().Play("Player-Score");
            Round += 100;
        }
    }

    public void HighScore ()
    {
        if (score > PlayerPrefs.GetFloat("High Score", 0))
        {
            PlayerPrefs.SetFloat("High Score", score);
        }
    }
}
