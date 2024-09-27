using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float horizontal;
    private float speed;
    private float jumping_power = 16f;
    private bool is_facign_right = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform ground_check;
    [SerializeField] private LayerMask ground_layer;


    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("horizontal");

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (horizontal * speed, 0);
    }
}
