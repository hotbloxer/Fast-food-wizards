using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunState : State
{
    public Transform BurgerTransform;
    public Transform player;
    public State patrolState;
    public PatrolState patrol;
    public AttackState attackState;
    public float delay = 3;
    float distance;
    public float maxDistance;



    private void Start()
    {
        if (GameObject.FindGameObjectsWithTag("Player")[0] != null)
        {
            player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        }
    }
    public override State RunCurrentState()
    {
        patrol.canSeePlayer = false;
        if (delay > 0)
        {
            delay -= Time.deltaTime;
        }
        else
        {
            distance = Vector3.Distance(BurgerTransform.position, player.position);
            if (distance > maxDistance)
            {
                transform.eulerAngles = new Vector2(0, 0);
                delay = 3;
                return patrolState;
            }
            else
            {
                delay = 3;
                attackState.hitSomething = false;
                return patrol;
            }
        }
        return this;
    }
}
