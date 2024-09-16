using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : ChangeDirection
{
    public GameObject pivotPoint;
    public float rotationSpeed;

    void Start()
    {
        rotationSpeed = 2f;
        startDirection();
    }

    void Update()
    {
        pivotPoint.transform.Rotate(0, directionChange()* rotationSpeed, 0);
    }
}
