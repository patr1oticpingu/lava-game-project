using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public Timer timer;
    public float highScore;

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 100000);

        if (highScore == 100000)
        {
            highScoreText.text = "Null";
        }
        else
        {
            timer.timeDisplay(highScore, highScoreText);
        }
       
    }
}
