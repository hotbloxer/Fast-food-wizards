using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class power_ui_library : MonoBehaviour
{
    
    public Image fireboltImage;
    public Image doubleJump;


    public enum power_library {FIREBOLT, DOUBLEJUMP}


    public Image get_icon (power_library input)
    {
        switch (input)
        {
            default:
                return fireboltImage;

            case power_library.FIREBOLT:
                return fireboltImage;

            case power_library.DOUBLEJUMP:
                return doubleJump;
        }

    }




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
