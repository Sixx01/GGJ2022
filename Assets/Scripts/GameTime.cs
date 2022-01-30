using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    [SerializeField] Timer timer1;

    public int SetTime;

    private void Start()
    {
        timer1.SetDuration(SetTime).Begin();
    }
}
