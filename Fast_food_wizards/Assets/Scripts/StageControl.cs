using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControl : MonoBehaviour
{

    [SerializeField] GameObject[] stages;
    [SerializeField] Player player;
    [SerializeField] int startStage;

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
        stagesIndex.Add(startStage);
        stagesIndex.Add(1);
        stagesIndex.Add(2);

        for (int i = 0; i < 20; i++)
        {
            stagesIndex.Add(Random.Range(0, stages.Length));
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
            
            //_stage_change_limit += _stage_change_limit; // adds distance to next trigger
            return true;
        }

        return false;

    }



    private void change_current_scene()
    {
        print("changing stage");
        GameObject previousStage = stages[current_stage_index];

        ++stage_number;
        current_stage_index = stagesIndex[stage_number];

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
