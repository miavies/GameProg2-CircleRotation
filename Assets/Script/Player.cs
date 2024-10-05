using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Points"))
        {
            addPoints();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
    }

    public void addPoints()
    {
        int currentScore = int.Parse(scoreText.text);
        currentScore += 1;
        scoreText.text = currentScore.ToString();
    }
}
