using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLight : MonoBehaviour
{
    public Material[] material;
    Renderer render;
    public ChallengeTwoScore challengeTwoScore;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (challengeTwoScore != null)
        {
            if (challengeTwoScore.scored == true)
            {
                render.sharedMaterial = material[1];
            }
        }
    }
}
