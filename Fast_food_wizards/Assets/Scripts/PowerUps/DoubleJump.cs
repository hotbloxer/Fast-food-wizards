using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : Ability
 {

    private Player player;
    private WallBoxes level_Control;

    public DoubleJump (Player player_set, WallBoxes level_Control_set)
    {
        player = player_set;
        level_Control = level_Control_set;
    }


    override public void use_ability()
    {
       
        player.Double_jumps = player.Double_jumps + 1;
    }

}
