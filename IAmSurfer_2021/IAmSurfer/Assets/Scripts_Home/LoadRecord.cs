using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadRecord : MonoBehaviour
{
    public TMP_Text txt_record;

    public int resource;
    // Start is called before the first frame update
    public void click_record()
    {
        txt_record = GetComponent<TMP_Text>();
        //resource = PlayerController.Instance.playerData.score;
        //txt_record.text = resource.ToString();
    }
}
