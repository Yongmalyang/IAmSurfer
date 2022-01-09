using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManageHealth_LJY : MonoBehaviour
{
    private TextMeshProUGUI ScoreText;
    private TextMeshProUGUI CoinText;

    public Image[] MyHealth;
    public Image GameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        if (PlayerController.Instance.playerData.game_continue == false) {
            GameDataReset();
            SetOceanHearts();
        }
        else if (PlayerController.Instance.playerData.game_continue == true)
        {
            ScoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();
            ScoreText.text = PlayerController.Instance.playerData.score.ToString();
            CoinText = GameObject.Find("Coin Text").GetComponent<TextMeshProUGUI>();
            CoinText.text = PlayerController.Instance.playerData.money.ToString();
        }


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
            //GameDataReset();
        }
    }

    public void GameDataReset()
    {
        PlayerController.Instance.playerData.score = 0;
        PlayerController.Instance.playerData.money = 0;
        PlayerController.Instance.playerData.lives = 3;
        PlayerController.Instance.playerData.game_over = false;


    }

    public void SetOceanHearts()
    {
        for (int j = 0; j < 3; j++)
        {
            MyHealth[j].gameObject.SetActive(true);
            MyHealth[j + 3].gameObject.SetActive(false);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void Restart()
    {
        ScoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();
        ScoreText.text = "0";
        CoinText = GameObject.Find("Coin Text").GetComponent<TextMeshProUGUI>();
        CoinText.text = "0";
        Time.timeScale = 1;

    }

    public void ResumeGame()
    {
        ScoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();
        ScoreText.text = PlayerController.Instance.playerData.score.ToString();
        CoinText = GameObject.Find("Coin Text").GetComponent<TextMeshProUGUI>();
        CoinText.text = PlayerController.Instance.playerData.money.ToString();
        Time.timeScale = 1;

    }
}
