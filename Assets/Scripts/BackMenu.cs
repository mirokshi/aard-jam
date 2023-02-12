using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
