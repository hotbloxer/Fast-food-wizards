using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControl : MonoBehaviour
{

    [SerializeField] GameObject[] stages;
    [SerializeField] Player player;


    int current_stage_index = 0;
    int stage_number = 0;
    List<int> stagesIndex = new List<int>();

    [SerializeField] private int _stage_change_limit = 10;

    private const int _upperDisplay = -1;
    private const int _lowerDisplay = 0;



    // Start is called before the first frame update
    void Start()
    {
        make_queue();
        
    }

    private void make_queue() 
    {
        // always start on 1, never end on 1; 
        // never place the same number twice in a row
        // except first level
        // a bundle can have as many numbers as you like

        List<List<int>> bundles = new List<List<int>>

        {
            new List<int> {0,1,2,3},
            new List<int> {1, 2, 3, 0 },
            new List<int> { 1, 4, 0, 3 },

        };

        

        foreach (List<int> bundle in bundles)
        {
            stagesIndex.AddRange(bundle);
            
        }

        foreach (int i in stagesIndex)
        {
            print("numbers of stages" + i);
        }

        
    }

    


    /// <summary>
    /// checks if the player is getting close to the end of a scene
    /// </summary>
    /// <returns></returns>
    private bool player_close_to_end ()
    {
        Vector3 player_pos = player.transform.position;
        Vector3 scene_start_pos = stages[current_stage_index].GetComponent<SceneScript>().Start_marker.transform.position;
 
        if (player_pos.y - scene_start_pos.y > _stage_change_limit)
        {
            return true;
        }
        return false;
    }



    private void change_current_scene()
    {

        // resets stageloop if we run out of stages
        if (current_stage_index + 1 > stagesIndex.Count - 1)
        {
            current_stage_index = 0;
        }


        GameObject previousStage = stages[current_stage_index];


        ++stage_number;
        current_stage_index = stagesIndex[stage_number];
        print("changing stage: " + stagesIndex[stage_number]);

        //TODO implement proper selction method
        stages[current_stage_index].transform.position =
            new Vector3(
                previousStage.transform.position.x,
                previousStage.transform.position.y + _stage_change_limit + 10,
                _upperDisplay);


        // lower previous stage to allow the new one to be visible
        previousStage.transform.position =
            new Vector3(
                previousStage.transform.position.x,
                previousStage.transform.position.y,
                _lowerDisplay);



        // reset spawned power pickups
        stages[current_stage_index].GetComponent<SceneScript>().Spawn_Powers();

    }


    // Update is called once per frame
    void Update()
    {

        if (player_close_to_end())
        {
            change_current_scene();
        }
    }
}
