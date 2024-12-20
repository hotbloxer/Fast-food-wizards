using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class Power_holder : MonoBehaviour
{

    Ability current_ability;
    [SerializeField] UI ui;
    [SerializeField] private GameObject firebolt_obj;
    [SerializeField] private Player _player;
    
         
    private float _firebolt_cooldown = 1;
    private float _fireball_cooldown_counter = 0;
    private bool _fireball_available = true;


    [SerializeField] private FireBolt _firebolt;


    public void set_active_ability (Ability ability)
    {
        current_ability = ability;

        ui.change_power_icon(current_ability);

    }

    public void reset_ability()
    {
        set_active_ability(_firebolt); 

    }




    // Start is called before the first frame update
    void Start()
    {
        reset_ability();

    }

    // Update is called once per frame
    void Update()
    {
        if (_fireball_available)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                _firebolt.shoot();
                _fireball_available = false;

            }
        }
        else
        {
            if (_fireball_cooldown_counter > _firebolt_cooldown)
            {
                _fireball_available = true;
                _fireball_cooldown_counter = 0;
                _firebolt.stop_power();
            }
            else
            {
                _fireball_cooldown_counter += 1f * Time.deltaTime;
            }
        }


        if(Input.GetButtonDown("Fire2") )
        {
            current_ability.use_ability();
        }




    }
}
