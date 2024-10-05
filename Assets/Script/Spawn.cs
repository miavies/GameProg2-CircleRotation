using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float minSpawnTime;
    public float maxSpawnTime;
    public GameObject[] spawnObjects;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
        minSpawnTime = 5f;
        maxSpawnTime = 10f;
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            float spawnDelay = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnDelay);

            int randomObjectIndex = Random.Range(0, spawnObjects.Length);
            GameObject selectedObject = spawnObjects[randomObjectIndex];
            
            

            Instantiate(selectedObject, transform.position, Quaternion.identity);
        }
    }
}
