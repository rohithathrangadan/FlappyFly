using UnityEngine;
using UnityEngine.SceneManagement;

public class Flap : MonoBehaviour
{
    public GameObject RestartMenu;
    public float force;
    float _tempForce;
    Rigidbody2D rb;
    Animator birdAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        birdAnim = GetComponent<Animator>();
        birdAnim.enabled = true;
        _tempForce = force;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
            birdAnim.SetBool("Clicked", true);

        }
        else
        {
            birdAnim.SetBool("Clicked", false);
        }

        // return to come out of update function immwdiately
        // Vector2.up is equivalent to new Vector2(0,1)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bird Collision");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //so getactivescene means the present scene. It will restart the current scene
        force = 0;
        birdAnim.enabled = false;
        OpenRestartMenu();
    }

    void OpenRestartMenu()
    {
        RestartMenu.SetActive(true);
        Time.timeScale = 0;
        force = _tempForce;
    }

}
