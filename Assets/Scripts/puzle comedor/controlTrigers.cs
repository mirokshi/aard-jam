using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class controlTrigers : MonoBehaviour
{
    public static Action<controlTrigers> _in;
    public static Action<controlTrigers> _out;
    [SerializeField] public string CutleryName;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Dish"))
        {
            _in?.Invoke(this);    
        }
        
    }
    
    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Dish"))
        {
            _out?.Invoke(this);    
        }
        
    }
}
