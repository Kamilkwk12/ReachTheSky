using UnityEngine;

public class ChainPhysicsScript : MonoBehaviour
{
    
    private bool isNearChain = false;
    public Collider2D playerCollider;

    public void Update()
    {
        if (isNearChain)
        {
            playerCollider.sharedMaterial.friction = (float)0.4;
        }
        else
        {
            playerCollider.sharedMaterial.friction = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isNearChain = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isNearChain = false;
    }
}
