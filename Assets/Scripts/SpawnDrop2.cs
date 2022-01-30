using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDrop2 : MonoBehaviour
{
    public GameObject item;

    private Transform player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player2").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x, player.position.y + 1);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
