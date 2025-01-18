using UnityEngine;

public class ElevatorScript : MonoBehaviour
{

    private bool isOnElevator;

    public Transform elevatorPosition;
    public Transform playerPosition; 


    void Update()
    { 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Wszed³");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Wszed³");
    }
}
