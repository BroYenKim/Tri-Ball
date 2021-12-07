using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Start()
    {
        gameIsPaused = false;
    }

    public void pressedPause()
    {
        if (gameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void quitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);

        Time.timeScale = 1f;
        gameIsPaused = false;
        gameManager.playerCanMove = true;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);

        Time.timeScale = 0f;
        gameIsPaused = true;
        gameManager.playerCanMove = false;
    }
}
