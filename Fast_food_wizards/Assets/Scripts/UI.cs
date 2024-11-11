using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    private Ability current_ability;
 
    [SerializeField] GameObject icon_displayer;
    [SerializeField] TMP_Text icon_text_displayer;
    [SerializeField] TMP_Text score_displayer;
    [SerializeField] Player player;
    [SerializeField] HighScore highScore;


    [SerializeField] GameObject you_died_panel;

    private int current_hearts_tracker = 2;
    [SerializeField] GameObject[] healt_icons; 

    private int score;



    



    private void Start()
    {
        you_died_panel.SetActive(false);
      
    }
    public void change_power_icon (Ability ability)
    {
        icon_displayer.GetComponent<UnityEngine.UI.Image>().sprite = ability.Icon;
        current_ability = ability;

    }



    public void you_died ()
    {
        you_died_panel.SetActive(true);
        Time.timeScale = 0;
        //TODO implement highscore input system
        if (highScore.CheckScore(score))
        {
            print("show new entry");
        }
    }


    public void LoseHeart ()
    {
        if (current_hearts_tracker < 0)
        {
            current_hearts_tracker = 0;
        }

        if (current_hearts_tracker < healt_icons.Length)
        
        {
            healt_icons[current_hearts_tracker].SetActive(false);
            --current_hearts_tracker;
        }
    }

    public void GainHeart()
    {
        healt_icons[current_hearts_tracker].SetActive(true);
        current_hearts_tracker++;
    }



    private void Update()
    {

        // check charges left in ability
        if (current_ability.Get_UI_text().Length >= 0)
        {
            icon_text_displayer.text = current_ability.Get_UI_text();
        }

        else
        {
            icon_text_displayer.text = "";
        }



        // check score
        if (player.transform.position.y > score)
        {
            score = (int)player.transform.position.y;
            score_displayer.text = "SCORE: " + score.ToString();
            
        }

    }

}
