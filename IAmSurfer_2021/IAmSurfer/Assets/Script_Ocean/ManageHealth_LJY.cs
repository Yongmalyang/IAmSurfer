using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageHealth_LJY : MonoBehaviour
{
    public Image[] MyHealth;
    public Image GameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerController.Instance.playerData.game_continue == false)
            GameDataReset();
    }

    // Update is called once per frame
    void Update()
    {
        int lives_left = PlayerController.Instance.playerData.lives;

        for(int i=2; i>= lives_left; i--)
        {
            MyHealth[i].gameObject.SetActive(false);
            MyHealth[i+3].gameObject.SetActive(true);
        }

        if (PlayerController.Instance.playerData.game_over == true)
        {
            GameOverPanel.gameObject.SetActive(true);
            PlayerController.Instance.playerData.game_continue = false;
            GameDataReset();
        }
    }

    void GameDataReset()
    {
        PlayerController.Instance.playerData.score = 0;
        PlayerController.Instance.playerData.money = 0;
        PlayerController.Instance.playerData.lives = 3;
        PlayerController.Instance.playerData.game_over = false;

        for (int j = 0; j<3; j++)
        {
            MyHealth[j].gameObject.SetActive(true);
            MyHealth[j+3].gameObject.SetActive(false);
        }
    }
}
