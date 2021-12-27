using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer_blue : MonoBehaviour
{
    public JoystickValue value;

    void Update()
    {
        transform.Translate(value.joyTouch / 50);
    }
}
