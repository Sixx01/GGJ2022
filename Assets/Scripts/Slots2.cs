using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots2 : MonoBehaviour
{
    private Inventoryp2 inventory2;
    public int i;

    private void Start()
    {
        inventory2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Inventoryp2>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory2.isFull2[i] = false;
        }
    }

    // Start is called before the first frame update
    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<SpawnDrop2>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);


        }
    }
}
