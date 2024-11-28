using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : State
{
    public Vector2 target;
    public Rigidbody2D rb;
    public Wander wanderstate;
    public Statemanagerfries Statemanagerfries;
    public float timeToTarget = 4.0f;

    public override State RunCurrentState()
    {
        Vector2 dir = target - rb.position;
        //Gravity float
        float gravity = Mathf.Abs(Physics2D.gravity.y);
        //Velocity i x-retning
        float vx = dir.x / timeToTarget;
        //velocity i y-retning
        float vy = ((dir.y + 0.5f * rb.gravityScale * timeToTarget * timeToTarget) / timeToTarget) * 1.33f;
        //Samlet velocity
        Vector2 velocity = new Vector2(vx, vy);

        //add force
        rb.AddForce(velocity * rb.mass, ForceMode2D.Impulse);

        rb.velocity = dir;
        Statemanagerfries.EnableTrigger();
        wanderstate.delay = 4;
        return wanderstate;
    }
}
