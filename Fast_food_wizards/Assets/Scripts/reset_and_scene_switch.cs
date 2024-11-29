using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class reset_and_scene_switch : MonoBehaviour
{
    private int stageint = 0;
    [SerializeField] StageControl stageControl;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void setNewIndex (int index)
    {  
        stageint = index;
    }

    public void StartNewGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }


    private void reset_game()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");

    }

    public void SwitchToStartPage ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start screen");
    }

    public void SwitchToGamePage()
    {

        reset_game();


    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
