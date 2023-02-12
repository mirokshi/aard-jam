using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLibrary : MonoBehaviour
{
    private bool fet;
    private void OnEnable()
    {
        paswordControl.onOpenDoor += OpenDoor;
        fet = false;
    }

    private void OnDisable()
    {
        paswordControl.onOpenDoor -= OpenDoor;
    }

    void OpenDoor()
    {
        if (!fet)
        {
            fet = true;
            transform.Rotate(new Vector3(0,90f,0));
        }
    }
}
