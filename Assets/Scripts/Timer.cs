using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Timer UI references: ")]
    [SerializeField] private Image uiFillImage;
    

    public int Duration
    {
        get; private set;
    }

    private int remainingDuration;

    // Start is called before the first frame update
    private void Awake()
    {
        ResetTimer();
    }

    // Update is called once per frame
    private void ResetTimer()
    {
        uiFillImage.fillAmount = 0f;

        Duration = remainingDuration = 0;
    }

    public Timer SetDuration(int seconds)
    {
        Duration = remainingDuration = seconds;
        return this;
    }

    public void Begin()
    {
        StopAllCoroutines();
        StartCoroutine(UpdateTimer());       
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration > 0)
        {
            UpdateUI(remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }

        End();
    
    }

    private void UpdateUI(int seconds)
    {
        uiFillImage.fillAmount = Mathf.InverseLerp(0, Duration, seconds);
    }

    public void End()
    {
        Debug.Log("Cambia escena GAME OVER WIN");
        ResetTimer();
        SceneManager.LoadScene(5);
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

}
