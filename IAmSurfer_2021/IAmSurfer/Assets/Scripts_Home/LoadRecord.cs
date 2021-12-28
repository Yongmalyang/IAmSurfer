using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadRecord : MonoBehaviour
{
    public TextMeshProUGUI txt_record;

    public int resource;
    // Start is called before the first frame update
    public void click_record()
    {
        resource = PlayerController.Instance.playerData.best_score;
        txt_record.text = resource.ToString();
    }
}
