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
        
    }

    // Update is called once per frame
    void Update()
    {
        int lives_left = PlayerController.Instance.playerData.lives;

        for(int i=2; i>= lives_left; i--)
        {
            MyHealth[i].gameObject.SetActive(false);
        }

        if (PlayerController.Instance.playerData.game_over == true)
        {
            GameOverPanel.gameObject.SetActive(true);
        }
    }
}
