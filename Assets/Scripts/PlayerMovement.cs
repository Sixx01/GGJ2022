using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    PhotonView view;

    private const float speed = 10f;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            Vector2 moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));


            // no vibration:
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.MovePosition(rigidbody.position + moveDirection * speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Physics.IgnoreLayerCollision(collision.collider, false);
        }

    }
}