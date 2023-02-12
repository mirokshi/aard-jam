using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLights : MonoBehaviour
{
    [SerializeField] private int llumsObertes;
    [SerializeField] private int numeroLlum;
    private Renderer colorLuz;

    private void OnEnable()
    {
        detectarClick.buttonCliked += llum;
        paswordControl.onOpenDoor += llumVerd;
        paswordControl.onCloseDoor += llumVermella;
        colorLuz = GetComponent<Renderer>();
        llumsObertes = 0;
    }

    private void OnDisable()
    {
        detectarClick.buttonCliked -= llum;
        paswordControl.onOpenDoor -= llumVerd;
        paswordControl.onCloseDoor -= llumVermella;
    }

    private void llum(detectarClick obj)
    {
        llumsObertes++;
        if (llumsObertes == numeroLlum)
        {
            colorLuz.material.SetColor("_Color", Color.yellow);
        }

        if (llumsObertes == 4)
        {
            llumsObertes = 0;
        }
    }

    private void llumVerd()
    {
        colorLuz.material.SetColor("_Color", Color.green);
    }

    private void llumVermella()
    {
        colorLuz.material.SetColor("_Color", Color.red);
    }
}
