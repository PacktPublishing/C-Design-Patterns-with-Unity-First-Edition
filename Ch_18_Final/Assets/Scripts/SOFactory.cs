using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOFactory : MonoBehaviour
{
    public List<SOTile> tiles;
    private static Dictionary<string, IFlyweight> _cache = new Dictionary<string, IFlyweight>();

    void Awake()
    {
        foreach(SOTile tile in tiles)
        {
            var key = tile.type.ToString();
            _cache.Add(key, tile);
        }
    }

    public static IFlyweight GetFlyweight(TerrainType type)
    {
        var key = type.ToString();
        return _cache[key];
    }

    public static Corner GetCorner()
    {
        return new Corner();
    }
}