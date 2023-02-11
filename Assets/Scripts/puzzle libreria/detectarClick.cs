using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class detectarClick : MonoBehaviour
{
    public static Action <detectarClick> buttonCliked;
    [SerializeField] public int value;
    private void OnMouseDown()
    {
        buttonCliked?.Invoke(this);
    }
}
