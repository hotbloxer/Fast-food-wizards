using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBolt_Mechanics : MonoBehaviour
{
    private int _speed = 700;

    [SerializeField] Rigidbody2D player_Rb;

    [SerializeField] Rigidbody2D rb;

    public int Speed { get => _speed; set => _speed = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void shoot()
    {
        Vector3 velocity = player_Rb.velocity;
        Vector3 aim_direction = Vector3.Normalize(new Vector3(Random.Range(-0.2f, 0.2f), 1, 0));

        print(velocity);

        if (velocity.magnitude < 1) 
        {
            velocity = new Vector3(1,1,1);
        }



        rb.AddForce((aim_direction * Speed) + velocity);




    }
}
