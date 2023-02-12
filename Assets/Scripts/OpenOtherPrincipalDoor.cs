using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOtherPrincipalDoor : MonoBehaviour
{
    private void OnEnable()
    {
        principalDoor.OnOpenDoor += OpenDoor;
    }

    private void OnDisable()
    {
        principalDoor.OnOpenDoor -= OpenDoor;
    }

    void OpenDoor()
    {
        transform.Rotate(new Vector3(0,90f,0));
    }
}
