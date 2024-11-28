using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class HatTipper : MonoBehaviour
{

    public Transform target;  

    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation(
            target.position - transform.position, 
            transform.TransformDirection(Vector3.up)
        );
        transform.rotation = new quaternion( 0 ,0 ,rotation.z, rotation.w);

       
    }
}
