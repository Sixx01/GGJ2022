using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject creditsPanel;

    public void LoadScene(int scene)
    {
        
        SceneManager.LoadScene(scene);
    }

    public void Exit()
    {
        Debug.Log("Saliste el juego");
        Application.Quit();
    }
    public void Credits()
    {
        creditsPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }

    public void ReturnFromCredits()
    {
        creditsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
