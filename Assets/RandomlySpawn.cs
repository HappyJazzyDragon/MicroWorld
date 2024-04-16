using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlySpawn : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    public float minSpawnRadius = 5.0f;
    public float maxSpawnRadius = 15.0f;

    public int numberOfObjectsToSpawn = 30;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            Instantiate(objectsToSpawn[Random.Range(0,objectsToSpawn.Length)],transform.position + Random.insideUnitSphere * Random.Range(minSpawnRadius,maxSpawnRadius), Random.rotationUniform);
        }
    }
}
