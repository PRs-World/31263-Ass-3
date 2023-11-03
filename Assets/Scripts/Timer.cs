using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;          
    private float startTime;
    private bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        isRunning = true;
        timerText.text = "00:00:00";
    }

    // Update is called once per frame
    void Update()
    {
        if(isRunning) 
        {
            float elapsedTime = Time.time - startTime;

            int minutes = (int)(elapsedTime / 60);
            int seconds = (int)(elapsedTime % 60);
            int milliseconds = (int)((elapsedTime * 1000) % 1000);

            string timerFormatted = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
            timerText.text = timerFormatted;
        }
    }
}
