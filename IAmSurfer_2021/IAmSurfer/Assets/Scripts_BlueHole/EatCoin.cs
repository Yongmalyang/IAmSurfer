using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCoin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        bool isCoin = collision.gameObject.name.Contains("coin");

        if (isCoin) //코인 획득 시 돈 증가
        {
            PlayerController.Instance.playerData.money += 1;
            Debug.Log(PlayerController.Instance.playerData.money);
        }
            
        collision.gameObject.SetActive(false);
    }

}
