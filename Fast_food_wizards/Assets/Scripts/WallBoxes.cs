using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBoxes : MonoBehaviour
{

    [SerializeField] private Transform player;



    void Update()
    {
      
       transform.position = new Vector2(transform.position.x, player.position.y);
        
    }
}
