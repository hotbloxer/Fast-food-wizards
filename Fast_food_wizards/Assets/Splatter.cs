using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{

    public HealthManager healthmanager;
    public Animator animator;
    public BoxCollider2D boxCollider;
    public Rigidbody2D rb;
    private float delay = 2;
    private bool stopanim;

    private void Update()
    {
        delay -= Time.deltaTime;
        if( delay <= 1 && !stopanim)
        {
            animator.SetBool("Godumb", true);
            stopanim = true;
        }

        if (delay <= 0)
        {
            boxCollider.isTrigger = true;
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.AddTorque(3);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            healthmanager.take_damage(10);
        }
    }
}
