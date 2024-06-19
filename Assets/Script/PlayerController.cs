using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;

    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0.0f, 0.0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (horizontalInput > 0f)
        {
            animator.SetTrigger("Right");
        }
        else if (horizontalInput < 0f)
        {
            animator.SetTrigger("Left");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }

}
