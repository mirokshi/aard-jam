using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickFigura : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(90,0,0));
    }
}
