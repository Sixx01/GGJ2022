using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovementTEST1 : MonoBehaviour
{
    private const float speed = 10f;

    private void Start()
    {
       
    }

    void Update()

    {

        Vector2 moveDirection = new Vector2(Input.GetAxis("HorizontalARROW"), Input.GetAxis("VerticalARROW"));

        

        


        // no vibration:
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.MovePosition(rigidbody.position + moveDirection * speed * Time.deltaTime);

    }
}
