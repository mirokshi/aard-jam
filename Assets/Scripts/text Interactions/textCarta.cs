using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class textCarta : MonoBehaviour
{
    [SerializeField] private GameObject text;

    private void Awake()
    {
        text.SetActive(false);
    }

    private void OnMouseDown()
    {
        print("text");
        text.SetActive(true);
    }

    private void OnMouseExit()
    {
        text.SetActive(false);
    }
}
