using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Fungsi untuk keluar dari permainan
    public void QuitGame()
    {

            Application.Quit(); // Keluar di build (PC, Android, iOS)

    }
}
