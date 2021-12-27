using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager_LJY : MonoBehaviour
{
    public GameObject[] CoinObj;
    //private BoxCollider area;
    public float SpawnDelay;
    public float curSpawnDelay;

    void Update()
    {
        curSpawnDelay += Time.deltaTime;
        if (curSpawnDelay > SpawnDelay)
        {
            SpawnCoin();
            curSpawnDelay = 0;
        }
    }


    void SpawnCoin()
    {
        for (int i = 0; i < 5; i++)
        {
            CoinObj[i].SetActive(true);
            Vector3 spawnPos = GetRandomPosition();
            CoinObj[i].transform.position = spawnPos;
        }

    }

    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        //Vector3 size = area.size;

        //int randX = Random.Range(-8, 8);
        //int randY = Random.Range(-5, 5);
        float posX = Random.Range(-7.5f, 7.5f);
        float posY = Random.Range(-4.5f, 4.5f);
        float posZ = -2.89746f;

        Vector3 spawnPos = new Vector3(posX, posY, posZ);

        return spawnPos;
    }
}
