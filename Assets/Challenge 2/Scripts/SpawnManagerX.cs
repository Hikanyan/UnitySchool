using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -20;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    float timer;
    float timerLimit = 3;
    int index= 0;


    private void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(3,5));
    }
    // Start is called before the first frame update
    private void Update()
    {
        timer += Time.deltaTime;
     
        
        if (timer > timerLimit)
        {
            SpawnRandomBall();
            timer = 0;
            //spawnLimitXLeft random
            index++;
            if (index > 2)
            {
                index = 0;
            }
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
        Debug.Log(ballPrefabs[index]);

    }


}
