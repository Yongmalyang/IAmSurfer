using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Spawner spawner;
    public int nextMove; //행동지표 결정할 변수
    public float speed; // 속도 결정할 변수

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spawner = GetComponent<Spawner>();

        Invoke("Think", 2);
    }
   
    void FixedUpdate()
    {
        // 움직이기(속도)
        rigid.velocity = new Vector2(nextMove*speed, rigid.velocity.y);

        // 양 쪽 벽 만나면 되돌아가기
        /*
        Vector2 frontVector = new Vector2(rigid.position.x + nextMove * 0.3f, rigid.position.y);
        if ((rigid.position.x + nextMove) < (-7.8f) || (rigid.position.x + nextMove) > 7.8f)
            Turn();
        */
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //만약 장애물이 벽에 부딪힌다면
        if (collision.gameObject.tag == "Wall")
            Turn();
    }

    void Think()
    {
        // 다음 움직임 설정
        nextMove = Random.Range(-1, 2);
        float nextThinkTime = Random.Range(0, 4f);
        Invoke("Think", nextThinkTime); //재귀함수

        // 스프라이트 좌우 뒤집기
            Turn();
    }
    void Turn()
    {
        nextMove = nextMove * (-1);
        spriteRenderer.flipX = nextMove == 1;
        CancelInvoke();
        Invoke("Think", 3);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
