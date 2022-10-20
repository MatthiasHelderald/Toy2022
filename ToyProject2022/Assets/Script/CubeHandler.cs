using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandler : MonoBehaviour {
 
    [SerializeField] int rows, columns;
    public MyCube[,] cubeGrid;
    [SerializeField]
    GameObject cubePrefab;
    static CubeHandler instance;
    public static CubeHandler Instance { get { return instance; } }
 
    void Awake()
    {
        if (instance) Destroy(this);
        else instance = this;
    }
 
    // Use this for initialization
    void Start () {
        rows = 4;
        columns = 4;
        cubeGrid = new MyCube[rows, columns];
        FillCubeGrid();
    }
     
    void FillCubeGrid () {
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                MakeCube(i, j);
            }
        }
    }
 
    void MakeCube(int i, int j){
        cubeGrid[i, j] = new MyCube { cube = Instantiate(cubePrefab, new Vector3(i,0, j), Quaternion.identity) as GameObject };
        cubeGrid[i, j].cube.transform.localScale = Vector3.one * 0.5f;
        //cubeGrid[i, j].cube.AddComponent<CubeMonoBehaviour>();
    }
}
 
 
 
public class MyCube  {
    public GameObject cube;
}

