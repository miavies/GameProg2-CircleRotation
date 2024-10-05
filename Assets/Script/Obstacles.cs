using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float camTranslateSpeed;
    public float targetZPosition;

    void Start()
    {
        camTranslateSpeed = 500f;
        targetZPosition = -684f;
        
        Quaternion objectRotation = Quaternion.identity;
            int randomCase = Random.Range(1, 3);
            switch (randomCase)
            {
                case 1:
                    objectRotation = Quaternion.Euler(0, 0, 90);
                    break;
                case 2:
                    objectRotation = Quaternion.Euler(90, 0, 0);
                    break;
            }
        transform.rotation = objectRotation;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameOverScreen();
        } 
    }

    public void gameOverScreen()
    {
        StartCoroutine(MoveCameraToPosition(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, targetZPosition)));
    }

    private IEnumerator MoveCameraToPosition(Vector3 targetPosition)
    {
        while (Vector3.Distance(Camera.main.transform.position, targetPosition) > 0.01f)
        {
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, targetPosition, camTranslateSpeed * Time.deltaTime);
            yield return null; 
        }

        Camera.main.transform.position = targetPosition;
    }
}
