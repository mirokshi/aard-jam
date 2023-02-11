using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeteckClick : MonoBehaviour
{
    public static Action <DeteckClick> buttonCliked;
    [SerializeField] public string value ;
    
    private void OnMouseDown()
    {
        buttonCliked?.Invoke(this);
    }
}
