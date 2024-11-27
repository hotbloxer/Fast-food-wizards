using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformcheck : MonoBehaviour
{
    public Statemanagerfries fries;

    private void OnTriggerExit2D(Collider2D collision)
    {
       fries.flip = true;
    }
}
