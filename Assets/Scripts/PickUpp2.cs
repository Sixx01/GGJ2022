using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpp2 : MonoBehaviour
{

    private Inventoryp2 inventoryp2;
    public GameObject itemButton;

    // Start is called before the first frame update
    private void Start()
    {
        inventoryp2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Inventoryp2>();   
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player2"))
        {
            for (int i = 0; i < inventoryp2.slots2.Length; i++)
            {
                if (inventoryp2.isFull2[i] == false)
                {
                    inventoryp2.isFull2[i] = true;
                    Instantiate(itemButton, inventoryp2.slots2[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
