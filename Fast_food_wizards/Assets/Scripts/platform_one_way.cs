using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private PlatformEffector2D effector;
   


    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

  
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            effector.rotationalOffset = 0;
        }


        if (Input.GetButtonDown("Vertical")) 
        {
         
            effector.rotationalOffset = 180;
        }


    }
}
