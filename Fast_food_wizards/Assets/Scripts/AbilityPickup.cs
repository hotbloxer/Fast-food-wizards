using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class AbilityPickup : MonoBehaviour
{

    [SerializeField] private Player player;
    [SerializeField] private WallBoxes level;
    [SerializeField] private abilities active_ability;



    private Ability current_ability;

    private enum abilities {DOUBLEJUMP, SUICIDE}



    private void OnTriggerEnter2D(Collider2D collision)
    {
        current_ability.use_ability();
    }


    // Start is called before the first frame update
    void Start()
    {
        switch (active_ability)
        {
            default:
                break;

            case abilities.DOUBLEJUMP:
                current_ability = new DoubleJump(player, level);
                break;
                
        }


        current_ability = new DoubleJump(player, level); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
