using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointButton : MonoBehaviour
{
    public Material[] material;
    Renderer render;
    public bool passedCheckpoint = false;
    public CheckpointController CheckpointController;
    public bool canPress = true;
    public AudioSource buzzer;
    public AudioClip buzzerClip;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = material[0];
        
    }

    private void OnMouseUpAsButton()
    {
        if(canPress == true)
        {
            buzzer.PlayOneShot(buzzerClip);
            render.sharedMaterial = material[1];
            passedCheckpoint = true;
            CheckpointController.newCheckpoint();
            canPress = false;
        }
        
    }
}
