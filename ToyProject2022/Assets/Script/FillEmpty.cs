using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillEmpty : MonoBehaviour
{
    GameObject Placement;
    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hit;
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.forward), out hit, 1f))
            {
                Debug.Log("cube devant    2");
                if (hit.transform.gameObject.tag == "Empty")
                {
                    Debug.Log("cube devant    Empty");
                    Placement = Instantiate(gameObject, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
            }

            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.back), out hit, 1f))
            {
                if (hit.transform.gameObject.tag == "Empty")
                {
                    Placement = Instantiate(gameObject, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
            }
            
            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.right), out hit, 1f))
            {
                if (hit.transform.gameObject.tag == "Empty")
                {
                    Placement = Instantiate(gameObject, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
            }

            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.left), out hit, 1f))
            {
                if (hit.transform.gameObject.tag == "Empty")
                {
                    Placement = Instantiate(gameObject, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
