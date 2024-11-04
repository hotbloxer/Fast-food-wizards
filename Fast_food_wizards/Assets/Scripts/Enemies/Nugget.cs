using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nugget : EnemyParent
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_speed,_speed, 0.0f * Time.deltaTime);
        transform.Rotate(0, 0, _speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        _speed *= 1.02f;
        print("Collision!");
    }
}

