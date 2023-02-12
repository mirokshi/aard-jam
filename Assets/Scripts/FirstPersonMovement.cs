using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    Vector2 velocity;
    public GameObject PauseMenu;
    bool PauseCheck= false;
    public AudioSource footsteps;

    private void Awake()
    {
        PauseCheck = false;
    }
    void FixedUpdate()
    {
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);

    }

    private void Update()
    {
        if (new Vector2(velocity.x,velocity.y).normalized != Vector2.zero)
        {
            footsteps.enabled = true;
        }
        else
        {
            footsteps.enabled = false;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && PauseCheck == false)
        {
            Debug.Log("Funciona");
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
            PauseCheck = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && PauseCheck == true)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
            PauseCheck = false;
        }

        else if (Input.GetKeyDown(KeyCode.M) && PauseCheck == true)
        {
            SceneManager.LoadScene("Scenes/MainMenu");
        }

        else if (Input.GetKeyDown(KeyCode.Space) && PauseCheck == true)
        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }
}
