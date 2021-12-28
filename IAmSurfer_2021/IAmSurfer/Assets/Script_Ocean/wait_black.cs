using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait_black : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Wait2Sec",2f);
        SceneManager.LoadScene("haeun_new");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

