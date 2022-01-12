using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image muteImage;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("audioVolume", 0.5f);
        AudioListener.volume = slider.value;
        CheckIfMute();
    }

    public void ChangeSlider(float value)
    { 
        sliderValue = value;
        PlayerPrefs.SetFloat("audioVolume", sliderValue);
        AudioListener.volume = slider.value;
        CheckIfMute();
    }

    public void CheckIfMute()
    { 
       if (sliderValue == 0)
        {
            muteImage.enabled = true;
        }
        else
        {
            muteImage.enabled = false;
        }
    }
}