using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player playerInstance;

    private void Awake()
    {
        if (playerInstance == null)
            playerInstance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
