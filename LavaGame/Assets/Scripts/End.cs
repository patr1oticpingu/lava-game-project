using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    public bool gameHasEnded = false;
    public Timer timer;
    public TextMeshProUGUI finalTimeText;
    public TextMeshProUGUI finalTime;
    public GameObject endGameScreen;
    public GameObject exitPath;
    public float endTime;
    public float highScore;
    public bool endScreenIsActive;

    void Start()
    {
         exitPath.SetActive(false);   
    }


    public void ResumeGame()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        endGameScreen.SetActive(false);
        Time.timeScale = 1f;
        endScreenIsActive = false;

    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            endTime = timer.EndTime();
            CheckifHighScore();
            timer.timeDisplay(endTime, finalTime);
            endGameScreen.SetActive(true);
            Time.timeScale = 0f;
            gameHasEnded = true;
            endScreenIsActive= true;
            exitPath.SetActive(true);
        }
        

    }
    public void LoadMainMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void CheckifHighScore()
    {
        highScore = GetHighScore();

        if(endTime < highScore)
        {
            finalTimeText.text = "New High Score!";
            PlayerPrefs.SetFloat("HighScore", endTime);
        }

    }

    public float GetHighScore()
    {
        float score = PlayerPrefs.GetFloat("HighScore", 100000);

        return score;
    }

}
