using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    float timeBtwSpawn;
    public float resetTimeBtwSpawn;
    public GameObject pipes;
    float Ypos;
    Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        //timeBtwSpawn = resetTimeBtwSpawn;
        //Instantiate(pipes, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Ypos = Random.Range(-1.63f, 1.59f); // randomize the position of pipes
        spawnPos = new Vector3(transform.position.x, Ypos, transform.position.z);

        if (timeBtwSpawn <= 0)
        {
            Instantiate(pipes, spawnPos, transform.rotation);
            //Instantiate takes Vector3 values
            timeBtwSpawn = resetTimeBtwSpawn;
        }
        else
            timeBtwSpawn -= Time.deltaTime;
    }
}
