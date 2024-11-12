using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class HighScore : MonoBehaviour
{

    [SerializeField] TMP_Text[] score_label;
    [SerializeField] TMP_InputField nameInput;
    private int score; 

    private const int amountOfVisibleScores = 6;

    private string highscoreName;
    private List<string> highScore = new List<string> ();

    public void SetScore(int score)
    {
        this.score = score;
    }

    private void LoadHighscore()
    {
        for (int i = 0; i < amountOfVisibleScores; i++) 
        {
            if (PlayerPrefs.GetString(i.ToString()) != "")
            {
                
                 highScore.Add (PlayerPrefs.GetString(i.ToString()));
            }

            else
            {
                highScore.Add( "Peter : 0");
            }
        }
    }

    public void SetNameForHighscore ()
    {
        highscoreName = nameInput.text;
        print(highscoreName);
    }
    private void SetHighscoreLabels ()
    {
        for (int i = 0; i < amountOfVisibleScores; i++)
        {
            score_label[i].text = highScore[i];
        }
    }

    private int GetScoreFromString(string rawScore)
    {
        return int.Parse(rawScore.Split(':')[1]);
    }

    public bool IsScoreHigherThanLastOnScoreboard (int score)
    {
        return GetScoreFromString(highScore[5]) < score;  
    }

    private string CombineScoreAndName (string name, int score)
    {
        return name + " : " + score;
    }
    

    public void AcceptName ()
    {
        GetPlacementIndexOnHighscore();
        InsertInHighScore(GetPlacementIndexOnHighscore());
        RemoveLastEntryInHighScore();
        SaveHighScore();
      
    }

    private void InsertInHighScore (int index)
    {
        highScore.Insert(index, CombineScoreAndName(highscoreName, score));
    }

    private void RemoveLastEntryInHighScore ()
    {
        highScore.RemoveAt(highScore.Count - 1);
    }
    private int GetPlacementIndexOnHighscore ()
    {   
        for (int i = 0; i < highScore.Count; i++)
        {
            if (score < GetScoreFromString(highScore[i]))
            {
                continue;
            }

            else if (score > GetScoreFromString(highScore[i]))
            {
                return i;
            }

            else 
            {
                return i;
            }

         
        }
        return -1;
    }


    private void SaveHighScore ()
    {
        for (int i = 0; i < amountOfVisibleScores; i++)
        {
            PlayerPrefs.SetString(i.ToString(), highScore[i]);
        }
    }

    private void ResetHighScore () 
    {
        for (int i = 0; i < amountOfVisibleScores; i++ )
        {
            PlayerPrefs.SetString(i.ToString(), $"Peter : {42 - i}");
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        //ResetHighScore();
        LoadHighscore();
        SetHighscoreLabels();

    }

    // Update is called once per frame
    void Update()
    {

    
        
    }
}
