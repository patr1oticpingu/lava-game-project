using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckpointController : MonoBehaviour
{
    public int checkpointCounter;
    public TextMeshProUGUI challengeNumber;
    public TextMeshProUGUI challengeText;
    public End end;

    public Vector3 currentCheckpoint;
    void Start()
    {
        currentCheckpoint = new Vector3(126f, 24f, 689f);
        checkpointCounter = 0;
        challengeNumber.text = ("Challenge " + (checkpointCounter + 1)).ToString();
        challengeText.text = ("Shuffle across the lava using the blocks provided. Hold left click to hold the blocks. Falling into lava will reset your blocks.");


    }

    // Update is called once per frame
    void Update()
    {
        if (checkpointCounter == 1)
        {
            currentCheckpoint = new Vector3(183f, 30f, 683f);
            challengeNumber.text = ("Challenge " + (checkpointCounter + 1)).ToString();
            challengeText.text = ("You must get one of the balls into the basket on the other island. Remember, right-clicking throws objects,");
        }

        if (checkpointCounter == 2)
        {
            currentCheckpoint = new Vector3(182f, 19f, 776f);
            challengeNumber.text = ("Challenge " + (checkpointCounter + 1)).ToString();
            challengeText.text = ("Only one of each set of pathways is real; You must memorize the sequence to get across");
        }

        if(checkpointCounter == 3)
        {
            currentCheckpoint = new Vector3(236f, 42f, 952f);
            challengeNumber.text = ("Challenge " + (checkpointCounter + 1)).ToString();
            challengeText.text = ("Navigate the spires to get to the next island. The path on the left is harder but goes faster, the choice is yours.");
        }
        if (checkpointCounter == 4)
        {
            currentCheckpoint = new Vector3(351f, 21f, 1065f);
            challengeNumber.text = ("Challenge " + (checkpointCounter + 1)).ToString();
            challengeText.text = ("Make your way across the shifting pieces. Note that the platforms will move without you.");
        }
        if (checkpointCounter == 5)
        {
            challengeNumber.text = ("Challenge " + (checkpointCounter + 1)).ToString();
            currentCheckpoint = new Vector3(426f, 17f, 1156f);
            challengeText.text = ("Use the blocks to ascend the tower and finish the game. Watch your step with the spinning blades. ");
        }

        if (checkpointCounter == 6)
        {
            end.EndGame();
            challengeNumber.text = ("Game Ended");
            currentCheckpoint = new Vector3(426f, 17f, 1156f);
            challengeText.text = ("Feel free to explore ");
        }

    }

    public void newCheckpoint()
    {
        checkpointCounter++;
    }
}
