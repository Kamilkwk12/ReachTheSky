using TMPro;
using UnityEngine;

public class ElevatorTriggerScript : MonoBehaviour 
{

    public Animator platformAnim;

    private bool isElevatorTriggered = false;

    void Update()
    {
        if (isElevatorTriggered && platformAnim.enabled == false)
        {
            platformAnim.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isElevatorTriggered = true;
    }
}
