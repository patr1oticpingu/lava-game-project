using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReset : MonoBehaviour
{
    Vector3 startLocation;

    void Start()
    {
        startLocation = transform.position;
    }

    public void ResetObj()
    {
        transform.position = startLocation;
    }



}
