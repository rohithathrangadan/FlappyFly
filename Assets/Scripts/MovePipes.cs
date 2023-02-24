using UnityEngine;

public class MovePipes : MonoBehaviour
{
    public float speed;
    Flap _flap;
    // Start is called before the first frame update
    void Start()
    {
        _flap = GameObject.FindGameObjectWithTag("Bird").GetComponent<Flap>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_flap.GetBirdStatus())
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        //Time.deltaTime is used to make the game frame independent
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Delete")
            Destroy(gameObject);
    }
}