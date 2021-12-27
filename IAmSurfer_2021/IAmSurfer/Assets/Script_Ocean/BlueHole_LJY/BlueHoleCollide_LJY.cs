using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueHoleCollide_LJY : MonoBehaviour
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
            UnityEngine.Debug.Log("블루홀과 플레이어와 충돌!!");
            //PlayerController.Instance.playerData.lives--;
            //UnityEngine.Debug.Log("지금 현재 남은 목숨: " + PlayerController.Instance.playerData.lives);
            //Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Wall")
        {
            //PlayerController.Instance.playerData.score++;
            //UnityEngine.Debug.Log("지금 현재 점수: " + PlayerController.Instance.playerData.score);
            //UnityEngine.Debug.Log("벽에 충돌!!");
            Destroy(gameObject);
        }
    }
}
