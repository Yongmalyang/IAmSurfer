using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Countdown : MonoBehaviour
{
    [SerializeField] public float setTime = 100.0f;
    [SerializeField] public TextMeshProUGUI countdownText;


    void Start()
    {
        countdownText.text = setTime.ToString();
    }

    void Update()
    {
        if(setTime>0)
        {
            setTime -= Time.deltaTime;
            if(setTime<=10.0f)
            {
                countdownText.text = Mathf.Round(setTime).ToString();
                countdownText.color = new Color(255 / 255f, 10 / 255f, 10 / 255f, 255 / 255f);
            }
        }
        else
        {
            countdownText.text = "<color=#ff0000>" + Mathf.Round(setTime).ToString() + "</color>";
            Time.timeScale = 0.0f;
        }
        countdownText.text = Mathf.Round(setTime).ToString();


    }
}
