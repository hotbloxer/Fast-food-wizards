using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controls : MonoBehaviour
{

    [SerializeField] private Transform player;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (0, player.position.y, -10);
    }
}
