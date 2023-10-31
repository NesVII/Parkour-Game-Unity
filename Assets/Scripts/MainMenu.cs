using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        if (PauseMenu.isPaused)
        {
            PauseMenu.isPaused = false;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
