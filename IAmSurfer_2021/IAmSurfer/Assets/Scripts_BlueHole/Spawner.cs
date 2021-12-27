using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fistFloorEnemies;
    public GameObject[] secondFloorEnemies;
    public GameObject[] thirdFloorEnemies;
    public GameObject[] MoneyList;
    int EnemyRandCnt, MoneyRandCnt;

    void Start()
    {
        EnemyRandCnt = Random.Range(2, 6);
        for (int j = 0; j < EnemyRandCnt; j++)
        {
            for (int i = 0; i < fistFloorEnemies.Length; i++)
            {
                // 1층 스폰
                float spawnY = Random.Range
                    (-2.3f, 6.5f);
                float spawnX = Random.Range
                    (-9.5f, 9.0f);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(fistFloorEnemies[i], spawnPosition, Quaternion.identity);
            }
            for (int i = 0; i < secondFloorEnemies.Length; i++)
            {
                // 2층 스폰
                float spawnY = Random.Range
                    (5.5f, 16.5f);
                float spawnX = Random.Range
                    (-9.5f, 9.0f);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(secondFloorEnemies[i], spawnPosition, Quaternion.identity);
            }
            for (int i = 0; i < thirdFloorEnemies.Length; i++)
            {
                // 3층 스폰
                float spawnY = Random.Range
                    (15.5f, 25.0f);
                float spawnX = Random.Range
                    (-9.5f, 9.0f);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(thirdFloorEnemies[i], spawnPosition, Quaternion.identity);
            }
        }
        MoneyRandCnt = Random.Range(20, 50);
        for (int j = 0; j < MoneyRandCnt; j++)
        {
            for (int i = 0; i < MoneyList.Length; i++)
            {
                // 1,2,3층 한번에 스폰
                float spawnY = Random.Range
                    (-5.5f, 26.5f);
                float spawnX = Random.Range
                    (-9.5f, 9.9f);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(MoneyList[i], spawnPosition, Quaternion.identity);
            }
        }
    }
}
