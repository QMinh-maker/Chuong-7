using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Vidudatetime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime now = DateTime.Now;
        Debug.Log("Thoi gian hien tai: " + now.ToString("dd/MM/yyyy HH:mm:ss"));
          
    }
}
