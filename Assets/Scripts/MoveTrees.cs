using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrees : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Delete")
            Destroy(gameObject);
    }
}
