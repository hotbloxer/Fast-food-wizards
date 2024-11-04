using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AttackState : State
{
    public Transform BurgerTransform;
    public Transform Player;
    public Rigidbody2D rb;
    public bool hitSomething;
    public StateManager Manager;
    public StunState stunState;
    public int delay;
    public int force;
    public AudioSource grunt;
    

    public override State RunCurrentState()
    {
        Manager.patroling = false;
        Manager.attacking = true;
        if (hitSomething)
        {
            return stunState;
        }
        else
        {
            Vector2 target = Player.position - BurgerTransform.transform.position;

            //BurgerTransform.LookAt(target); //TODO Fix this??!!
            if (delay > 0)
            {
                delay--;
                Debug.Log("Delaying");
            }
            else
            {
                grunt.pitch = Random.Range(0.5f, 2.0f);
                grunt.Play();
                rb.AddForce(target * force);
                Debug.Log("CHARGEEEEEEEEEEEEEE!!!!!!");
                delay = 500;
            }
            return this;
        }
    }
}
