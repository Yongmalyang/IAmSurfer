using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait_white : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Invoke("Update", 5);
       Debug.Log("Will Scene Change after 5 seconds");

    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("OceanMap");
    }
}