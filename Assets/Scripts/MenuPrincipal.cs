using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}