using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalSceneTrigger : MonoBehaviour
{
    private bool isFinalSceneTriggered = false;
    private void Update()
    {
        if (isFinalSceneTriggered)
        {
            SceneManager.LoadScene("FinalScene", LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isFinalSceneTriggered = true;
    }
}
