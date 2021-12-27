using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] float setTime = 100.0f;
    [SerializeField] Text coundownText;
    void Start()
    {
        coundownText.text = "Time :" + setTime.ToString();
    }

    void Update()
    {
        if(setTime>0)
        {
            setTime -= Time.deltaTime;
        }
        else
        {
            Time.timeScale = 0.0f;
        }
        coundownText.text = "Time : "+ Mathf.Round(setTime).ToString();


    }
}
