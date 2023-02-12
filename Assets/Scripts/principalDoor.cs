using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class principalDoor : MonoBehaviour
{
    [SerializeField]private key llave;
    public BoxCollider _boxCollider;
    public static Action OnOpenDoor;
    private void OnMouseDown()
    {
        if(llave.tengoLaLlave == true)
            OpenDoor();
        print("no tienes la llave");
    }

    void OpenDoor(){
        transform.Rotate(new Vector3(0,-90f,0));
        _boxCollider.isTrigger = true;
        OnOpenDoor?.Invoke();
    }
}

