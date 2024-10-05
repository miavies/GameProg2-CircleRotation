using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovement : MonoBehaviour
{
    public float objTranslateSpeed;
    public float xDirection;
    void Start()
    {
        objTranslateSpeed = 100f;
        if (transform.position.x < 0)
        {
            xDirection = 1;
        }
        else
        {
            xDirection = -1;
        }

    }

    void Update()
    {
        gameObject.transform.Translate(xDirection * objTranslateSpeed * Time.deltaTime, 0, 0);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }

}
