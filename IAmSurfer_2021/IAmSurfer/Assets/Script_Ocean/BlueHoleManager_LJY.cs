using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueHoleManager_LJY : MonoBehaviour
{
    public GameObject BlueHoleObj;
    public Transform[] spawnPoints;

    public float SpawnDelay;
    public float curSpawnDelay;

    // Update is called once per frame
    void Update()
    {
        curSpawnDelay += Time.deltaTime;
        if (curSpawnDelay > SpawnDelay)
        {
            SpawnBlueHole();
            curSpawnDelay = 0;
        }
    }

    void SpawnBlueHole()
    {
        //int randObstacle = Random.Range(0, 4);
        //int randObstacle = 0;
        int randPoint = Random.Range(0, 10);

        Instantiate(BlueHoleObj,
            spawnPoints[randPoint].position,
            spawnPoints[randPoint].rotation);
    }
}
