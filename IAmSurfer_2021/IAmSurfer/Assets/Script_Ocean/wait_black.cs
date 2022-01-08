using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait_black : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Invoke("Update", 10f);
       Debug.Log("Will Scene Change after 10 seconds");

    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("haeun_new");
    }
}

