using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class CheckpointLight : MonoBehaviour
{

    public CheckpointButton checkpointButton;
    public Material[] material;
    Renderer render;
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
        if (checkpointButton != null)
        {
            if (checkpointButton.passedCheckpoint == true)
            {
                render.sharedMaterial = material[1];
            }
        }
    }
}
