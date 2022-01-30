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

    // Update is called once per frame
    public void Activate()
    {
        player.transform.GetChild(2).gameObject.SetActive(true);

        //candleIsActive = true;
        //candle.SetActive(candleIsActive);
    }
}
