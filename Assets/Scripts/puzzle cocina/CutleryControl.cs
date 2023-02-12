using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutleryControl : MonoBehaviour
{
    public static Action<CutleryControl> onResolved;
    public static Action<CutleryControl> onNotResolved;
    [SerializeField] public string CutleryName;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Dish"))
        {
            onResolved?.Invoke(this);    
        }
        
    }
    
    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Dish"))
        {
            onNotResolved?.Invoke(this);    
        }
        
    }
    
}
