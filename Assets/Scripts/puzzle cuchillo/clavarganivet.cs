using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class clavarganivet : MonoBehaviour
{
    private bool elTens;
    [SerializeField] GameObject ganivet;
    [SerializeField] private GameObject tio;
    [SerializeField] private GameObject key;
    private void OnEnable()
    {
        cuchillo.tensElGanivet += tensElGanivet;
    }

    private void OnDisable()
    {
        cuchillo.tensElGanivet += tensElGanivet;
    }

    private void tensElGanivet()
    {
        elTens = true;
    }

    private void OnMouseDown()
    {
        if (elTens)
        {
            tio.SetActive(false);
            ganivet.SetActive(true);
        }
    }
}
