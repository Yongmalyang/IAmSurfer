using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (waitWHITE());
    }
    
    public IEnumerator waitWHITE()
    {
        yield return new WaitForSeconds (1f);
        GoOceanMap();
    }

    public void GoOceanMap()
    {
        SceneManager.LoadScene("OceanMap");
    }
  
}