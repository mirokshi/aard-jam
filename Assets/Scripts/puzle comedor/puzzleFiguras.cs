using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleFiguras : MonoBehaviour
{
    private bool _manzana;
    private bool _pera;
    private bool _zanaoria;
    
    private AudioSource _audioSource;

    private void OnEnable()
    {
        _audioSource = GetComponent<AudioSource>();
        _manzana = false;
        _pera = false;
        _zanaoria = false;
        controlTrigers._in += Resolved;
        controlTrigers._out += NotResolved;
    }

    private void OnDisable()
    {
        controlTrigers._in -= Resolved;
        controlTrigers._out -= NotResolved;
    }

    void NotResolved(controlTrigers cutlery)
    {
        switch (cutlery.CutleryName)
        {
            case "manzana":
                _manzana = false;
                break;
            case "pera":
                _pera = false;
                break;
            case "zanaoria":
                _zanaoria = false;
                break;
        }
    }

    void Resolved(controlTrigers cutlery)
    {
        switch (cutlery.CutleryName)
        {
            case "manzana":
                _manzana = true;
                break;
            case "pera":
                _pera = true;
                break;
            case "zanaoria":
                _zanaoria = true;
                break;
        }

        if (_manzana && _pera && _zanaoria)
        {
            _audioSource.Play();
            transform.Rotate(new Vector3(0, -90f, 0));
            Debug.Log("RESUELTO");
        }
        else
        {
            Debug.Log("NO RESULTO");
        }
    }
}
