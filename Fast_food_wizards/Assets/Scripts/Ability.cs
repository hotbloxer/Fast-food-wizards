using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{

    protected string name;
    protected string description;
    protected float cool_down;
    protected Sprite icon;
    protected enum ability_type {PERMANENT, ONETIME};

    virtual public void use_ability()
    {
        
    }

}
