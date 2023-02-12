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
        Time.timeScale = 0;
        text.SetActive(true);
    }

    private void OnMouseExit()
    {
        text.SetActive(false);
        Time.timeScale = 1;
    }
}
