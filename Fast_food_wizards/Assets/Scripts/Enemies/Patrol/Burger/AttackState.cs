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
    public float delay;
    public int force;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public GameObject particles;

    private void Awake()
    {
         if (GameObject.FindGameObjectsWithTag("Player")[0] != null)
        {
            Player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        }


    }

    public override State RunCurrentState()
    {
        animator.SetBool("Flap", false);
        Manager.patroling = false;
        Manager.attacking = true;
        if (hitSomething)
        {
            particles.gameObject.SetActive(false);
            spriteRenderer.flipX = false;
            return stunState;
        }
        else
        {
            Vector2 target = Player.position - BurgerTransform.transform.position;
            /*if (delay < 1 && delay > 0)
            {
                delay -= Time.deltaTime;
            }
            else*/
            if (delay > 0)
            {
                //BurgerTransform.position += new Vector3(Random.Range(0.2f, 0.5f), Random.Range(1.0f, 2.5f), 0.0f) * Time.deltaTime;
                delay -= Time.deltaTime;
                Quaternion rotation = Quaternion.LookRotation(
                 target,
                 transform.TransformDirection(Vector3.up)
                     );
                BurgerTransform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
                spriteRenderer.flipX = true;
                //Debug.Log("Delaying");
            }
            else
            {
                particles.gameObject.SetActive(false);
                rb.AddForce(target * force);
                //Debug.Log("CHARGEEEEEEEEEEEEEE!!!!!!");
                delay = 1;
            }

            if (delay < 0.5 && delay > 0)
                particles.gameObject.SetActive(true);
            return this;
        }
    }
}
