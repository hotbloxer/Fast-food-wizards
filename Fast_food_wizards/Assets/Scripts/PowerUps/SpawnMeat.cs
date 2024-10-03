using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SpawnMeat : Ability
{

    private Player player;
    private WallBoxes level_Control;
    private GameObject platform;
    
    

    public SpawnMeat(Player player_set, WallBoxes level_Control_set, GameObject platform_set)
    {
        
        player = player_set;
        level_Control = level_Control_set;
        platform = GameObject.Instantiate(platform_set);
        

        

        
    }



    override public void use_ability()
    {
        
        platform.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y - 1, 0);


    }


}

