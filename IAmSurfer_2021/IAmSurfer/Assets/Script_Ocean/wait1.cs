using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (waitBLACK());
    }
    
    public IEnumerator waitBLACK()
    {
        yield return new WaitForSeconds (4f);
        GoBluehole();
    }

    public void GoBluehole()
    {
        SceneManager.LoadScene("haeun_new");
    }
  
}
