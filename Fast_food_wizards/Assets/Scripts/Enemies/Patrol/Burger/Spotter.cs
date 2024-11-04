using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotter : MonoBehaviour
{
    public PatrolState PatrolState;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {
            PatrolState.canSeePlayer = true;
        }
    }
}
