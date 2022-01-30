using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem2 : MonoBehaviour
{
    public GameObject player2;



    private bool candleIsActive;

    // Start is called before the first frame update
    void Start()
    {
        //candleIsActive = false;
        //candle.SetActive(candleIsActive);
    }
    void Update()
    {
        if (Input.GetKeyDown("5"))
        {
            player2.transform.GetChild(2).gameObject.SetActive(true);
            Debug.Log("ACTIVATEEE!");

        }
    }

    public void Activate()
    {
        player2.transform.GetChild(1).gameObject.SetActive(true);
        Debug.Log("ACTIVATEEE!");
        Destroy(gameObject);

        //candleIsActive = true;
        //candle.SetActive(candleIsActive);
    }
}
