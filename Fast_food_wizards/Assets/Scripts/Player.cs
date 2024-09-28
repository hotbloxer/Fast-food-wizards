using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _horizontal;
    private float _speed = 8f;
    private float _jumping_power = 16f;
    private bool _is_facing_right = true;
    private int _double_jump_max = 0;
    private int _jump_counter = 0;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform ground_check;
    [SerializeField] private LayerMask ground_layer;

    public int Double_jumps { set => _double_jump_max = value; get => _double_jump_max;}


    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");

        jump();


        flip();
    }


    private void jump ()
    {
        if (is_grounded())
        {
            _jump_counter = 0;
            // if the player touches ground, allow jump and reset _jump_counter
            if (Input.GetButtonDown("Jump") && is_grounded())
            {
                rb.velocity = new Vector2(rb.velocity.x, _jumping_power);
            }  
        } 
        else
        {
            if (Input.GetButtonDown("Jump") && _jump_counter < _double_jump_max)
            {
                rb.velocity = new Vector2(rb.velocity.x, _jumping_power);
                _jump_counter ++;
            }
        }





        // if the player is in the air, allow extra jump height while holding jump down
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        



    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(_horizontal * _speed, rb.velocity.y);
    }


    private void flip()
    {
        if (_is_facing_right && _horizontal < 0f || !_is_facing_right && _horizontal > 0f)
        {
            _is_facing_right =!_is_facing_right;
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
