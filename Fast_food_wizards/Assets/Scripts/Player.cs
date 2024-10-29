using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _horizontal;
    public float _speed = 8f;
    public float _jumping_power = 16f;
    private bool _is_facing_right = true;
    private int _double_jump_max = 0; 
    private int _jump_counter = 0;

    private int _health = 3;
    [SerializeField] private float _max_fall_velocity = 10;
    private float fall_detector;



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



    public void Jump_in_air()
    {
        rb.velocity = new Vector2(rb.velocity.x, _jumping_power);
    }

    private void jump ()
    {


        if (Input.GetButtonDown("Jump") && is_grounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, _jumping_power);
            
        }  



        // if the player is in the air, allow extra jump height while holding jump down
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        



    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.relativeVelocity.magnitude >= _max_fall_velocity) 
        {

            print("take damgae");
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

        if (Physics2D.OverlapCircle(ground_check.position, 0.2f, ground_layer))
        {
            
            return true;
        }

        else
        {
            return false;
        }

       

    }
}
