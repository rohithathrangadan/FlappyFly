using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject Trees;
    float TimeBtwSpawn;
    Flap _flap;

    public float ResetTimeBtwSpawn;
    // Start is called before the first frame update
    void Start()
    {
        _flap = GameObject.FindGameObjectWithTag("Bird").GetComponent<Flap>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_flap.GetBirdStatus())
        {
            if (TimeBtwSpawn <= 0)
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
}
