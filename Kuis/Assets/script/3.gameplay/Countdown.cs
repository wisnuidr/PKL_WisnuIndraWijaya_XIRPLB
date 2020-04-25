using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    [SerializeField] Text countdownText;

    public GameObject Popups,bgm,timeout,timer;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        Popups.SetActive(false);
        bgm.SetActive(true);
        timeout.SetActive(false);
        timer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            Popups.SetActive(true);
            bgm.SetActive(false);
            timeout.SetActive(true);
        }
    }

}
