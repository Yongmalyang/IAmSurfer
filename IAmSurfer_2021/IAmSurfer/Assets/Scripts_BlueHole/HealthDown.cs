using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDown : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider;
    public GameManager gameManager;
    public int health;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //만약 "Enemy" tag인 오브젝트와 충돌한다면
        if(collision.gameObject.tag == "Enemy")
        {
            //플레이어의 모습 변화

            spriteRenderer.color = new Color(1, 0, 0, 0.4f); //플레이어 색 변화
            gameObject.layer = 8; //OnDamaged layer로 바꿔줌으로써 잠시 무적타임

            Invoke("OffDamaged", 3); //무적 타임 3초 후 해제
            

            if (health > 1) //목숨 2개 이상일 때
            {
                health--; //목숨 하나 감소
                Debug.Log("남은 목숨은" + health + "개입니다."); //남은 목숨 표시
            }
            else //남은 목숨 한개였을 경우
            {
                health--;
                Debug.Log("게임 오버");
                //게임 오버일 때 보여줄 함수 호출
            }
        }
    }
    void OffDamaged()
    {
        gameObject.layer = 9;
        spriteRenderer.color = new Color(1, 1, 1, 1);
    }
}
