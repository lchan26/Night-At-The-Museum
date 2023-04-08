using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField]
    public float timerVal = 300;
    [SerializeField]
    private TextMeshProUGUI timer;
    public bool timerIsRunning = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timerVal > 0)
            {
                timerVal -= Time.deltaTime;
            }
            else
            {
                timerVal = 0;
                timerIsRunning = false;
                DisplayTime(timerVal);
                SceneManager.LoadScene("EndScene");
            }
            DisplayTime(timerVal);
        }
    }

    void DisplayTime(float timeDisplay)
    {
        if (timeDisplay < 0)
        {
            timeDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);
        this.timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
