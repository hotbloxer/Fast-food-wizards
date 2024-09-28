using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class AbilityPickup : MonoBehaviour
{

    [SerializeField] private Player player;
    [SerializeField] private Level_control level;


    private DoubleJump double_jump;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        double_jump.use_ability();
    }


    // Start is called before the first frame update
    void Start()
    {
        double_jump = new DoubleJump(player, level); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
