using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager_blueHole : MonoBehaviour
{
    bool pauseActive = false;
    public void goToHome()
    {
        SceneManager.LoadScene("Home");

    }
    public void reTry()
    {
        SceneManager.LoadScene("OceanMap");
    }

    public void pauseBtn()
    {
        Time.timeScale = 0;
     }
    public void resumeBtn()
    {
        Time.timeScale = 1;
    }
}
