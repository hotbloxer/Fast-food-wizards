using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{

 
    [SerializeField] UnityEngine.UI.Image icon_image;


    private void Start()
    {
        
    }
    public void change_power_icon (Ability ability)
    {
        icon_image = ability.Icon;
        

    }

}
