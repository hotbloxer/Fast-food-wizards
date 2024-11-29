using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtboxfries : MonoBehaviour
{
    public HealthManager healthmanager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Debug.Log("Hit player!");
            healthmanager.take_damage(10);
            /*Vector3 dir = rb.position - burger.position;
            rb.AddForce(dir * (force * burger.velocity) + new Vector2(10,10));*/
        }
    }
}
