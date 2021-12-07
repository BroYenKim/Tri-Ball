using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class mainMenu : MonoBehaviour
{

    public GameObject menu;
    public GameObject credits;
    public GameObject playButton;
    public GameObject backButton;

    public RectTransform panelTransform;

    public void Start()
    {
        FindObjectOfType<audioManager>().Play("Menu");
    }
    public void playGame()
    {
        SceneManager.LoadScene("mainGame");
    }

    public void playTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void quitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void showCredits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(backButton);
    }

    public void unshowCredits()
    {
        menu.SetActive(true);
        credits.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(playButton);
    }
}
