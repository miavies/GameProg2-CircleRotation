using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public float camTranslateSpeed;
    public float targetZPosition;
    public TextMeshProUGUI scoreText;
    private string[] tagsToDestroy = { "Points", "Obstacles" };

    void Start()
    {
        camTranslateSpeed = 500f;  
        targetZPosition = 0;         
    }

    public void OnButtonClick()
    {
        StartCoroutine(StartOverScreen());
        scoreText.text = "0";
        foreach (string tag in tagsToDestroy)
        {
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject obj in objectsWithTag)
            {
                Destroy(obj);
            }
        }
    }

    private IEnumerator StartOverScreen()
    {
        yield return StartCoroutine(MoveCameraToPosition(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, targetZPosition)));
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
