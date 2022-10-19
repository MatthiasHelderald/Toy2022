using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    public List<GameObject> cubetypes;
    public int count = 0;
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            count = 0;
        }
        
        if (Input.GetKeyDown("2"))
        {
            count = 1;
        }
        
        if (Input.GetKeyDown("3"))
        {
            count = 2;
        }
            
            
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 2000))
            {
                // it's better to find the center of the face like this:
                Vector3 position = hit.transform.position + hit.normal;

                // calculate the rotation to create the object aligned with the face normal:
                Quaternion rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
                // create the object at the face center, and perpendicular to it:
                GameObject Placement = Instantiate(cubetypes[count]);
                Placement.transform.position = position;
                Placement.transform.rotation = rotation;



                //Instantiate( PrimitiveType.Cube as GameObject , position , rotation ) as GameObject;
            }
            else
            {
                Debug.Log("nothing");
            }
        }

    }
}
