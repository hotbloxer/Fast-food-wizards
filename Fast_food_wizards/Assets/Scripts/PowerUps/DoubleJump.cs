using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : Ability
 {

    Player player;
    Level_control level_Control;

    public DoubleJump (Player player_set, Level_control level_Control_set)
    {
        player = player_set;
        level_Control = level_Control_set;
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }


    public void use_ability()
    {
        
        player.Double_jumps = player.Double_jumps + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
