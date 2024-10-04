using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PatrolParent : EnemyParent
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_speed, 0.0f, 0.0f * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        _speed = _speed * -1;
        print("Collision!");
    }


}
