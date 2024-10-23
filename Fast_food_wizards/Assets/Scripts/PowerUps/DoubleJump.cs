using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : Ability
 {


    [SerializeField] private Player player;
    [SerializeField] private WallBoxes level_Control;

    private void Start()
    {
        icon = GetComponent<SpriteRenderer>().sprite;
    }

    public DoubleJump(Player player_set, WallBoxes level_Control_set)
    {
        player = player_set;
        level_Control = level_Control_set;
        
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
