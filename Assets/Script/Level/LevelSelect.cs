using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("HalamanUtama");
    }
}
