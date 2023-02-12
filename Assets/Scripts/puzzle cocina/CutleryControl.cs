using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutleryControl : MonoBehaviour
{
    public static Action<CutleryControl> onResolved;
    [SerializeField] public string Cutlery;

    private void OnTriggerEnter(Collider other)
    {
        onResolved?.Invoke(this);
    }
}
