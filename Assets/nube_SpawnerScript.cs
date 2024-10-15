using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nube_SpawnerScript : MonoBehaviour
{
    public float moveSpeed = 100;

    public GameObject nube;
    public float spawnRate = 3;
    private float timer = 0;
    public float heighOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnNube();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnNube();
            timer = 0;
        }
    }

    void spawnNube ()
    {
         float lowestPoint = transform.position.y - heighOffset;
         float highestPoint = transform.position.y + heighOffset;
        Instantiate(nube, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(nube, transform.position, transform.rotation);
        
    }
}
