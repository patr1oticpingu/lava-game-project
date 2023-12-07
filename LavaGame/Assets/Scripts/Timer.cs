using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerUI;
    private float startTime;
    [SerializeField] private float currentTime;
  
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        currentTime = Time.time - startTime;
        timeDisplay(currentTime, timerUI);
    }

    public void timeDisplay(float currentTime, TextMeshProUGUI timerUI)
    {


        string minute = MinuteCalc(currentTime);
        string second = SecondCalc(currentTime);

        if (((int)currentTime / 60) < 10 && (currentTime % 60) < 10)
        {
            timerUI.text = "0" + minute + ":0" + second;
        }
        else if (((int)currentTime / 60) < 10 && (currentTime % 60) >= 10)
        {
            timerUI.text = "0" + minute + ":" + second;
        }
        else if (((int)currentTime / 60) >= 10 && (currentTime % 60) < 10)
        {
            timerUI.text = minute + ":0" + second;
        }
        else
        {
            timerUI.text = minute + ":" + second;
        }
    }

    public string MinuteCalc(float time)
    {
        string minute = ((int)time / 60).ToString();
        return minute;
    }

    public string SecondCalc(float time)
    {
        string second = (time % 60).ToString("f2");
        return second;
    }

    public float EndTime()
    {
        return currentTime;
    }

}
