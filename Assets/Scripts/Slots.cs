using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    public int i; 

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }

    // Start is called before the first frame update
    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<SpawnDrop>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);


        }
    }
}
