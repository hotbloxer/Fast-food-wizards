using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State
{
    public Transform BurgerTransform;
    public StateManager Manager;
    public bool canSeePlayer;
    public AttackState attackState;
    public override State RunCurrentState()
    {
        if (canSeePlayer)
        {
            attackState.hitSomething = false;
            return attackState;
        }
        else
        {
            BurgerTransform.transform.Translate(Manager.speed, 0.0f, 0.0f * Time.deltaTime);
            //Debug.Log("Moving!");
            Manager.patroling = true;
            Manager.attacking = false;
            return this;
        }
    }
}
