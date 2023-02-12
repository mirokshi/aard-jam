using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeteckClick : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0,30f,0));
    }
}
