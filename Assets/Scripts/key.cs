using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public bool tengoLaLlave;

    private void Awake()
    {
        tengoLaLlave = false;
    }

    private void OnMouseDown()
    {
        this.transform.position = new Vector3(0, -10, 0);
    }
}
