using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class PathwayRandomizer : MonoBehaviour
{
   public GameObject pathOne;
   public GameObject pathTwo;
    void Start()
    {
        int x = 1;
        int y = 3;
        Random random = new Random();

        pathOne.GetComponent<Collider>().enabled = false;
        pathTwo.GetComponent<Collider>().enabled = false;

        int pathway = random.Next(x, y);
        print (pathway);

        if(pathway == 1)
        {
            pathOne.GetComponent<Collider>().enabled = true;
        }

        if (pathway == 2)
        {
            pathTwo.GetComponent<Collider>().enabled = true;
        }


    }

  
}
