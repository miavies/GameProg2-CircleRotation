using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.CompareTag("Points"))
        {
            Destroy(collision.gameObject);
        }
    }
}
