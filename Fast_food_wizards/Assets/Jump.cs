using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : State
{
    public Vector2 target;
    public Transform transform;
    public Wander wanderstate;
    public float delay;
    public GameObject ParticlePos;

    public override State RunCurrentState()
    {
        return wanderstate;
        if (delay > 0)
        {
            ParticlePos.transform.localPosition = new Vector2(target.x, target.y + 1);
            ParticlePos.gameObject.SetActive(true);
        }
        else
        {
            ParticlePos.gameObject.SetActive(false);
            transform.position = new Vector2(target.x, target.y + 1);
            wanderstate.delay = 4;
            
        }
        return this;
    }
}
