using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;

    Animator animator;
    Rigidbody2D rb;

    bool facingRight = true;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);

        if(moveInput < 0 && facingRight)
        {
            Flip();
        }

        if (moveInput > 0 && !facingRight)
        {
            Flip();
        }

        if (moveInput > 0 || moveInput <0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetMouseButton(0))
        {
            animator.SetTrigger("isAttacking");
        }


    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
