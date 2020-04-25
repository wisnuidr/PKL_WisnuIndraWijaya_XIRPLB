using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer1 : MonoBehaviour
{
    public Text timerMinutes;
    public Text timerSeconds;
    public Text timerSeconds100;

    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerReset();
    }

    public void timerStart()
    {
        if (!isRunning)
        {
            print("START");
            isRunning = true;
            startTime = Time.time;
        }
    }
    public void timerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = Time.time;
        }
    }
    public void timerReset()
    {
        print("RESET");
    }

    // Update is called once per frame
    void Update()
    {
        timerTime = stopTime + (Time.time - startTime);
        int minutesInt = (int)timerTime / 60;
        int secondsInt = (int)timerTime % 60;
        int seconds100Int = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

        if (isRunning)
        {
            timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
        }
    }
}
