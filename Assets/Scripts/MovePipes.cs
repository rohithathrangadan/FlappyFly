using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePipes : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed*Time.deltaTime);
        //Time.deltaTime is used to make the game frame independent
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.tag == "Destroy")
        Destroy(gameObject);
    }
}
