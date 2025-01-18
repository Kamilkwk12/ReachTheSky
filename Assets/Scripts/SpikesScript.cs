using UnityEngine;

public class SpikesScript : MonoBehaviour
{
    public Rigidbody2D player;
    private Vector3 startPosition = new Vector3((float)-20.74, (float)-2.59, 0);
    private bool isHit = false;


    void Update()
    {
        if (isHit)
        {
            player.position = startPosition;
            isHit = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isHit = true;
    }
}
