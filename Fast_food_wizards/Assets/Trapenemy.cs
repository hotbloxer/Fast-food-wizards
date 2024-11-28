using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Trapenemy : MonoBehaviour
{
    public bool spawnnew;
    public TopTrap toptrap;
    public BottomTrap bottomTrap;
    public Animator animator;
    private bool startmove;
    private float delay = 2;
    public GameObject splatter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startmove) //&& animator.GetCurrentAnimatorStateInfo(0).IsName("Marker"))
        {
            animator.SetBool("Drawline", true);
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                toptrap.Move = true;
                bottomTrap.Move = true;
                animator.SetBool("Drawline", false);
            }
        }

        if (spawnnew)
        {
            splatter.SetActive(true);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player" && toptrap.Move == false)
        {
            animator.SetBool("Drawline",true);
            startmove = true;
        }
    }
}
