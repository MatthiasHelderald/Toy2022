using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform trackedObject;


    private void Update()
    {

        if (Input.GetAxis("Horizontal") >= 0)
        
        {
            transform.RotateAround(trackedObject.transform.position,Vector3.up,100*Time.deltaTime);
        }
        
        if (Input.GetAxis("Horizontal") <= 0)
        
        {
            transform.RotateAround(trackedObject.transform.position,Vector3.up,-100*Time.deltaTime);
        }
        
    }
}
