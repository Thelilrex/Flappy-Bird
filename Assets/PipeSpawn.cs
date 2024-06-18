using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 10;
    private float spawnTime = 0;
    public float heightOffset = 9;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTime < spawnRate)
        {
            spawnTime += Time.deltaTime;
        }
        else
        {
            spawn();
            spawnTime = 0;
        }
    }

    void spawn()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
