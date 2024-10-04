using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;

public class FireBolt : Ability
{


    
     
    GameObject _fireBolt;
    Player _player;




    public FireBolt (Player player, GameObject fireBolt)
    {
        _player = player;
        _fireBolt = fireBolt;
    }

    public void shoot()
    {


         
        _fireBolt.gameObject.transform.rotation = _player.transform.rotation;
        _fireBolt.gameObject.transform.position = _player.transform.position;
        _fireBolt.gameObject.GetComponent<FireBolt_Mechanics>().shoot();
      
    }

     public void stop_power ()
    {
        _fireBolt.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        _fireBolt.gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0;
        _fireBolt.gameObject.transform.position = new Vector3 (-10,-10, 10);

    }
 

}

