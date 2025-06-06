using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViduDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Day la tin nhan thong bao.");
        Debug.LogWarning("Day la tin nhan canh bao.");
        Debug.LogError("Day la tin nhan bao loi.");
    }
}
