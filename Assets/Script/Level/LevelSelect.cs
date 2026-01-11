using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    [Header("Tombol Level")]
    public Button level2Button;
    public Button level3Button; 

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        if (level2Button != null)
        {
            level2Button.interactable = (levelReached >= 2);
        }

        if (level3Button != null)
        {
            level3Button.interactable = (levelReached >= 3);
        }
    }

    public void LoadLevel1()
    {
        Debug.Log("SAYA MENEKAN TOMBOL LEVEL 1");
        SceneManager.LoadScene("MainGames");
    }

    public void LoadLevel2()
    {
        Debug.Log("SAYA MENEKAN TOMBOL LEVEL 2");
        SceneManager.LoadScene("MainGames [ Level 2 ]");
    }

    public void LoadLevel3()
    {
        Debug.Log("SAYA MENEKAN TOMBOL LEVEL 3");
        SceneManager.LoadScene("MainGames [ Level 3]");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("HalamanUtama");
    }

    // Fungsi Reset (Opsional: Untuk ngetes, panggil ini biar balik ke level 1 semua)
    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}