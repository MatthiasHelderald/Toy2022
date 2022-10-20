using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBehavior : MonoBehaviour
{
    void Start()
    {
        if (transform.position.y == 0)
        {
            transform.tag = "Experiment";
        }
    }
}
