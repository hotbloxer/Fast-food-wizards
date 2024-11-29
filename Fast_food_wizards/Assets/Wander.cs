using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : State
{
    public bool jump;
    public Jump jumpstate;
    public Jumpfind jumpfind;
    public float delay;
    public override State RunCurrentState()
    {
        if (delay <= 0)
        {
            jumpfind.transform.localScale += new Vector3(0.0f, 1f, 0) * Time.deltaTime;
        }
        if (jump)
        {
            jump = false;
            jumpstate.delay = 1.0f;
            return jumpstate;
        }
        delay -= Time.deltaTime;
        return this;
    }
}
