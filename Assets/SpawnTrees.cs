using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject Trees;
    float TimeBtwSpawn;
    public float ResetTimeBtwSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeBtwSpawn<=0)
        {
            Instantiate(Trees, transform.position, transform.rotation);
            TimeBtwSpawn = ResetTimeBtwSpawn;
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
