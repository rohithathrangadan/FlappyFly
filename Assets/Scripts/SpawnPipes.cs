using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    float timeBtwSpawn;
    public float resetTimeBtwSpawn;
    public GameObject pipes;
    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawn = resetTimeBtwSpawn;
        Instantiate(pipes, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(pipes, transform.position, transform.rotation);
            timeBtwSpawn = resetTimeBtwSpawn;
        }
        else
            timeBtwSpawn -= Time.deltaTime;
    }
}
