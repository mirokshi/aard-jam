using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    Vector2 velocity;
    public GameObject PauseMenu;
    bool PauseCheck= false;


    void FixedUpdate()
    {
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && PauseCheck == false)
        {
            Debug.Log("Funciona");
            PauseMenu.SetActive(true);
            PauseCheck = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && PauseCheck == true)
        {
            PauseMenu.SetActive(false);
            PauseCheck = false;
        }
    }
}
