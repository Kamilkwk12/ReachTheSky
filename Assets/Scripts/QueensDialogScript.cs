using UnityEngine;
using UnityEngine.Playables;

public class QueensDialogScript : MonoBehaviour
{

    private bool isDialogTriggered = false;
    private PlayableDirector timeline;
    public Rigidbody2D player;

    private void Start()
    {
        timeline = gameObject.GetComponent<PlayableDirector>();
    }

    void Update()
    {
        if (isDialogTriggered)
        {
            timeline.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isDialogTriggered = true;
    }

}
