using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : State
{
    public Vector2 target;
    public Rigidbody2D rb;
    public Wander wanderstate;
    public Statemanagerfries Statemanagerfries;
    public override State RunCurrentState()
    {
        Vector2 dir = (target - rb.position) * new Vector2(0.0f,(target.y - rb.position.y) * 5);
        rb.velocity = dir;
        Statemanagerfries.EnableTrigger();
        wanderstate.delay = 4;
        return wanderstate;
    }
}
