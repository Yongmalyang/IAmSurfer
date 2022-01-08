using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait_white : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Wait5Sec",5f);
        SceneManager.LoadScene("OceanMap");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
