using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject square, circle;

    // Update is called once per frame
    void Update()
    {
        //spawn position and rotation is at the transform value of the gameobject to which script is attached to
        if (Input.GetKeyDown(KeyCode.S))
            Instantiate(square, transform.position, transform.rotation);

        if (Input.GetKeyDown(KeyCode.C))
            Instantiate(circle, transform.position, transform.rotation);

        //to spawn at the square and circle transfom values

        /* if (Input.GetKeyDown(KeyCode.S))
             Instantiate(square, square.transform.position, square.transform.rotation);

         if (Input.GetKeyDown(KeyCode.C))
             Instantiate(circle, circle.transform.position, circle.transform.rotation);*/
    }
}
