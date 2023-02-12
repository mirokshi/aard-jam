using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKitchen : MonoBehaviour
{
    private bool _fork;
    private bool _knife;
    private bool _spoon;
    
    private void OnEnable()
    {
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
        Debug.Log("EXIT");
        if (cutlery.CutleryName == "fork")
        {
            _fork = false;
        }
        if (cutlery.CutleryName == "knife")
        {
            _knife = false;
        }
        if (cutlery.CutleryName == "spoon")
        {
            _spoon = false;
        }
    }
    
    void Resolved(CutleryControl cutlery)
    {
        Debug.Log("ENTER");
        if (cutlery.CutleryName == "fork")
        {
            _fork = true;
        }
        if (cutlery.CutleryName == "knife")
        {
            _knife = true;
        }
        if (cutlery.CutleryName == "spoon")
        {
            _spoon = true;
        }

        if (_fork && _knife && _spoon)
        {
            transform.Rotate(new Vector3(0,90f,0));
            Debug.Log("RESUELTO");    
        }
        else
        {
            Debug.Log("NO RESULTO");
        }
        
    }
}
