using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField]
    public float timerVal = 60;
    [SerializeField]
    public float dangerVal = 15;
    [SerializeField]
    private TextMeshProUGUI timer;
    public bool timerIsRunning = true;
    public bool startedCour = false;


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
                if(ScoreTracker.score > 5)
                {
                    SceneManager.LoadScene("EndScene");
                }
                else
                {
                    SceneManager.LoadScene("EndSceneLoss");
                }
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
        if (Mathf.FloorToInt(timeDisplay) <= dangerVal)
        {
            this.timer.color = Color.red;
            if (startedCour == false)
            {
                StartCoroutine(BlinkRoutine());
                startedCour = true;
            }
        }
        else
        {
            this.timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    IEnumerator BlinkRoutine()
    {
        while (true)
        {
            this.timer.text = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(timerVal / 60), Mathf.FloorToInt(timerVal % 60));
            yield return new WaitForSeconds(0.4f);
            this.timer.text = "";
            yield return new WaitForSeconds(0.4f);
        }
    }
}
