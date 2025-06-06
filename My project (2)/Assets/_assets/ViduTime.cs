using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViduTime : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Time since start: " + Time.time);
        Debug.Log("Time between frames: " + Time.deltaTime);
    }
}
