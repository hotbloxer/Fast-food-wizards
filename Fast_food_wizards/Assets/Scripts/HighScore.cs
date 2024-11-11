using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class HighScore : MonoBehaviour
{

    [SerializeField] TMP_Text[] score_label;
    private const int amountOfVisibleScores = 6;

    private List<string> highScore = new List<string> ();


    private void LoadHighscore()
    {
        for (int i = 0; i < amountOfVisibleScores; i++) 
        {
            print(i);
            if (PlayerPrefs.GetString(i.ToString()) != "")
            {
                highScore.Add (PlayerPrefs.GetString(i.ToString()));
            }

            else
            {
                highScore.Add( "---");
            }
        }

    }

    private void SetHighscoreLabels ()
    {
        for (int i = 0; i < amountOfVisibleScores; i++)
        {
            score_label[i].text = highScore[i];
        }
    }


    public bool CheckScore (int newScore)
    {
        // check om score er højere end den laveste
        return newScore > int.Parse(highScore[highScore.Count - 1]) ? true: false;
    }




      public void SetNewScore (string name, int newScore)
    {   
        for (int i = 0; i< highScore.Count; i++)
        {
            if (newScore < int.Parse(highScore[i]))
            {
                continue;
            }

            if (newScore > int.Parse(highScore[i]))
            {
                highScore.Insert(i, name);
            }

            else
            {
                highScore.Insert(i+1, name);
            }
        }
        
        highScore.RemoveAt(highScore.Count - 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        LoadHighscore();
        SetNewScore("oeeter", 4);
        SetHighscoreLabels();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
