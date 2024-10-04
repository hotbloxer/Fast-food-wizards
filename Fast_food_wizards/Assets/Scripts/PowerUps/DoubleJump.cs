using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : Ability
 {

    private Player player;
    private WallBoxes level_Control;
    private string _icon_name = "Assets/Assets/PowerIcons/double jump.png";

    public DoubleJump(Player player_set, WallBoxes level_Control_set)
    {
        player = player_set;
        level_Control = level_Control_set;
        Console.WriteLine("set icon");
        icon = Resources.Load<Sprite>(_icon_name);
    }

    public override void grant_ability(Power_holder power_holder, Ability ability)
    {
        base.grant_ability(power_holder, ability);
        use_ability();

    }


    public override void use_ability()
    {

            player.Double_jumps = player.Double_jumps + 1;

    }

}
