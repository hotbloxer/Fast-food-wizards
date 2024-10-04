using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor.U2D;
using UnityEngine;

public class Power_holder : MonoBehaviour
{

    Ability current_ability;
    [SerializeField] UI ui;
    [SerializeField] private GameObject firebolt_obj;
    [SerializeField] private Player _player;


    private float _firebolt_cooldown = 1;



    private float _fireball_cooldown_counter = 0;
    private bool _fireball_available = true;


    FireBolt _firebolt;




    public void set_active_ability (Ability ability)
    {
        current_ability = ability;

        
        ui.change_power_icon(current_ability);

    }



  


    // Start is called before the first frame update
    void Start()
    {
        _firebolt = new FireBolt(_player, firebolt_obj);
        _fireball_speed = _firebolt.Firebolt_speed;

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
            print("Fire");
            current_ability.use_ability();
        }




    }
}
