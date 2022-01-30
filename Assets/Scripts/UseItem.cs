using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public GameObject player;
   
    

    private bool candleIsActive;

    // Start is called before the first frame update
    void Start()
    {
        //candleIsActive = false;
        //candle.SetActive(candleIsActive);
    }
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            player.transform.GetChild(2).gameObject.SetActive(true);
            Debug.Log("ACTIVATEEE!");
            
        }
    }

    public void Activate()
    {
        Update();
        //player.transform.GetChild(1).gameObject.SetActive(true);
        //Debug.Log("ACTIVATEEE!");
        Destroy(gameObject);

        //candleIsActive = true;
        //candle.SetActive(candleIsActive);
    }
}
