using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GameScene()
    {
        Debug.Log("Cambio a escena de juego (desactivada)");
        SceneManager.LoadScene("GameScene");
    }


    public void Exit()
    {
        Debug.Log("Saliste el juego");
        Application.Quit();
    }
}
