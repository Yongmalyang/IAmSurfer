using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleMove_LJY : MonoBehaviour
{
    public float speed;
    SpriteRenderer spriteRenderer;
    //Rigidbody2D rigid;

    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //rigid = GetComponent<Rigidbody2D>();
        //Vector2 myVector = new Vector2(0,0);
        //myVector.rotation = Quaternion.Euler(0, 0, 30);
        //rigid.velocity = Vector2.right * speed;


    }


    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 10);
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //PlayerController.Instance.playerData.score += 1;
        

    }

    
}
