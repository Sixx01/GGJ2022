using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovementTEST : MonoBehaviour
{
    private const float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;


    Vector2 movement;

    //borrar en caso de tronar
    public PhotonView view;


    private void Start()
    {
        //borrar en caso de tronar
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        //borrar en caso de tronar
        if (view.IsMine)
        {
            movement.x = Input.GetAxis("HorizontalWASD");
            movement.y = Input.GetAxis("VerticalWASD");

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
