using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject skeleton, skeleton2;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            Instantiate(skeleton, transform.position, Quaternion.identity);
            whatToSpawn = Random.Range(1, 3);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(skeleton, transform.position, Quaternion.identity);
                    break;

                case 2:
                    Instantiate(skeleton2, transform.position, Quaternion.identity);
                    break;

            }

            nextSpawn = Time.time + spawnRate;
        }
    }
}
