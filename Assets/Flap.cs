using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flap : MonoBehaviour
{
    public float force;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;
        else
            rb.velocity = Vector2.up * force;
        // return to come out of update function immwdiately
        // Vector2.up is equivalent to new Vector2(0,1)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bird Collision");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //so getactivescene means the present scene. It will restart the current scene
    }
}
