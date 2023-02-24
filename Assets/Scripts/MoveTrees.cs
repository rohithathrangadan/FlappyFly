using UnityEngine;

public class MoveTrees : MonoBehaviour
{
    public float speed;
    Flap _flap;
    // Start is called before the first frame update

    private void Start()
    {
        _flap = GameObject.FindGameObjectWithTag("Bird").GetComponent<Flap>();
    }
    // Update is called once per frame
    void Update()
    {
        if (_flap.GetBirdStatus())
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Delete")
            Destroy(gameObject);
    }
}
