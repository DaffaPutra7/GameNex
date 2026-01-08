using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject winnerText; 

    public void TriggerGameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
    }

    public void TriggerWin()
    {
        winnerText.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}