using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class AbilityPickup : MonoBehaviour
{

    [SerializeField] private Player player;
    [SerializeField] private WallBoxes level;
    [SerializeField] private abilities active_ability;
    [SerializeField] private GameObject platform;
    [SerializeField] private Power_holder power_holder;
    [SerializeField] private Ability double_jump;
    [SerializeField] private Ability spawn_meat;









    private Ability current_ability;

    

    private enum abilities {DOUBLEJUMP, SPAWNMEAT, SUICIDE, SUPERDOUBLEJUMP}

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {
            current_ability.grant_ability(power_holder, current_ability);
            Destroy(gameObject);
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        switch (active_ability)
        {
            default:

                break;

            case abilities.DOUBLEJUMP:
                current_ability = double_jump;
                break;

            case abilities.SPAWNMEAT:
                
                current_ability = spawn_meat;
                break;

            case abilities.SUICIDE:
                player.suicide();
                break;

            case abilities.SUPERDOUBLEJUMP:
                current_ability = double_jump;
                
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
