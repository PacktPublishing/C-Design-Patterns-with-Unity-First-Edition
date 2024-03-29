using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static List<Vector2Int> GetCorners(int rows, int cols)
    {
        return new List<Vector2Int>
        {
            new Vector2Int(-1, -1),
            new Vector2Int(-1, rows),
            new Vector2Int(cols, rows),
            new Vector2Int(cols, -1)
        };
    }

    public static List<Vector2Int> GetIntersectTiles(int x, int z)
    {
        var center = new Vector2Int(x, z);
        return new List<Vector2Int>
        {
            center + Vector2Int.up,
            center + Vector2Int.down,
            center + Vector2Int.left,
            center + Vector2Int.right
        };
    }
}