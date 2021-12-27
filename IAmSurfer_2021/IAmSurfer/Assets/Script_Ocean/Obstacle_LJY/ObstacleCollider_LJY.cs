using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCollider_LJY : MonoBehaviour
{
    private Text ScoreText;
    private GameObject PauseUI;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;
    
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        //transform.rotation = Quaternion.Euler(0, 0, 30);
        //transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //UnityEngine.Debug.Log("일단 충돌..");
        if (collision.gameObject.tag == "Player")
        {
            UnityEngine.Debug.Log("플레이어와 충돌!!");
            PlayerController.Instance.playerData.lives--;
            UnityEngine.Debug.Log("지금 현재 남은 목숨: "+ PlayerController.Instance.playerData.lives);
            Destroy(gameObject);
            if(PlayerController.Instance.playerData.lives<=0)
                CallGameOver();
        }
        else if(collision.gameObject.tag == "Wall")
        {
            PlayerController.Instance.playerData.score++;
            UnityEngine.Debug.Log("지금 현재 점수: " + PlayerController.Instance.playerData.score);
            ScoreText = GameObject.Find("Score Text").GetComponent<Text>();
            ScoreText.text = PlayerController.Instance.playerData.score.ToString();
            //UnityEngine.Debug.Log("벽에 충돌!!");
            Destroy(gameObject);
        }
    }

    void CallGameOver()
    {
        UnityEngine.Debug.Log("게임오버..");
        PauseUI = GameObject.Find("BlackTransparent_pause").GetComponent<GameObject>();
        PauseUI.SetActive(true);
    }
}
