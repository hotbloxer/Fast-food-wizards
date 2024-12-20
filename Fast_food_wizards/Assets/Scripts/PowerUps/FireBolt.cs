using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class FireBolt : Ability
{

    
    [SerializeField] GameObject _fireBolt;
    [SerializeField] Player _player;



    public void Start()
    {
        icon = GetComponent<SpriteRenderer>().sprite;
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
        _fireBolt.gameObject.transform.position = new Vector3 (-50,-50, 1);

    }
 

}

