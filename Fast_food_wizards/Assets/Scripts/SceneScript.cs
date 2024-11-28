using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SceneScript : MonoBehaviour
{

    [SerializeField] GameObject start_marker;
   
    [SerializeField] List<Transform> power_spawn_points;
    [SerializeField] List<Transform> enemy_spawn_points;
    [SerializeField] List<Transform> burger_spawn_points;

    [SerializeField] GameObject power_pickup;
    [SerializeField] GameObject enemy_to_spawn;
    [SerializeField] GameObject burger;


    [SerializeField] Transform player;
    [SerializeField] int  baseEnemyMultiplier;

    // TODO get higscore
    //int highscore = (int) player.transform.position.y;
    int highscore = 102;

    public GameObject Start_marker { get => start_marker; }
    public string Name { get => name; }

    // Start is called before the first frame update
    void Start()
    {

        Spawn_Burgers();

    }

    public void Activate_spawners ()
    {
        Spawn_enemies();
        
        try
        {
            Spawn_Powers();
            
        }

        catch { }
        
      

    }

    private void Spawn_Powers()
    {

        Transform new_powerup_transform = power_spawn_points[Random.Range(0, power_spawn_points.Count - 1)];
        GameObject newPowe = Instantiate(power_pickup);
        newPowe.transform.localPosition = new_powerup_transform.position;

    }



    private void Spawn_enemies ()
    {
        

        int indexToPick = 0;
        for (int i = 0; i < baseEnemyMultiplier + (highscore / 100); i++ )
        {
            Transform new_enemy_transform = enemy_spawn_points[Random.Range(0, enemy_spawn_points.Count - 1)];
            print(new_enemy_transform);
            GameObject new_enemy = Instantiate(enemy_to_spawn);
            new_enemy.transform.localPosition = new_enemy_transform.position;
        }
    }


    private void Spawn_Burgers()
    {
        if (burger_spawn_points.Count > 0)
        {
            for (int i = 0; i < 1 + (highscore / 100); i++)
            {

                if (i < burger_spawn_points.Count - 1)
                {
                    Transform new_enemy_transform = burger_spawn_points[Random.Range(0, burger_spawn_points.Count - 1)];
                    GameObject new_enemy = Instantiate(burger);
                    new_enemy.transform.localPosition = new_enemy_transform.position;
                }
            }

        }




    }

    int counter = 0;
    private void Update()
    {
        highscore = (int) player.transform.position.y;
    }

}
