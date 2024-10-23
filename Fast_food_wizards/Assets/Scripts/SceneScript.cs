using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{

    [SerializeField] GameObject start_marker;
    [SerializeField] string name;
    [SerializeField] List<Transform> power_spawn_points;
    [SerializeField] GameObject power_pickup;

    public GameObject Start_marker { get => start_marker; }
    public string Name { get => name; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Spawn_Powers ()
    {

        Transform new_powerup_transform = power_spawn_points[Random.Range(0, power_spawn_points.Count)];
        GameObject newPowe = Instantiate(power_pickup);
        newPowe.transform.localPosition = new_powerup_transform.position;

    }
 




}
