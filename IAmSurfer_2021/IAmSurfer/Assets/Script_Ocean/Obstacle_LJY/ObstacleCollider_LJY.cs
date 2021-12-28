using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObstacleCollider_LJY : MonoBehaviour
{
    private TextMeshProUGUI ScoreText;
    private TextMeshProUGUI ScoreFinalText;
    private GameObject PauseUI;
    private SpriteRenderer spriteRenderer;

    //public Image Surfer;

    public Sprite[] sprites;
    Rigidbody2D rigid;
    //private AudioSource sound_attack;
    
    void Awake()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer = GameObject.Find("Surfer").GetComponent<SpriteRenderer>();
        //spriteRenderer = Surfer.GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        //sound_attack = GameObject.Find("sound_attck").GetComponent<AudioSource>();
        //transform.rotation = Quaternion.Euler(0, 0, 30);
        //transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {

        //UnityEngine.Debug.Log("일단 충돌..");
        if (collision.gameObject.tag == "Player")
        {
            //sound_attack.Play();
            //UnityEngine.Debug.Log("플레이어와 충돌!!");
            //spriteRenderer = GameObject.Find("Surfer").GetComponent<Sprite>();
            spriteRenderer = GameObject.Find("Surfer").GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprites[1];
            Invoke("ReturnSprite", 1f);
            UnityEngine.Debug.Log("이미지 잘 바뀜");
            PlayerController.Instance.playerData.lives--;
            UnityEngine.Debug.Log("지금 현재 남은 목숨: "+ PlayerController.Instance.playerData.lives);
            Destroy(gameObject);

            if (PlayerController.Instance.playerData.lives <= 0)
            {
                PlayerController.Instance.playerData.game_over = true;
                Time.timeScale = 0;
                int final_score = PlayerController.Instance.playerData.score + PlayerController.Instance.playerData.money * 2;
                //ScoreText = GameObject.Find("PlayerFinalScore").GetComponent<TextMeshProUGUI>();
                //ScoreText.text = "COIN "+PlayerController.Instance.playerData.money.ToString()+"* 2 + SCORE "
                //+ PlayerController.Instance.playerData.score.ToString()+"\nYOUR SCORE: "+final_score.ToString();
                //ScoreText.text = "YOUR SCORE";
                if (final_score> PlayerController.Instance.playerData.best_score)
                {
                    PlayerController.Instance.playerData.best_score = final_score;
                    UnityEngine.Debug.Log("최고 기록 갱신!!");

                }
            }
        }
        else if(collision.gameObject.tag == "Wall")
        {
            PlayerController.Instance.playerData.score++;
            //UnityEngine.Debug.Log("지금 현재 점수: " + PlayerController.Instance.playerData.score);
            ScoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();
            ScoreText.text = PlayerController.Instance.playerData.score.ToString();
            //UnityEngine.Debug.Log("벽에 충돌!!");
            Destroy(gameObject);
        }
    }

    void ReturnSprite()
    {
        spriteRenderer = GameObject.Find("Surfer").GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[0];

    }
    /*
    void CallGameOver()
    {
        UnityEngine.Debug.Log("게임오버..");
        PauseUI = GameObject.Find("BlackTransparent_pause").GetComponent<GameObject>();
        PauseUI.SetActive(true);
    }
    */
}
