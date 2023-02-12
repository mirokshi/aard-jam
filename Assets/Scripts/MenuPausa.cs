using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    // Start is called before the first frame update
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }


}
