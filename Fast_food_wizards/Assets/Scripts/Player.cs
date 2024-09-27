using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumping_power = 16f;
    private bool is_facing_right = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform ground_check;
    [SerializeField] private LayerMask ground_layer;


    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && is_grounded())
        {
            rb.velocity = new Vector2 (rb.velocity.x, jumping_power);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2 (rb.velocity.x, rb.velocity.y * 0.5f);
        }


        flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }


    private void flip()
    {
        if (is_facing_right && horizontal < 0f || !is_facing_right && horizontal > 0f)
        {
            is_facing_right =!is_facing_right;
            Vector3 localeScale =  transform.localScale;
            localeScale.x *= -1f;
            transform.localScale = localeScale;
        }
    }

    private bool is_grounded ()
    {
        return Physics2D.OverlapCircle(ground_check.position, 0.2f, ground_layer);
    }
}
