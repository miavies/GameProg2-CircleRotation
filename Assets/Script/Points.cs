using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class Points : MonoBehaviour
{
    public float rotSpeed;

    void Start()
    {
        rotSpeed = 1f;
    }

    void Update()
    {
        gameObject.transform.Rotate(rotSpeed, rotSpeed, -rotSpeed/2);
    }
}
