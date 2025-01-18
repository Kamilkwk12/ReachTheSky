using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    private bool changeScene = false;

    void Update()
    {
        if (changeScene)
        {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        changeScene = true;
    }
}
