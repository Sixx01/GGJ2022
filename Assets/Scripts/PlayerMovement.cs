using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            transform.Translate(Input.GetAxis("Horizontal") * 5f * Time.deltaTime,
                                Input.GetAxis("Vertical") * 5f * Time.deltaTime, 0f);
        }
    }
}
