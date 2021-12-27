using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDown : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider;
    GameManager gameManager;
    PlayerMove player;
    public GameManager gameControllor;
    public Image[] UILives;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        gameControllor = GetComponent<GameManager>();
        player = GetComponent<PlayerMove>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //만약 "Enemy" tag인 오브젝트와 충돌한다면
        if (collision.gameObject.tag == "Enemy")
        {
            //플레이어의 모습 변화

            spriteRenderer.color = new Color(1, 0, 0, 0.4f); //플레이어 색 변화
            gameObject.layer = 8; //OnDamaged layer로 바꿔줌으로써 잠시 무적타임

            Invoke("OffDamaged", 3); //무적 타임 3초 후 해제

            if (PlayerController.Instance.playerData.lives > 1) //목숨 2개 이상일 때
            {
                PlayerController.Instance.playerData.lives--; //목숨 하나 감소
                UILives[PlayerController.Instance.playerData.lives].color = new Color(1, 1, 1, 0);
                Debug.Log("남은 목숨은" + PlayerController.Instance.playerData.lives + "개입니다."); //남은 목숨 표시
            }
            else //남은 목숨 한개였을 경우
            {
                PlayerController.Instance.playerData.lives--;
                UILives[0].color = new Color(1, 1, 1, 0);
                player.OnDie();
                Debug.Log("게임 오버");
                //게임 오버일 때 보여줄 함수 호출
            }
        }
    }
    public void OffDamaged()
    {
        gameObject.layer = 9;
        spriteRenderer.color = new Color(1, 1, 1, 1);
    }
}
    

