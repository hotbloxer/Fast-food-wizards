using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{

 
    [SerializeField] GameObject icon_displayer;


    private void Start()
    {
        
    }
    public void change_power_icon (Ability ability)
    {
        print("tes om sprite aktivrees");
        icon_displayer.GetComponent<UnityEngine.UI.Image>().sprite = ability.Icon;
        print("tes om sprite aktivrees");

    }

}
