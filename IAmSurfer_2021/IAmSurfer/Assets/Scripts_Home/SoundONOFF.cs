using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundONOFF : MonoBehaviour
{
    public Image soundIcon;
    public Sprite sound_on;
    public Sprite sound_off;

    private void Start()
    {
        change(PlayerController.Instance.playerData.sound);
    }
    public void click_sound()
    {
        change(PlayerController.Instance.playerData.sound);
    }
    public void change(bool sound)
    {
        if(sound)//사운드가 켜져있을 때
        {
            PlayerController.Instance.playerData.sound = false;
            soundIcon.sprite = sound_off;

        }

        else//사운드 꺼져있을 때
        {
            PlayerController.Instance.playerData.sound = true;
            soundIcon.sprite = sound_on;
        }
    }

}
