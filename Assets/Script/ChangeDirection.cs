using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeDirection : MonoBehaviour
{
    public int direction;

    public int startDirection()
    {
        direction = 1;
        return direction;
    }

    public int directionChange()
    {
        if (Input.anyKeyDown)
        {
            direction = direction * (-1);
            
        }
        return direction;
    }
}
