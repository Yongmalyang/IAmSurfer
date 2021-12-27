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
    private void Awake()
    {
        CheckHeartCnt();
    }
    //이 씬을 시작하기 바로 전 상황에서의 목숨 갯수를 생각하고 블루홀 씬의 하트 UI를 이에따라 나타내기
    void CheckHeartCnt()
    {
        if (PlayerController.Instance.playerData.lives == 3)
        {
            UILives[2].color = new Color(1, 1, 1, 1);
            UILives[1].color = new Color(1, 1, 1, 1);
            UILives[0].color = new Color(1, 1, 1, 1);
        }
        else if(PlayerController.Instance.playerData.lives == 2)
        {
            UILives[2].color = new Color(1, 1, 1, 0);
            UILives[1].color = new Color(1, 1, 1, 1);
            UILives[0].color = new Color(1, 1, 1, 1);
        }
        else if(PlayerController.Instance.playerData.lives == 1)
        {
            UILives[2].color = new Color(1, 1, 1, 0);
            UILives[1].color = new Color(1, 1, 1, 0);
            UILives[0].color = new Color(1, 1, 1, 1);
        }
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

            if (PlayerController.Instance.playerData.lives == 3) //목숨 3개일 때
            {
                PlayerController.Instance.playerData.lives--; //목숨 하나 감소
                UILives[2].color = new Color(1, 1, 1, 0);
                Debug.Log("남은 목숨은" + PlayerController.Instance.playerData.lives + "개입니다."); //남은 목숨 표시
            }
            else if(PlayerController.Instance.playerData.lives == 2) // 남은 목숨 2개일 경우
            {
                PlayerController.Instance.playerData.lives--; //목숨 하나 감소
                UILives[2].color = new Color(1, 1, 1, 0);
                UILives[1].color = new Color(1, 1, 1, 0);
                Debug.Log("남은 목숨은" + PlayerController.Instance.playerData.lives + "개입니다."); //남은 목숨 표시
            }
            else if(PlayerController.Instance.playerData.lives == 1)//남은 목숨 1개였을 경우
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
    

