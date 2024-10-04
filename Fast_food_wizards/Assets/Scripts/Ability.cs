using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{

    protected string name;
    protected string description;
    protected float cool_down;
    protected Sprite icon;

    public Sprite Icon { get => icon;} 

    protected enum ability_type {PERMANENT, ONETIME};

    virtual public void use_ability()
    {
        
    }

    virtual public void grant_ability(Power_holder power_holder, Ability ability)
    {
        power_holder.set_active_ability(ability);
    }



}
