using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBehavior : MonoBehaviour
{
    public GameObject yellow;
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
            
            if (hit.transform.gameObject.tag == "Green")
            {
                Debug.Log("cube devant Green");
                Instantiate(yellow,hit.transform.position + Vector3.up * 1,hit.transform.rotation);
                //Destroy(hit.transform.gameObject);
            }
        }
        
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.back),
                out hit, 1f))
        {
            Debug.Log("cube devant    2");
            
            if (hit.transform.gameObject.tag == "Green")
            {
                Debug.Log("cube devant Red");
                Instantiate(yellow,hit.transform.position + Vector3.up * 1,hit.transform.rotation);
                //Destroy(hit.transform.gameObject);
            }
        }
        
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.right),
                out hit, 1f))
        {
            Debug.Log("cube devant    2");
            
            if (hit.transform.gameObject.tag == "Green")
            {
                Debug.Log("cube devant Green");
                Instantiate(yellow,hit.transform.position + Vector3.up * 1,hit.transform.rotation);
                //Destroy(hit.transform.gameObject);
            }
        }
        
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.left),
                out hit, 1f))
        {
            Debug.Log("cube devant    2");
            
            if (hit.transform.gameObject.tag == "Green")
            {
                Debug.Log("cube devant Green");
                Instantiate(yellow,hit.transform.position + Vector3.up * 1,hit.transform.rotation);
                //Destroy(hit.transform.gameObject);
            }
        }
    }
}
