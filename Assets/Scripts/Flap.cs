using UnityEngine;

public class Flap : MonoBehaviour
{
    public GameObject RestartMenu;
    public float force;
    public int _hitCount;
    public AudioSource _audio;
    public AudioClip Jump, Lost;
    //float _tempForce;
    bool isAlive;
    Rigidbody2D rb;
    Animator birdAnim;
    //start function is called each time the scene loads as new Instance of the script gets created each time the scene is loaded
    //For retaining the same script between each scene loads, use dontdestroyonload.
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        birdAnim = GetComponent<Animator>();
        birdAnim.enabled = true;
        //_tempForce = force;
        isAlive = true;
        _hitCount = 0;
        // Input.multiTouchEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (isAlive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * force;
                birdAnim.SetBool("Clicked", true);
                if (isAlive)
                    _audio.PlayOneShot(Jump);
            }
            else
            {
                birdAnim.SetBool("Clicked", false);
            }
        }
        else
            return;


        // force = _tempForce;

        // Vector2.up is equivalent to new Vector2(0,1)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _hitCount++;
        Debug.Log("Bird Collision");
        isAlive = false;
        force = 0;
        //on multiple collision it should not trigger multiple times so check if hitcount is 1 
        if (_hitCount == 1)
        {

            _audio.PlayOneShot(Lost);
            birdAnim.SetTrigger("Hit");
            Invoke("OpenRestartMenu", 0.75f);
        }
        //birdAnim.enabled = false;
        //birdAnim.SetTrigger() 
    }

    void OpenRestartMenu()
    {

        RestartMenu.SetActive(true);
        //Time.timeScale = 0;
    }

    public bool GetBirdStatus()
    {
        return isAlive;
    }

}
