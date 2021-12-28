using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundvolume : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Update()
    {
        if (!PlayerController.Instance.playerData.sound)
            AudioListener.volume = 0;

        else AudioListener.volume = 1;


    }
}
