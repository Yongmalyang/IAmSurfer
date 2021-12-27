using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleMove_LJY : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    private void Awake()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Euler(0, 0, 30);
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        PlayerController.Instance.playerData.score += 3;
        /*
        if (transform.position.x == 1400 || transform.position.y == 1000) {
            transform.Translate(1400, 1000, 0);
        }
        */
        /*
        if (transform.position == (200,200,0))
        {
            Destroy(transform);
        }
        */
    }

    
}
