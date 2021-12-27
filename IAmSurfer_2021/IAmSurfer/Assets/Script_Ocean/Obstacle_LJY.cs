using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_LJY : MonoBehaviour
{
    public float speed;
    public int health;
    public Sprite[] sprites;

    SpriteRenderer spriteRenderer;
    //Rigidbody2D rigid;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //rigid = GetComponent<Rigidbody2D>();
        transform.rotation = Quaternion.Euler(0, 0, 30);
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //rigid.velocity = Vector2.right * speed;
    }

    void OnHit()
    {

    }

    void OnEdge()
    {
        /*
        if (collision.gameObject.tag == "BorderBullet")
            Destroy(gameObject);
        */
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
