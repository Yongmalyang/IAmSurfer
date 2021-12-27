using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollide_LJY : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //UnityEngine.Debug.Log("일단 충돌..");
        if (collision.gameObject.tag == "Player")
        {
            UnityEngine.Debug.Log("코인 획득!!");
            PlayerController.Instance.playerData.money++;
            UnityEngine.Debug.Log("지금 현재 코인: " + PlayerController.Instance.playerData.money);
            gameObject.SetActive(false);
        }
        /*
        else if (collision.gameObject.tag == "Wall")
        {
            PlayerController.Instance.playerData.score++;
            UnityEngine.Debug.Log("지금 현재 점수: " + PlayerController.Instance.playerData.score);
            //UnityEngine.Debug.Log("벽에 충돌!!");
            Destroy(gameObject);
        }
        */
    }
}
