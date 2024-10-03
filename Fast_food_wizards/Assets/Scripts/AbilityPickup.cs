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




    private Ability current_ability;

    private enum abilities {DOUBLEJUMP, SPAWNMEAT, SUICIDE}



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

            case abilities. SPAWNMEAT:
                // TODO
                current_ability = new SpawnMeat(player, level, platform);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
