using UnityEngine;

public class SecondDialogBoxScript : MonoBehaviour
{
    public bool isAnimationTriggered = false;
    public int triggerCounter = 0;
    private Animation anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }
    void Update()
    {
        if (anim.isPlaying)
        {
            return;
        }
        if (isAnimationTriggered && triggerCounter == 0)
        {
            anim.Play();
            triggerCounter++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isAnimationTriggered = true;
        
    }
}
