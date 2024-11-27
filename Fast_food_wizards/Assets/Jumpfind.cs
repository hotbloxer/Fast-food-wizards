using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpfind : MonoBehaviour
{
    Vector2 startpos;
    Vector2 startscale;
    public Jump jumpstate;
    public Wander wanderstate;
    public Statemanagerfries stateManager;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        startscale = transform.localScale;
        init();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Walls" && wanderstate.delay <= 0)
        {
            print("Collision target:" + collision.transform.position);
            init();
            jumpstate.target = collision.transform.position;
            wanderstate.jump = true;
        }
    }

    private void init()
    {
        transform.position = startpos;
        transform.eulerAngles = new Vector2(0,0);
        transform.localScale = startscale;
    }
}
