using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewportCreator : MonoBehaviour
{
    public GameObject vide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ViewBloc(GameObject bloc, Vector3 pos)
    {
        GameObject Placement = Instantiate(bloc);
        Placement.transform.position = new Vector3 (pos.x *3, 10, pos.z *3);

        Placement = Instantiate(bloc);
        Placement.transform.position = new Vector3 (pos.x *3+1, 10, pos.z *3);

        Placement = Instantiate(bloc);
        Placement.transform.position = new Vector3 (pos.x *3, 10, pos.z *3+1);

        Placement = Instantiate(bloc);
        Placement.transform.position = new Vector3 (pos.x *3-1, 10, pos.z *3);

        Placement = Instantiate(bloc);
        Placement.transform.position = new Vector3 (pos.x *3, 10, pos.z *3-1);

        if (Random.value >= 0.5)
        {
            Placement = Instantiate(bloc);
            Placement.transform.position = new Vector3 (pos.x *3+1, 10, pos.z *3+1);
        }
        else 
        {
            Placement = Instantiate(vide);
            Placement.transform.position = new Vector3 (pos.x *3+1, 10, pos.z *3+1);
        }
        if (Random.value >= 0.5)
        {
            Placement = Instantiate(bloc);
            Placement.transform.position = new Vector3 (pos.x *3+1, 10, pos.z *3-1);
        }
        else 
        {
            Placement = Instantiate(vide);
            Placement.transform.position = new Vector3 (pos.x *3+1, 10, pos.z *3-1);
        }
        if (Random.value >= 0.5)
        {
            Placement = Instantiate(bloc);
            Placement.transform.position = new Vector3 (pos.x *3-1, 10, pos.z *3+1);
        }
        else 
        {
            Placement = Instantiate(vide);
            Placement.transform.position = new Vector3 (pos.x *3-1, 10, pos.z *3+1);
        }
        if (Random.value >= 0.5)
        {
            Placement = Instantiate(bloc);
            Placement.transform.position = new Vector3 (pos.x *3-1, 10, pos.z *3-1);
        }
        else 
        {
            Placement = Instantiate(vide);
            Placement.transform.position = new Vector3 (pos.x *3-1, 10, pos.z *3-1);
        }
    }
}
