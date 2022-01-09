using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageHealthBluehole_LJY : MonoBehaviour
{
    public void GameDataReset()
    {
        PlayerController.Instance.playerData.score = 0;
        PlayerController.Instance.playerData.money = 0;
        PlayerController.Instance.playerData.lives = 3;
        PlayerController.Instance.playerData.game_over = false;


    }

}
