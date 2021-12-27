using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_LJY : MonoBehaviour
{
    public GameObject[] ObstacleObjs;
    public Transform[] spawnPoints;

    public float maxSpawnDelay;
    public float curSpawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if (curSpawnDelay > maxSpawnDelay) {
            SpawnObstacle();
            //UnityEngine.Debug.Log("스폰성공");
            maxSpawnDelay = Random.Range(0.5f, 3f);
            curSpawnDelay = 0;
        }
    }

    void SpawnObstacle() 
    {
        int randObstacle = Random.Range(0, 4);
        //int randObstacle = 0;
        int randPoint = Random.Range(0, 10);

        //GameObject myInstance = (GameObject) Instantiate(ObstacleObjs[0], spawnPoints[0].position, Quaternion.identity);
        //gameObject.Add(myInstance);
        //myInstance.GetComponent<MyChild>().Init();
        //myInstance.SetActive(true);

        //GameObject myInstance = Instantiate(ObstacleObjs[0]) as GameObject;
        //myInstance.transform.position = spawnPoints[0].position;

        Instantiate(ObstacleObjs[randObstacle],
            spawnPoints[randPoint].position,
            spawnPoints[randPoint].rotation);
    }
}
