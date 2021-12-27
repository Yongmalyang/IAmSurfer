using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoPlay : MonoBehaviour
{
    // Start is called before the first frame update

    public void ClickToPlay()
    {
        SceneManager.LoadScene("OceanMap");
    }
}
