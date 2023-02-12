using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuchillo : MonoBehaviour
{
    public static Action tensElGanivet;
    [SerializeField] private GameObject knife;
    private void OnMouseDown()
    {
        tensElGanivet?.Invoke();
        knife.SetActive(false);
    }
}
