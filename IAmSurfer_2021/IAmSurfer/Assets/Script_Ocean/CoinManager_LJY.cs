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


        //GameObject myInstance = (GameObject) Instantiate(ObstacleObjs[0], spawnPoints[0].position, Quaternion.identity);
        //gameObject.Add(myInstance);
        //myInstance.GetComponent<MyChild>().Init();
        //myInstance.SetActive(true);

        //GameObject myInstance = Instantiate(ObstacleObjs[0]) as GameObject;
        //myInstance.transform.position = spawnPoints[0].position;

        for(int i=0; i<5; i++)
        {
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
        float posX = Random.Range(-8, 8);
        float posY = Random.Range(-5, 5);
        float posZ = 0;

        Vector3 spawnPos = new Vector3(posX, posY, posZ);

        return spawnPos;
    }
}
