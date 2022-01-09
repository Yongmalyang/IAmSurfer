using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurferColor : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerController.Instance.playerData.lives >= 1)
        {
            if (collision.gameObject.tag == "Obstacle")
            {
                Debug.Log("아야!");
                spriteRenderer.color = new Color(1, 0, 0, 0.4f);
                StartCoroutine(Delay());
            }
        }
        else if(PlayerController.Instance.playerData.lives <= 0)
        {
            spriteRenderer.color = new Color(1, 1, 1, 0.4f); //게임오버시 플레이어 색 변화
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.8f);
        PlayerOffDamaged();
    }
    public void PlayerOffDamaged()
    {
        Debug.Log("플레이어 색 다시 변화");
        spriteRenderer.color = new Color(1, 1, 1, 1f);
    }
}
