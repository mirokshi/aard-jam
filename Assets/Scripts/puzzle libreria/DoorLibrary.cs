using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DoorLibrary : MonoBehaviour
{
    private AudioSource _audioSource;

    private bool fet;
    private void OnEnable()
    {
        _audioSource = GetComponent<AudioSource>();
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
            _audioSource.Play();
            transform.Rotate(new Vector3(0,90f,0));
        }
    }
}
