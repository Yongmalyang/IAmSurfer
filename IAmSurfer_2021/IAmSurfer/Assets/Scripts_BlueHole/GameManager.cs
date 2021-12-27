using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;
    public PlayerMove player;
    public bool isOver;
    public Text UICoin;

    void Update()
    {
        UICoin.text = "Coin : " + PlayerController.Instance.playerData.money.ToString();
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        player = GetComponent<PlayerMove>();
    }
    
    
}
