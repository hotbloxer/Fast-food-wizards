using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State
{
    public Transform BurgerTransform;
    public StateManager Manager;
    public bool canSeePlayer;
    public AttackState attackState;
    public Animator animator;
    public override State RunCurrentState()
    {
        animator.SetBool("Flap", true);
        if (canSeePlayer)
        {
            attackState.hitSomething = false;
            return attackState;
        }
        else
        {
            BurgerTransform.transform.Translate(Manager.speed * Time.deltaTime, 0.0f, 0.0f);
            //Debug.Log("Moving!");
            Manager.patroling = true;
            Manager.attacking = false;
            return this;
        }
    }
}
