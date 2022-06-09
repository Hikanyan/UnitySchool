using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> animalPrebs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnInterval = 1.5f;
    private float passedTime = -2f;
    private float startDelay = 1;
    private void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    void Update()
    {
        passedTime += Time.deltaTime;
        if(passedTime > spawnInterval)
        {
            SpawnRandomAnimal();
            passedTime = 0;
        }       
    }

    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrebs.Count);
        GameObject animal = animalPrebs[animalIndex];
        Instantiate(animal, spawnPos, animal.transform.rotation);
    }
}
