using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCoin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        bool isCoin = collision.gameObject.name.Contains("Coin");
        /* if (isCoin)
             gameManager.coinCnt += 1;
        */
        collision.gameObject.SetActive(false);
    }
}
