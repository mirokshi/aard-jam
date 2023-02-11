using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaCuarto : MonoBehaviour
{
    [SerializeField]private key llave;
    public BoxCollider _boxCollider;
    private void OnMouseDown()
    {
        if(llave.tengoLaLlave == true)
            OpenDoor();
        print("no tienes la llave");
    }

    void OpenDoor(){
        transform.Rotate(new Vector3(0,90f,0));
        _boxCollider.isTrigger = true;
    }
}

