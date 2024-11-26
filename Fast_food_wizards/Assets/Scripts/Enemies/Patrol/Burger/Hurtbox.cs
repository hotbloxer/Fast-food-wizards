using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D burger;
    public int force;
    public HealthManager healthmanager;
    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {
            Debug.Log("Hit player!");
            healthmanager.take_damage(damage);
            /*Vector3 dir = rb.position - burger.position;
            rb.AddForce(dir * (force * burger.velocity) + new Vector2(10,10));*/
        }
    }
}
