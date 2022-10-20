using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Snapper : MonoBehaviour
{
    public ViewportCreator viewportCreator;

    public List<GameObject> cubetypes;
    public List<GameObject> cubeinput;
    public List<Vector3> cube_pos;
    public GameObject c_green;
    public int count = 0;
    private int v1;

    private void Start()
    {
        RaycastHit hit;
        if (Physics.Raycast(c_green.transform.position, c_green.transform.TransformDirection(Vector3.forward), out hit, 0.5f))
        {
            Debug.Log("cube!");
        }
                
        else
        {
            Debug.Log("nothing");
        }
    }

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
                //Quaternion rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
                // create the object at the face center, and perpendicular to it:
                GameObject Placement = Instantiate(cubetypes[count]);
                cubeinput.Add((cubetypes[count]));
                cube_pos.Add(position);
                Random.Range(5f,10f);
                Placement.transform.position = position;
                //Placement.transform.rotation = rotation;
                
                //Instantiate( PrimitiveType.Cube as GameObject , position , rotation ) as GameObject;

                //création du bloc dans le viewport
                viewportCreator.ViewBloc(Placement, position);

            }
            else
            {
                Debug.Log("nothing");
            }
            
            if (Physics.Raycast(c_green.transform.position, c_green.transform.TransformDirection(Vector3.forward), out hit, 1f))
            {
                Debug.Log("cube devant!");
                Destroy(hit.transform.gameObject);
            }
                
            else
            {
                Debug.Log("rien devant");
            }

            if (Physics.Raycast(c_green.transform.position, c_green.transform.TransformDirection(Vector3.back), out hit, 1f))
            {
                Debug.Log("cube derrière!");
            }
            else
            {
                Debug.Log("rien derrière");
            }
            
            if (Physics.Raycast(c_green.transform.position, c_green.transform.TransformDirection(Vector3.right), out hit, 1f))
            {
                Debug.Log("cube à droite!");
            }
            
            else
            {
                Debug.Log("rien à droitee");
            }

            if (Physics.Raycast(c_green.transform.position, c_green.transform.TransformDirection(Vector3.left), out hit, 1f))
            {
                Debug.Log("cube à gauche!");
            }
            
            else
            {
                Debug.Log("rien à gauche");
            }
            
        }
        
        Vector3 forward = transform. TransformDirection(Vector3. forward) * 30;
        Debug. DrawRay(transform. position, Vector3.back, Color. green);

    }
}
