using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public OptionController pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        pausePanel = GameObject.FindGameObjectWithTag("Options").GetComponent<OptionController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu();
        }
    }

    public void PauseMenu()
    {
        pausePanel.screenOptions.SetActive(true);
    }
}
