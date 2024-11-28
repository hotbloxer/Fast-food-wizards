using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomTrap : MonoBehaviour
{
    public bool Move;
    public Rigidbody2D Rigidbody;
    public Trapenemy Trapenemy;
    public float speed;
    public HealthManager healthmanager;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Move)
        {
            Rigidbody.velocity = new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Burger")
        {
            Trapenemy.spawnnew = true;
            Object.Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Player")
        {
            healthmanager.take_damage(15);
        }
    }
}
