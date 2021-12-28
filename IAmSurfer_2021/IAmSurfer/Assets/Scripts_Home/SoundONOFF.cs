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
        PlayerController.Instance.playerData.sound = !PlayerController.Instance.playerData.sound;
        change(PlayerController.Instance.playerData.sound);
    }
    public void change(bool sound)
    {
        if(sound)//사운드가 켜져있을 때
        {
            soundIcon.sprite = sound_on;

        }

        else//사운드 꺼져있을 때
        {
            soundIcon.sprite = sound_off;
        }
    }

}
