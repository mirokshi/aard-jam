using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKitchen : MonoBehaviour
{
    private void OnEnable()
    {
        paswordControl.onOpenDoor += OpenDoor;
    }

    private void OnDisable()
    {
        paswordControl.onOpenDoor -= OpenDoor;
    }

    void OpenDoor(){
        transform.Rotate(new Vector3(0,90f,0));
    }
}
