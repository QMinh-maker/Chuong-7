using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class vidutimespan : MonoBehaviour
{
    // Start is called before the first frame update
    public int SoNgay;
    void Start()
    {           
    DateTime start = DateTime.Now;
    DateTime end = start.AddDays(SoNgay);

    TimeSpan duration = end - start;

    Debug.Log("Tong so gio da qua: " + duration.TotalHours); 
    }
}
