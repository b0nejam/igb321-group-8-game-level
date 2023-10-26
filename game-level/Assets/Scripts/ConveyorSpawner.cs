using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorSpawner : MonoBehaviour
{
    public GameObject Box;

    public float spawnRate = 2.0f;
    private float spawnTimer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBox();
    }

    private void SpawnBox()
    {
        if(Time.time > spawnTimer)
        {
            Instantiate(Box, transform.position, transform.rotation);
            spawnTimer = Time.time + spawnRate;

        }
    }
}
