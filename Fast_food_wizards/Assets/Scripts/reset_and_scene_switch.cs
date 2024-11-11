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


    public void reset_game()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
