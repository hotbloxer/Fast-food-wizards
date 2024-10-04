using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBolt_Mechanics : MonoBehaviour
{
    private int _speed = 700;

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
        
        rb.AddForce(new Vector3(Random.Range(-1f, 1f) * Speed * 0.5f, Speed, 0));




    }
}
