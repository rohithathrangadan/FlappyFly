using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipes;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipes, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
