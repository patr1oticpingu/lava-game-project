using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ObjectResetManager : MonoBehaviour
{
    public CheckpointController checkpointController;
    public FirstPersonController player;


    public ObjectReset ChallengeOneObjectOne;
    public ObjectReset ChallengeOneObjectTwo;
    public ObjectReset ChallengeTwoObjectOne;
    public ObjectReset ChallengeTwoObjectTwo;
    public ObjectReset ChallengeTwoObjectThree;
    public ObjectReset ChallengeTwoObjectFour;
    public ObjectReset FinalChallengeObjectOne;
    public ObjectReset FinalChallengeObjectTwo;
    public ObjectReset FinalChallengeObjectThree;
    public ObjectReset FinalChallengeObjectFour;
        

    public int localCounter;


    // Start is called before the first frame update
    void Start()
    {
        localCounter = checkpointController.checkpointCounter;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.hasDied == true || localCounter < checkpointController.checkpointCounter)
        {
            ChallengeOneObjectOne.ResetObj();
            ChallengeOneObjectTwo.ResetObj();

            ChallengeTwoObjectOne.ResetObj();
            ChallengeTwoObjectTwo.ResetObj();
            ChallengeTwoObjectThree.ResetObj();
            ChallengeTwoObjectFour.ResetObj();

            FinalChallengeObjectOne.ResetObj();
            FinalChallengeObjectTwo.ResetObj();
            FinalChallengeObjectThree.ResetObj();
            FinalChallengeObjectFour.ResetObj();

            localCounter = checkpointController.checkpointCounter;
            player.hasDied = false;
            
        }


       
        
    }
}
