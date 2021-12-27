using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer_LJY : MonoBehaviour
{
    public JoystickValue_LJY value;

    void Update()
    {
        transform.Translate(value.joyTouch / 100);
    }
}