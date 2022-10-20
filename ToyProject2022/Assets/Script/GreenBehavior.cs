using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBehavior : MonoBehaviour
{
    void Start()
    {
        if (transform.position.y == 0)
        {
            transform.tag = "Experiment";
        }
        RaycastHit hit;
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.forward),
                out hit, 1f))
        {
            Debug.Log("cube devant    2");
            
            if (hit.transform.gameObject.tag == "Red")
            {
                Debug.Log("cube devant Red");
                Destroy(hit.transform.gameObject);
            }
        }
    }
    
}