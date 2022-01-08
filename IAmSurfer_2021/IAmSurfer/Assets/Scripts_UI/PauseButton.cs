using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    bool pauseActive = false;

    public void pauseBtn()
    {
        if(pauseActive)
        {
            Time.timeScale = 1;
            pauseActive = false;
        }
        else
        {
            Time.timeScale = 0;
            pauseActive = true;
        }
    }
}
