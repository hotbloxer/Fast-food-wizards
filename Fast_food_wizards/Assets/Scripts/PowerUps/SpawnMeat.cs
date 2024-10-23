using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SpawnMeat : Ability
{

    [SerializeField] Player player;
    [SerializeField]  WallBoxes level_Control;
    [SerializeField] GameObject platform;

    private void Start()
    {
        icon = GetComponent<SpriteRenderer>().sprite;
    }

    public SpawnMeat()
    {

    }



    override public void use_ability()
    {
        
        platform.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y - 1, 0);


    }


}

