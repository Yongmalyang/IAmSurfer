using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfBoardSpawn : MonoBehaviour
{
    void Start()
    {
        // 랜덤 위치 설정
        float spawnY = Random.Range
                    (53.9f, 55.0f);
        float spawnX = Random.Range
            (-7.3f, 7.0f);

        transform.position = new Vector2(spawnX, spawnY);
    }

    void Update()
    {
        
    }
}
