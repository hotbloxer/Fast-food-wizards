using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemanagerfries : MonoBehaviour
{
    public bool flip;
    public State currentState;
    public float speed;
    public BoxCollider2D BoxCollider2D;
    public Rigidbody2D rb;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "player")
        {
            Flip();
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

    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
        transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        if (flip)
        {
            Flip();
            flip = false; 
        }
        if (rb.velocity.y < 0.0f && BoxCollider2D.isTrigger == true)
        {
            BoxCollider2D.isTrigger = false;
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

    public void EnableTrigger()
    {
        BoxCollider2D.isTrigger = true;   
    }



}
