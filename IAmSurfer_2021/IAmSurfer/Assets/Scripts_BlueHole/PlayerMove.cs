using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }
    public void OnDie()
    {
        spriteRenderer.color = new Color(1, 1, 1, 0.4f); //색깔 어둡게
        spriteRenderer.flipY = true; // 위아래로 뒤집히기
        rigid.gravityScale = 10; // 중력 숫자 바꿔줘서 아래로 떨어지게 만들기

        //아래로 떨어지는 모습 조금 보여주고 GameOver 창 띄우기
        Invoke("Gameover", 2f); 
    }
    public void Gameover()
    {
        Time.timeScale = 0;
        // UI 구현하기
    }

}
