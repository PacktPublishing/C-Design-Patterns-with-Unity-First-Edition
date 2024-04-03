using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public int gridRows = 10;
    public int gridColumns = 10;
    public Transform gridParent;

    private ExtrinsicState _context = new ExtrinsicState();

    void Start()
    {
        _context.parent = gridParent;

        GenerateCorners();
        GenerateTerrain();
    }

    private void GenerateTerrain()
    {
        for (int x = 0; x < gridRows; x++)
        {
            for (int z = 0; z < gridColumns; z++)
            {
                IFlyweight tile = null;
                _context.xCoord = x;
                _context.zCoord = z;

                if (Random.Range(0, 5) == 0)
                {
                    tile = SOFactory.GetFlyweight(TerrainType.Grass);
                }
                else if (Random.Range(0, 10) == 5)
                {
                    tile = SOFactory.GetFlyweight(TerrainType.Water);
                }
                else
                {
                    tile = SOFactory.GetFlyweight(TerrainType.Ground);
                }

                tile.Create(_context);
            }
        }
    }

    public void GenerateCorners()
    {
        List<Vector2Int> corners = Utilities.GetCorners(gridRows, gridColumns);
        foreach (Vector2Int corner in corners)
        {
            _context.xCoord = corner.x;
            _context.zCoord = corner.y;

            var cornerTile = SOFactory.GetCorner();
            cornerTile.Create(_context);
        }
    }
}