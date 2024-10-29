using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : Ability
 {


    [SerializeField] private Player player;
    [SerializeField] private WallBoxes level_Control;
    [SerializeField] private Power_holder power_holder;
    private int amount_of_jumps = 10;

    public override string Get_UI_text() 
    { 
       return amount_of_jumps.ToString(); 
    }

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
        amount_of_jumps = 10;
    }


    public override void use_ability()
    {
        player.Jump_in_air();
        amount_of_jumps -= 1;
        if (amount_of_jumps < 1)
        {
            power_holder.reset_ability();
        }
    }

}
