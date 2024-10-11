using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fireboltversion2 : MonoBehaviour
{

    [SerializeField] private SpriteRenderer icon_image;

    [SerializeField] private GameObject _fireBolt;
    [SerializeField] private Player _player;


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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
