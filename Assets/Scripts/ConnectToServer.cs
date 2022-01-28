using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public InputField usernameInput;
    //public Text buttonText;

    public void OnClickConnect()
    {
        if (usernameInput.text.Length >= 4)
        {
            PhotonNetwork.NickName = usernameInput.text;
            //buttonText.text = "Conectando...";
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
        }
    }
    
    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("LobbyScene");
    }

  
}
