using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpp2 : MonoBehaviour
{

    private Inventory inventoryp2;
    public GameObject itemButton;

    // Start is called before the first frame update
    private void Start()
    {
        inventoryp2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();   
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventoryp2.slots.Length; i++)
            {
                if (inventoryp2.isFull[i] == false)
                {
                    inventoryp2.isFull[i] = true;
                    Instantiate(itemButton, inventoryp2.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
