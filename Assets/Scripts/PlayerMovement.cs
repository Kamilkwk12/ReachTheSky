using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpPower = 2f;

    private float Move;

    public Rigidbody2D rb;
    public int doubleJump = 2;
    public bool isJumping = false;

    private bool isMovementActive = false;

    private void Start()
    {
        Invoke("activateMovement", 0);
    }

    void Update()
    {
        if (isMovementActive)
        {
            Move = Input.GetAxis("Horizontal");

            rb.linearVelocity = new Vector2(speed * Move, rb.linearVelocity.y);


            if (Input.GetKeyDown(KeyCode.W) && doubleJump > 0){
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
                doubleJump--;
            }
        }
    }

    private void activateMovement()
    {
        isMovementActive = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
            doubleJump = 2;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }
}
