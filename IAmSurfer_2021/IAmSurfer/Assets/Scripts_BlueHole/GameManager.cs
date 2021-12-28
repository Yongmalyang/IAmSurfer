using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;
    public PlayerMove player;
    public bool isOver;
    [SerializeField] public TextMeshProUGUI UICoin;

    void Update()
    {
        UICoin.text = PlayerController.Instance.playerData.money.ToString();
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        player = GetComponent<PlayerMove>();
    }
    
    
}
