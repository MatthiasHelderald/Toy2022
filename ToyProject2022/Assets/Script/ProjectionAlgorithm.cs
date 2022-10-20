using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectionAlgorithm : MonoBehaviour
{
    public GameObject c_green;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(c_green.transform.position, transform.TransformDirection(Vector3.forward), out hit, 0.5f))
        {

        }

        if (Physics.Raycast(c_green.transform.position, transform.TransformDirection(Vector3.back), out hit, 0.5f))
        {

        }

        if (Physics.Raycast(c_green.transform.position, transform.TransformDirection(Vector3.right), out hit, 0.5f))
        {

        }

        if (Physics.Raycast(c_green.transform.position, transform.TransformDirection(Vector3.left), out hit, 0.5f))
        {

        }

        else
        {
            Debug.Log("nothing");
        }
    }
}
