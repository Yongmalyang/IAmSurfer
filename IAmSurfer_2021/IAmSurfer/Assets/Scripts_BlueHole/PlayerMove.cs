using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;
    public Image gameOverWindow;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }
    public void OnDie()
    {
        spriteRenderer.color = new Color(1, 1, 1, 0.4f); //색깔 어둡게
        spriteRenderer.flipY = true; // 위아래로 뒤집히기
        rigid.gravityScale = 100; // 중력 숫자 바꿔줘서 아래로 떨어지게 만들기

        //아래로 떨어지는 모습 조금 보여주고 GameOver 창 띄우기
        Invoke("Gameover", 1.5f);
    }
    public void Gameover()
    {
        PlayerController.Instance.playerData.game_over = true;
        Time.timeScale = 0;
        gameObject.layer = 9;
        gameOverWindow.gameObject.SetActive(true); //게임오버 창 띄우기
     
        //블루홀 내에서 죽었을 때에도 돈을 스코어로 변환해서 최고기록 저장
        int final_score = PlayerController.Instance.playerData.score + PlayerController.Instance.playerData.money * 2;
        if (final_score > PlayerController.Instance.playerData.best_score)
        {
            PlayerController.Instance.playerData.best_score = final_score;
            UnityEngine.Debug.Log("최고 기록 갱신!!");
            Debug.Log("최고기록은" + final_score);
        }
        else
        {
            Debug.Log("아쉽게도 최고기록 갱신하지 못함");
            Debug.Log("기록은" + final_score);
        }
        // 블루홀에서 게임 오버 시 데이터 관리
        BlueholeGamedataReset(); //게임 데이터 초기화
    }

    void BlueholeGamedataReset()
    {
        PlayerController.Instance.playerData.score = 0;
        PlayerController.Instance.playerData.money = 0;
        PlayerController.Instance.playerData.lives = 3;
        PlayerController.Instance.playerData.game_over = false;
    }

    // 블루홀 닿을 시 씬 이동
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "BlueHole")
        {
            SceneManager.LoadScene("LoadingScene2");
        }
    }

}
