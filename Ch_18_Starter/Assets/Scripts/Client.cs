using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public int gridRows = 10;
    public int gridColumns = 10;
    public Transform parent;

    void Start()
    {
        GenerateCorners();
        GenerateTerrain();
    }

    private void GenerateTerrain()
    {
        for (int x = 0; x < gridRows; x++)
        {
            for (int z = 0; z < gridColumns; z++)
            {

            }
        }
    }

    public void GenerateCorners()
    {
        List<Vector2Int> corners = Utilities.GetCorners(gridRows, gridColumns);

        foreach(Vector2Int corner in corners)
        {
            
        }
    }
}