using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitySwap : MonoBehaviour
{
    private bool isJumping = false;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.gravityScale *= -1;
            isJumping = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
