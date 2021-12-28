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
                    (0f, 14.3f);
                float spawnX = Random.Range
                    (-9.5f, 9.5f);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(fistFloorEnemies[i], spawnPosition, Quaternion.identity);
            }
            for (int i = 0; i < secondFloorEnemies.Length; i++)
            {
                // 2층 스폰
                float spawnY = Random.Range
                    (14.3f, 34.4f);
                float spawnX = Random.Range
                    (-9.5f, 9.5f);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(secondFloorEnemies[i], spawnPosition, Quaternion.identity);
            }
            for (int i = 0; i < thirdFloorEnemies.Length; i++)
            {
                // 3층 스폰
                float spawnY = Random.Range
                    (34.4f, 52.1f);
                float spawnX = Random.Range
                    (-9.5f, 9.5f);

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
                    (-1.5f, 52.2f);
                float spawnX = Random.Range
                    (-9.5f, 9.5f);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(MoneyList[i], spawnPosition, Quaternion.identity);
            }
        }
    }
}
