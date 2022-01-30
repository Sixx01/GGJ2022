using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public InputField usernameInput;
    public GameObject warningText;
    public GameObject backButton;
    public GameObject connectButton;
    public GameObject connectingImage;

    public void OnClickConnect()
    {
        if (usernameInput.text.Length >= 4)
        {
            connectingImage.SetActive(true);
            connectButton.SetActive(false);
            backButton.SetActive(false);
            warningText.SetActive(false);
            PhotonNetwork.NickName = usernameInput.text;
            //buttonText.text = "Conectando...";
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
            warningText.SetActive(false);
        }
        else if (usernameInput.text.Length < 4)
        {
            warningText.SetActive(true);
        }
    }
    
    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("LobbyScene");
    }

  
}
