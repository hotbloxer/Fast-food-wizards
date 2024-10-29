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
    private Power_holder power_holder;

    private int amount_of_meat = 10;

    private void Start()
    {
        icon = GetComponent<SpriteRenderer>().sprite;
    }




    public override string Get_UI_text()
    {
        return amount_of_meat.ToString();
    }

    public override void grant_ability(Power_holder power_holder, Ability ability)
    {
        base.grant_ability(power_holder, ability);
        amount_of_meat = 5;
        this.power_holder = power_holder;
    }


    override public void use_ability()
    {
        
        platform.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 1, 0);
        amount_of_meat -= 1;

        if (amount_of_meat < 1)
        {
            power_holder.reset_ability();
        }

    }


}

