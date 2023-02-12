using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKitchen : MonoBehaviour
{
    private bool _fork;
    private bool _knife;
    private bool _spoon;
    private AudioSource _audioSource;
    
    private void OnEnable()
    {
        _audioSource = GetComponent<AudioSource>();
        _fork = false;
        _knife = false;
        _spoon = false;
        CutleryControl.onResolved += Resolved;
        CutleryControl.onNotResolved += NotResolved;
    }

    private void OnDisable()
    {
        CutleryControl.onResolved -= Resolved;
        CutleryControl.onNotResolved -= NotResolved;
    }

    void NotResolved(CutleryControl cutlery)
    {
        switch (cutlery.CutleryName)
        {
            case "fork":
                _fork = false;
                break;
            case "knife":
                _knife = false;
                break;
            case "spoon":
                _spoon = false;
                break;
        }
    }
    
    void Resolved(CutleryControl cutlery)
    {
        switch (cutlery.CutleryName)
        {
            case "fork":
                _fork = true;
                break;
            case "knife":
                _knife = true;
                break;
            case "spoon":
                _spoon = true;
                break;
        }

        if (_fork && _knife && _spoon)
        {
            _audioSource.Play();
            transform.Rotate(new Vector3(0,90f,0));
            Debug.Log("RESUELTO");    
        }
        else
        {
            Debug.Log("NO RESULTO");
        }
        
    }
}
