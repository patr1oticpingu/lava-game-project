using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeTwoScore : MonoBehaviour
{
    public GameObject Platform;
    public bool scored;

    private void Start()
    {
        Platform.SetActive(false);
        scored = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("score");
        Platform.SetActive(true);
        scored = true;
    }
}
