using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LoadLevel1()
    {
        Debug.Log("Tombol Level 1 Ditekan! Mencoba masuk MainGames...");
        SceneManager.LoadScene("MainGames");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("MainGames");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("MainGames [ Level 2 ]");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("HalamanUtama");
    }
}
