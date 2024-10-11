using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class FireBolt : Ability
{

    public power_ui_library power_lib;
    GameObject _fireBolt;
    Player _player;
    [SerializeField] SpriteRenderer _spriteRenderer;
    private Texture2D local_icon;
   

    public FireBolt (Player player, GameObject fireBolt )
    {
        _player = player;
        _fireBolt = fireBolt;
        icon = power_lib.get_icon(power_ui_library.power_library.FIREBOLT);



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

