using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollider_LJY : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;
    private TextMeshProUGUI CoinText;
    public AudioClip audioCoin;

    AudioSource audioSource;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        audioSource=GetComponent<AudioSource>();

    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UnityEngine.Debug.Log("코인 획득!");
            PlayerController.Instance.playerData.money++;
            UnityEngine.Debug.Log("지금 현재 코인: " + PlayerController.Instance.playerData.money);
            CoinText = GameObject.Find("Coin Text").GetComponent<TextMeshProUGUI>();
            CoinText.text = PlayerController.Instance.playerData.money.ToString();
            gameObject.SetActive(false);
            audioSource.clip=audioCoin;
            audioSource.Play();
        }
    }
}
