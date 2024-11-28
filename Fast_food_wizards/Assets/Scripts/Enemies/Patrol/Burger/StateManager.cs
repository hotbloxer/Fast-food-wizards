using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    
    public State currentState;
    public float speed;
    public bool patroling = true;
    public bool attacking = false;
    public bool stunned = false;
    public AttackState Attack;
    public StunState Stun;
    public AudioSource bounce;
    void Update()
    {
        if (stunned)
        {
            currentState = Stun;
            stunned = false;
        }
            
        RunStateMachine();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (patroling)
        {
            Flip();
            bounce.Play();
        }
        if (attacking && collision.gameObject.name == "Player")
        {
            Attack.hitSomething = true;
        }
            
    }

    private void Flip()
    {
        if (transform.rotation.y == 0.0f)
        {
            transform.eulerAngles = new Vector2(
            transform.eulerAngles.x,
            transform.eulerAngles.y + 180);
        }
        else
        {
            transform.eulerAngles = new Vector2(
            transform.eulerAngles.x,
            transform.eulerAngles.y - 180);
        }
    }

    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState();

        if (nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(State nextState)
    {
        currentState = nextState;
    }
}
