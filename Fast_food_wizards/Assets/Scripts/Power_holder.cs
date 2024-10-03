using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class Power_holder : MonoBehaviour
{

    Ability current_ability;
    [SerializeField] UI ui;



    public void set_active_ability (Ability ability)
    {
        current_ability = ability;

        
        ui.change_power_icon(current_ability);

    }



  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1") )
        {
            print("Fire");
            current_ability.use_ability();
        }

    }
}
