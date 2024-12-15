using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore=0;
    public int HighScore;
    public Text scoreText;
    public Text HighscoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;


    [ContextMenu("Increase Score")]
    public void addScore()
    {

        if (!gameOverScreen.activeSelf)
        {
            playerScore = playerScore + 1;

            scoreText.text = playerScore.ToString();
            dingSFX.Play();
        }

    }

    public void restrartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        HighscoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");

    }

    public void GameOver()
    {
        if (playerScore > PlayerPrefs.GetInt("HighScore"))
        {
            SetHighScore(playerScore);
            PlayerPrefs.SetInt("HighScore", playerScore);
            HighscoreText.text = "High Score: " + playerScore;
        }
        gameOverScreen.SetActive(true);

    }

    public void SetHighScore(int New)
    {

        HighScore=New;

    }

    public void console()
    {
        Debug.Log( "deneme");
    }


}
